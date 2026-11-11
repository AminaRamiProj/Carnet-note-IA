Imports System.Linq

Public Class Frm_Assistant_IA

    Private ReadOnly IA As New IAService()
    Private ReadOnly HistoriqueChat As New List(Of (Role As String, Texte As String))

    Private Sub Frm_Assistant_IA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IA.EstConfigure() Then
            LblStatutIA.Text = "⚠ Clé API non configurée — voir IAConfig.vb"
            LblStatutIA.ForeColor = Color.Firebrick
        Else
            LblStatutIA.Text = "✓ Module IA prêt"
            LblStatutIA.ForeColor = Color.ForestGreen
        End If
    End Sub

    ' ------------------------------------------------------------------
    ' Onglet 1 : Appréciation automatique
    ' ------------------------------------------------------------------
    Private Async Sub BtnGenererAppreciation_Click(sender As Object, e As EventArgs) Handles BtnGenererAppreciation.Click
        If String.IsNullOrWhiteSpace(TxtNomEleve.Text) OrElse String.IsNullOrWhiteSpace(TxtNotes.Text) Then
            MsgBox("Veuillez renseigner au minimum le nom de l'élève et ses notes.", vbExclamation)
            Return
        End If

        Dim notes As List(Of Double) = ConvertirNotes(TxtNotes.Text)
        If notes.Count = 0 Then
            MsgBox("Le format des notes est invalide. Exemple attendu : 12,15.5,9", vbExclamation)
            Return
        End If

        BtnGenererAppreciation.Enabled = False
        RtbAppreciation.Text = "Génération en cours..."
        Try
            Dim matiere As String = If(String.IsNullOrWhiteSpace(TxtMatiere.Text), "Général", TxtMatiere.Text)
            Dim resultat As String = Await IA.GenererAppreciationAsync(TxtNomEleve.Text, notes, matiere)
            RtbAppreciation.Text = resultat
        Finally
            BtnGenererAppreciation.Enabled = True
        End Try
    End Sub

    ' ------------------------------------------------------------------
    ' Onglet 2 : Analyse de classe
    ' ------------------------------------------------------------------
    Private Async Sub BtnAnalyserClasse_Click(sender As Object, e As EventArgs) Handles BtnAnalyserClasse.Click
        Dim eleves As List(Of ElevePourAnalyse) = LireDonneesClasse()
        If eleves.Count = 0 Then
            MsgBox("Veuillez saisir au moins un élève au format :" & vbCrLf & "Nom;note1,note2,note3", vbExclamation)
            Return
        End If

        BtnAnalyserClasse.Enabled = False
        RtbAnalyse.Text = "Analyse en cours..."
        Try
            Dim resultat As String = Await IA.AnalyserClasseAsync(eleves)
            RtbAnalyse.Text = resultat
        Finally
            BtnAnalyserClasse.Enabled = True
        End Try
    End Sub

    ' ------------------------------------------------------------------
    ' Onglet 3 : Assistant conversationnel
    ' ------------------------------------------------------------------
    Private Async Sub BtnEnvoyerQuestion_Click(sender As Object, e As EventArgs) Handles BtnEnvoyerQuestion.Click
        Await EnvoyerQuestionAsync()
    End Sub

    Private Async Sub TxtQuestion_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQuestion.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Await EnvoyerQuestionAsync()
        End If
    End Sub

    Private Async Function EnvoyerQuestionAsync() As Task
        Dim question As String = TxtQuestion.Text.Trim()
        If String.IsNullOrWhiteSpace(question) Then Return

        Dim eleves As List(Of ElevePourAnalyse) = LireDonneesClasse()

        AjouterAuChat("Vous", question)
        TxtQuestion.Clear()
        BtnEnvoyerQuestion.Enabled = False
        Try
            Dim reponse As String = Await IA.PoserQuestionAsync(question, eleves, HistoriqueChat)
            AjouterAuChat("Assistant", reponse)
        Finally
            BtnEnvoyerQuestion.Enabled = True
        End Try
    End Function

    Private Sub AjouterAuChat(role As String, texte As String)
        HistoriqueChat.Add((role, texte))
        RtbConversation.AppendText($"{role} : {texte}{Environment.NewLine}{Environment.NewLine}")
        RtbConversation.SelectionStart = RtbConversation.Text.Length
        RtbConversation.ScrollToCaret()
    End Sub

    ' ------------------------------------------------------------------
    ' Utilitaires partagés
    ' ------------------------------------------------------------------

    ''' <summary>
    ''' Convertit un texte "12,15.5,9" en liste de doubles. Ignore les entrées invalides.
    ''' </summary>
    Private Function ConvertirNotes(texte As String) As List(Of Double)
        Dim resultat As New List(Of Double)
        For Each morceau In texte.Split(","c)
            Dim valeur As Double
            If Double.TryParse(morceau.Trim(), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, valeur) Then
                resultat.Add(valeur)
            End If
        Next
        Return resultat
    End Function

    ''' <summary>
    ''' Lit la zone de texte "Nom;note1,note2,note3" (une ligne par élève) utilisée
    ''' pour l'onglet Analyse et l'onglet Chat.
    ''' NOTE D'INTÉGRATION : dans votre version finale, remplacez cette lecture par
    ''' une lecture directe de vos données réelles (fichier eleve.RM / notes.RM ou
    ''' base de données), afin de ne pas ressaisir les élèves manuellement.
    ''' </summary>
    Private Function LireDonneesClasse() As List(Of ElevePourAnalyse)
        Dim liste As New List(Of ElevePourAnalyse)
        For Each ligne In TxtDonneesClasse.Lines
            If String.IsNullOrWhiteSpace(ligne) Then Continue For
            Dim parties = ligne.Split(";"c)
            If parties.Length <> 2 Then Continue For

            Dim eleve As New ElevePourAnalyse With {.Nom = parties(0).Trim()}
            eleve.Notes = ConvertirNotes(parties(1))
            If eleve.Notes.Count > 0 Then liste.Add(eleve)
        Next
        Return liste
    End Function

End Class
