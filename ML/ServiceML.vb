Imports Microsoft.ML

''' <summary>
''' Façade utilisée par les formulaires : entraîne (une fois) les modèles au premier
''' appel, garde les moteurs de prédiction en mémoire, et expose des méthodes simples
''' PredireNoteFinale / PredireRisque. Isole toute la complexité ML.NET du reste de
''' l'application (principe de séparation des responsabilités).
''' </summary>
Public Class ServiceML

    Private ReadOnly Entraineur As New EntraineurML()
    Private DernierResultat As EntraineurML.ResultatEntrainement
    Private MoteurRegression As PredictionEngine(Of DonneesEleveML, PredictionNoteFinale)
    Private MoteurClassification As PredictionEngine(Of DonneesEleveML, PredictionRisque)

    Public ReadOnly Property EstEntraine As Boolean
        Get
            Return DernierResultat IsNot Nothing
        End Get
    End Property

    ''' <summary>
    ''' Entraîne les modèles. Utilise le jeu de données réelles si suffisant,
    ''' sinon complète avec des données synthétiques (voir GenerateurDonnees).
    ''' Renvoie un résumé texte des métriques pour affichage dans l'UI.
    ''' </summary>
    Public Function EntrainerLesModeles(Optional elevesRepo As EleveRepository = Nothing,
                                         Optional notesRepo As NoteRepository = Nothing) As String
        Dim jeuDonnees As List(Of DonneesEleveML)

        Dim jeuReel As List(Of DonneesEleveML) = Nothing
        If elevesRepo IsNot Nothing AndAlso notesRepo IsNot Nothing Then
            jeuReel = GenerateurDonnees.ExtraireDonneesReelles(elevesRepo, notesRepo)
        End If

        If jeuReel IsNot Nothing AndAlso jeuReel.Count >= 200 Then
            jeuDonnees = jeuReel
        Else
            ' Pas encore assez de données réelles : on utilise un jeu synthétique
            ' réaliste, éventuellement enrichi des quelques vraies données disponibles.
            jeuDonnees = GenerateurDonnees.GenererJeuSynthetique()
            If jeuReel IsNot Nothing Then jeuDonnees.AddRange(jeuReel)
        End If

        DernierResultat = Entraineur.Entrainer(jeuDonnees)
        MoteurRegression = Entraineur.Contexte.Model.CreatePredictionEngine(Of DonneesEleveML, PredictionNoteFinale)(DernierResultat.ModeleRegression)
        MoteurClassification = Entraineur.Contexte.Model.CreatePredictionEngine(Of DonneesEleveML, PredictionRisque)(DernierResultat.ModeleClassification)

        Return Entraineur.FormatterMetriques(DernierResultat) &
               vbCrLf & $"(Entraîné sur {jeuDonnees.Count} exemples{If(jeuReel IsNot Nothing AndAlso jeuReel.Count > 0, $", dont {jeuReel.Count} réels", "")})"
    End Function

    Public Function PredireNoteFinale(entree As DonneesEleveML) As Single
        VerifierEntraine()
        Return MoteurRegression.Predict(entree).NoteFinalePredite
    End Function

    Public Function PredireRisque(entree As DonneesEleveML) As PredictionRisque
        VerifierEntraine()
        Return MoteurClassification.Predict(entree)
    End Function

    Private Sub VerifierEntraine()
        If Not EstEntraine Then
            Throw New InvalidOperationException("Les modèles ne sont pas encore entraînés. Appelez EntrainerLesModeles() d'abord.")
        End If
    End Sub

End Class
