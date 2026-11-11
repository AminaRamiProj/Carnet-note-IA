Imports System.Linq

Public Class Frm_ML_Avance

    Private ReadOnly ML As New ServiceML()
    Private ReadOnly Stats As New StatistiquesService()

    Private Sub Frm_ML_Avance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblStatutML.Text = "Modèles non entraînés — cliquez sur ""Entraîner les modèles""."
    End Sub

    ' ------------------------------------------------------------------
    ' Entraînement
    ' ------------------------------------------------------------------
    Private Sub BtnEntrainer_Click(sender As Object, e As EventArgs) Handles BtnEntrainer.Click
        BtnEntrainer.Enabled = False
        LblStatutML.Text = "Entraînement en cours..."
        Application.DoEvents()
        Try
            ' NOTE : une fois la base de données réelle bien remplie (voir EleveRepository /
            ' NoteRepository), passez ces repositories ici pour entraîner sur vos vraies données :
            ' ML.EntrainerLesModeles(New EleveRepository(), New NoteRepository())
            Dim resume As String = ML.EntrainerLesModeles()
            LblStatutML.Text = "✓ Modèles entraînés" & vbCrLf & resume
            BtnPredireNote.Enabled = True
            BtnPredireRisque.Enabled = True
        Catch ex As Exception
            LblStatutML.Text = "⚠ Erreur pendant l'entraînement : " & ex.Message
        Finally
            BtnEntrainer.Enabled = True
        End Try
    End Sub

    ' ------------------------------------------------------------------
    ' Prédictions
    ' ------------------------------------------------------------------
    Private Function LireEntreePrediction() As DonneesEleveML
        Return New DonneesEleveML With {
            .Note1 = ConvertirEnSingle(TxtN1.Text),
            .Note2 = ConvertirEnSingle(TxtN2.Text),
            .Note3 = ConvertirEnSingle(TxtN3.Text),
            .Absences = ConvertirEnSingle(TxtAbsences.Text),
            .MoyennePrecedente = ConvertirEnSingle(TxtMoyennePrecedente.Text)
        }
    End Function

    Private Function ConvertirEnSingle(texte As String) As Single
        Dim valeur As Single
        Single.TryParse(texte.Trim(), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, valeur)
        Return valeur
    End Function

    Private Sub BtnPredireNote_Click(sender As Object, e As EventArgs) Handles BtnPredireNote.Click
        Try
            Dim resultat = ML.PredireNoteFinale(LireEntreePrediction())
            LblResultatPrediction.Text = $"Note finale prédite : {Math.Round(resultat, 2)}/20"
        Catch ex As Exception
            LblResultatPrediction.Text = "⚠ " & ex.Message
        End Try
    End Sub

    Private Sub BtnPredireRisque_Click(sender As Object, e As EventArgs) Handles BtnPredireRisque.Click
        Try
            Dim resultat = ML.PredireRisque(LireEntreePrediction())
            Dim probabilitePct = Math.Round(resultat.Probability * 100, 1)
            LblResultatPrediction.Text = If(resultat.EnDifficulte,
                $"⚠ Élève potentiellement en difficulté (probabilité : {probabilitePct}%)",
                $"✓ Pas de risque détecté (probabilité de difficulté : {probabilitePct}%)")
        Catch ex As Exception
            LblResultatPrediction.Text = "⚠ " & ex.Message
        End Try
    End Sub

    ' ------------------------------------------------------------------
    ' Clustering / statistiques de classe
    ' ------------------------------------------------------------------
    Private Sub BtnAnalyserClusters_Click(sender As Object, e As EventArgs) Handles BtnAnalyserClusters.Click
        Dim eleves As New Dictionary(Of String, List(Of Double))
        For Each ligne In TxtDonneesClasseStats.Lines
            If String.IsNullOrWhiteSpace(ligne) Then Continue For
            Dim parties = ligne.Split(";"c)
            If parties.Length <> 2 Then Continue For
            Dim notes = parties(1).Split(","c).
                Select(Function(t) CDbl(Val(t.Trim()))).ToList()
            If notes.Count > 0 Then eleves(parties(0).Trim()) = notes
        Next

        If eleves.Count = 0 Then
            MsgBox("Veuillez saisir au moins un élève au format Nom;note1,note2,note3", vbExclamation)
            Return
        End If

        Dim profils = Stats.RegrouperParProfil(eleves, k:=3)
        Dim groupes = profils.GroupBy(Function(p) p.Cluster).OrderByDescending(Function(g) g.Average(Function(p) p.Moyenne))

        Dim rapport As New Text.StringBuilder()
        For Each groupe In groupes
            Dim membres = groupe.ToList()
            rapport.AppendLine($"— {Stats.LibellerCluster(membres)} ({membres.Count} élève(s)) —")
            For Each m In membres.OrderByDescending(Function(p) p.Moyenne)
                rapport.AppendLine($"   {m.Nom} : moyenne {Math.Round(m.Moyenne, 2)}, régularité (écart-type) {Math.Round(m.EcartType, 2)}, tendance {If(m.Tendance >= 0, "+", "")}{Math.Round(m.Tendance, 2)}")
            Next
            rapport.AppendLine()
        Next

        RtbClusters.Text = rapport.ToString()
    End Sub

End Class
