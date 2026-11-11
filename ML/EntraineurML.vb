Imports Microsoft.ML
Imports Microsoft.ML.Data

''' <summary>
''' Entraîne les deux modèles Machine Learning de l'application :
'''  1) Régression   : prédit la note finale (/20) à partir des notes précédentes et des absences
'''  2) Classification : prédit si l'élève est "en difficulté" (probabilité de moyenne &lt; 10)
'''
''' Les deux pipelines suivent la méthodologie standard : séparation train/test (80/20),
''' entraînement, puis évaluation avec les métriques adaptées à chaque tâche
''' (RMSE / R² pour la régression, Accuracy / AUC / F1 pour la classification).
''' </summary>
Public Class EntraineurML

    Public ReadOnly Contexte As New MLContext(seed:=42)

    Public Class ResultatEntrainement
        Public Property ModeleRegression As ITransformer
        Public Property ModeleClassification As ITransformer
        Public Property MetriquesRegression As RegressionMetrics
        Public Property MetriquesClassification As CalibratedBinaryClassificationMetrics
    End Class

    Public Function Entrainer(donnees As List(Of DonneesEleveML)) As ResultatEntrainement
        Dim donneesCompletes As IDataView = Contexte.Data.LoadFromEnumerable(donnees)
        Dim decoupage = Contexte.Data.TrainTestSplit(donneesCompletes, testFraction:=0.2)

        ' --- 1) Régression : prédiction de la note finale ---
        Dim pipelineRegression =
            Contexte.Transforms.Concatenate("Features", NameOf(DonneesEleveML.Note1), NameOf(DonneesEleveML.Note2),
                                             NameOf(DonneesEleveML.Note3), NameOf(DonneesEleveML.Absences),
                                             NameOf(DonneesEleveML.MoyennePrecedente)) _
                .Append(Contexte.Transforms.CopyColumns("Label", NameOf(DonneesEleveML.NoteFinale))) _
                .Append(Contexte.Regression.Trainers.Sdca(labelColumnName:="Label", featureColumnName:="Features"))

        Dim modeleRegression As ITransformer = pipelineRegression.Fit(decoupage.TrainSet)
        Dim predictionsRegression = modeleRegression.Transform(decoupage.TestSet)
        Dim metriquesRegression = Contexte.Regression.Evaluate(predictionsRegression, labelColumnName:="Label")

        ' --- 2) Classification binaire : élève en difficulté ou non ---
        Dim pipelineClassification =
            Contexte.Transforms.Concatenate("Features", NameOf(DonneesEleveML.Note1), NameOf(DonneesEleveML.Note2),
                                             NameOf(DonneesEleveML.Note3), NameOf(DonneesEleveML.Absences),
                                             NameOf(DonneesEleveML.MoyennePrecedente)) _
                .Append(Contexte.Transforms.Conversion.ConvertType("Label", NameOf(DonneesEleveML.EnDifficulte), DataKind.Boolean)) _
                .Append(Contexte.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName:="Label", featureColumnName:="Features"))

        Dim modeleClassification As ITransformer = pipelineClassification.Fit(decoupage.TrainSet)
        Dim predictionsClassification = modeleClassification.Transform(decoupage.TestSet)
        Dim metriquesClassification = Contexte.BinaryClassification.Evaluate(predictionsClassification, labelColumnName:="Label")

        Return New ResultatEntrainement With {
            .ModeleRegression = modeleRegression,
            .ModeleClassification = modeleClassification,
            .MetriquesRegression = metriquesRegression,
            .MetriquesClassification = metriquesClassification
        }
    End Function

    Public Sub Sauvegarder(resultat As ResultatEntrainement, dossier As String)
        Dim donneesVides As IDataView = Contexte.Data.LoadFromEnumerable(New List(Of DonneesEleveML))
        Contexte.Model.Save(resultat.ModeleRegression, donneesVides.Schema, IO.Path.Combine(dossier, "modele_note.zip"))
        Contexte.Model.Save(resultat.ModeleClassification, donneesVides.Schema, IO.Path.Combine(dossier, "modele_risque.zip"))
    End Sub

    ''' <summary>Formatte les métriques pour affichage dans l'interface (voir Frm_ML_Avance).</summary>
    Public Function FormatterMetriques(resultat As ResultatEntrainement) As String
        Dim r = resultat.MetriquesRegression
        Dim c = resultat.MetriquesClassification
        Return $"Régression (note finale) —  RMSE : {Math.Round(r.RootMeanSquaredError, 2)}   R² : {Math.Round(r.RSquared, 3)}" & vbCrLf &
               $"Classification (élève à risque) —  Accuracy : {Math.Round(c.Accuracy * 100, 1)}%   AUC : {Math.Round(c.AreaUnderRocCurve, 3)}   F1 : {Math.Round(c.F1Score, 3)}"
    End Function

End Class
