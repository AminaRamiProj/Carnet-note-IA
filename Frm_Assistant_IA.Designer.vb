<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Assistant_IA
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()

        Me.TabAppreciation = New System.Windows.Forms.TabPage()
        Me.LblNomEleve = New System.Windows.Forms.Label()
        Me.TxtNomEleve = New System.Windows.Forms.TextBox()
        Me.LblMatiere = New System.Windows.Forms.Label()
        Me.TxtMatiere = New System.Windows.Forms.TextBox()
        Me.LblNotes = New System.Windows.Forms.Label()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.BtnGenererAppreciation = New System.Windows.Forms.Button()
        Me.LblResultatAppreciation = New System.Windows.Forms.Label()
        Me.RtbAppreciation = New System.Windows.Forms.RichTextBox()

        Me.TabAnalyse = New System.Windows.Forms.TabPage()
        Me.LblDonneesClasse = New System.Windows.Forms.Label()
        Me.TxtDonneesClasse = New System.Windows.Forms.TextBox()
        Me.BtnAnalyserClasse = New System.Windows.Forms.Button()
        Me.RtbAnalyse = New System.Windows.Forms.RichTextBox()

        Me.TabChat = New System.Windows.Forms.TabPage()
        Me.RtbConversation = New System.Windows.Forms.RichTextBox()
        Me.TxtQuestion = New System.Windows.Forms.TextBox()
        Me.BtnEnvoyerQuestion = New System.Windows.Forms.Button()

        Me.LblStatutIA = New System.Windows.Forms.Label()

        Me.TabControl1.SuspendLayout()
        Me.TabAppreciation.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChat.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblStatutIA
        '
        Me.LblStatutIA.AutoSize = True
        Me.LblStatutIA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblStatutIA.Location = New System.Drawing.Point(12, 9)
        Me.LblStatutIA.Name = "LblStatutIA"
        Me.LblStatutIA.Size = New System.Drawing.Size(120, 15)
        Me.LblStatutIA.TabIndex = 0
        Me.LblStatutIA.Text = "Statut du module IA"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabAppreciation)
        Me.TabControl1.Controls.Add(Me.TabAnalyse)
        Me.TabControl1.Controls.Add(Me.TabChat)
        Me.TabControl1.Location = New System.Drawing.Point(12, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 460)
        Me.TabControl1.TabIndex = 1
        '
        'TabAppreciation
        '
        Me.TabAppreciation.Controls.Add(Me.LblNomEleve)
        Me.TabAppreciation.Controls.Add(Me.TxtNomEleve)
        Me.TabAppreciation.Controls.Add(Me.LblMatiere)
        Me.TabAppreciation.Controls.Add(Me.TxtMatiere)
        Me.TabAppreciation.Controls.Add(Me.LblNotes)
        Me.TabAppreciation.Controls.Add(Me.TxtNotes)
        Me.TabAppreciation.Controls.Add(Me.BtnGenererAppreciation)
        Me.TabAppreciation.Controls.Add(Me.LblResultatAppreciation)
        Me.TabAppreciation.Controls.Add(Me.RtbAppreciation)
        Me.TabAppreciation.Location = New System.Drawing.Point(4, 24)
        Me.TabAppreciation.Name = "TabAppreciation"
        Me.TabAppreciation.Padding = New System.Windows.Forms.Padding(12)
        Me.TabAppreciation.Size = New System.Drawing.Size(672, 432)
        Me.TabAppreciation.TabIndex = 0
        Me.TabAppreciation.Text = "Appréciations automatiques"
        Me.TabAppreciation.UseVisualStyleBackColor = True
        '
        'LblNomEleve
        '
        Me.LblNomEleve.AutoSize = True
        Me.LblNomEleve.Location = New System.Drawing.Point(15, 20)
        Me.LblNomEleve.Name = "LblNomEleve"
        Me.LblNomEleve.Size = New System.Drawing.Size(90, 15)
        Me.LblNomEleve.TabIndex = 0
        Me.LblNomEleve.Text = "Nom de l'élève :"
        '
        'TxtNomEleve
        '
        Me.TxtNomEleve.Location = New System.Drawing.Point(150, 17)
        Me.TxtNomEleve.Name = "TxtNomEleve"
        Me.TxtNomEleve.Size = New System.Drawing.Size(250, 23)
        Me.TxtNomEleve.TabIndex = 1
        '
        'LblMatiere
        '
        Me.LblMatiere.AutoSize = True
        Me.LblMatiere.Location = New System.Drawing.Point(15, 55)
        Me.LblMatiere.Name = "LblMatiere"
        Me.LblMatiere.Size = New System.Drawing.Size(55, 15)
        Me.LblMatiere.TabIndex = 2
        Me.LblMatiere.Text = "Matière :"
        '
        'TxtMatiere
        '
        Me.TxtMatiere.Location = New System.Drawing.Point(150, 52)
        Me.TxtMatiere.Name = "TxtMatiere"
        Me.TxtMatiere.Size = New System.Drawing.Size(250, 23)
        Me.TxtMatiere.TabIndex = 3
        '
        'LblNotes
        '
        Me.LblNotes.AutoSize = True
        Me.LblNotes.Location = New System.Drawing.Point(15, 90)
        Me.LblNotes.Name = "LblNotes"
        Me.LblNotes.Size = New System.Drawing.Size(210, 15)
        Me.LblNotes.TabIndex = 4
        Me.LblNotes.Text = "Notes (séparées par des virgules) :"
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(230, 87)
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(170, 23)
        Me.TxtNotes.TabIndex = 5
        Me.TxtNotes.PlaceholderText = "ex : 12,15.5,9"
        '
        'BtnGenererAppreciation
        '
        Me.BtnGenererAppreciation.Location = New System.Drawing.Point(15, 125)
        Me.BtnGenererAppreciation.Name = "BtnGenererAppreciation"
        Me.BtnGenererAppreciation.Size = New System.Drawing.Size(260, 32)
        Me.BtnGenererAppreciation.TabIndex = 6
        Me.BtnGenererAppreciation.Text = "Générer l'appréciation avec l'IA"
        Me.BtnGenererAppreciation.UseVisualStyleBackColor = True
        '
        'LblResultatAppreciation
        '
        Me.LblResultatAppreciation.AutoSize = True
        Me.LblResultatAppreciation.Location = New System.Drawing.Point(15, 170)
        Me.LblResultatAppreciation.Name = "LblResultatAppreciation"
        Me.LblResultatAppreciation.Size = New System.Drawing.Size(120, 15)
        Me.LblResultatAppreciation.TabIndex = 7
        Me.LblResultatAppreciation.Text = "Appréciation générée :"
        '
        'RtbAppreciation
        '
        Me.RtbAppreciation.Location = New System.Drawing.Point(15, 190)
        Me.RtbAppreciation.Name = "RtbAppreciation"
        Me.RtbAppreciation.ReadOnly = True
        Me.RtbAppreciation.Size = New System.Drawing.Size(640, 220)
        Me.RtbAppreciation.TabIndex = 8
        Me.RtbAppreciation.Text = ""
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Controls.Add(Me.LblDonneesClasse)
        Me.TabAnalyse.Controls.Add(Me.TxtDonneesClasse)
        Me.TabAnalyse.Controls.Add(Me.BtnAnalyserClasse)
        Me.TabAnalyse.Controls.Add(Me.RtbAnalyse)
        Me.TabAnalyse.Location = New System.Drawing.Point(4, 24)
        Me.TabAnalyse.Name = "TabAnalyse"
        Me.TabAnalyse.Padding = New System.Windows.Forms.Padding(12)
        Me.TabAnalyse.Size = New System.Drawing.Size(672, 432)
        Me.TabAnalyse.TabIndex = 1
        Me.TabAnalyse.Text = "Analyse de classe"
        Me.TabAnalyse.UseVisualStyleBackColor = True
        '
        'LblDonneesClasse
        '
        Me.LblDonneesClasse.AutoSize = True
        Me.LblDonneesClasse.Location = New System.Drawing.Point(15, 15)
        Me.LblDonneesClasse.Name = "LblDonneesClasse"
        Me.LblDonneesClasse.Size = New System.Drawing.Size(430, 15)
        Me.LblDonneesClasse.TabIndex = 0
        Me.LblDonneesClasse.Text = "Élèves de la classe — une ligne par élève, format : Nom;note1,note2,note3"
        '
        'TxtDonneesClasse
        '
        Me.TxtDonneesClasse.Location = New System.Drawing.Point(15, 35)
        Me.TxtDonneesClasse.Multiline = True
        Me.TxtDonneesClasse.Name = "TxtDonneesClasse"
        Me.TxtDonneesClasse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDonneesClasse.Size = New System.Drawing.Size(640, 110)
        Me.TxtDonneesClasse.TabIndex = 1
        Me.TxtDonneesClasse.PlaceholderText = "Amina Rami;14,16,12" & vbCrLf & "Youssef Alaoui;8,7,9.5"
        '
        'BtnAnalyserClasse
        '
        Me.BtnAnalyserClasse.Location = New System.Drawing.Point(15, 155)
        Me.BtnAnalyserClasse.Name = "BtnAnalyserClasse"
        Me.BtnAnalyserClasse.Size = New System.Drawing.Size(260, 32)
        Me.BtnAnalyserClasse.TabIndex = 2
        Me.BtnAnalyserClasse.Text = "Analyser la classe avec l'IA"
        Me.BtnAnalyserClasse.UseVisualStyleBackColor = True
        '
        'RtbAnalyse
        '
        Me.RtbAnalyse.Location = New System.Drawing.Point(15, 195)
        Me.RtbAnalyse.Name = "RtbAnalyse"
        Me.RtbAnalyse.ReadOnly = True
        Me.RtbAnalyse.Size = New System.Drawing.Size(640, 215)
        Me.RtbAnalyse.TabIndex = 3
        Me.RtbAnalyse.Text = ""
        '
        'TabChat
        '
        Me.TabChat.Controls.Add(Me.RtbConversation)
        Me.TabChat.Controls.Add(Me.TxtQuestion)
        Me.TabChat.Controls.Add(Me.BtnEnvoyerQuestion)
        Me.TabChat.Location = New System.Drawing.Point(4, 24)
        Me.TabChat.Name = "TabChat"
        Me.TabChat.Padding = New System.Windows.Forms.Padding(12)
        Me.TabChat.Size = New System.Drawing.Size(672, 432)
        Me.TabChat.TabIndex = 2
        Me.TabChat.Text = "Assistant (Chat)"
        Me.TabChat.UseVisualStyleBackColor = True
        '
        'RtbConversation
        '
        Me.RtbConversation.Location = New System.Drawing.Point(15, 15)
        Me.RtbConversation.Name = "RtbConversation"
        Me.RtbConversation.ReadOnly = True
        Me.RtbConversation.Size = New System.Drawing.Size(640, 355)
        Me.RtbConversation.TabIndex = 0
        Me.RtbConversation.Text = ""
        '
        'TxtQuestion
        '
        Me.TxtQuestion.Location = New System.Drawing.Point(15, 380)
        Me.TxtQuestion.Name = "TxtQuestion"
        Me.TxtQuestion.Size = New System.Drawing.Size(530, 23)
        Me.TxtQuestion.TabIndex = 1
        Me.TxtQuestion.PlaceholderText = "Ex : quels élèves ont une moyenne inférieure à 10 ?"
        '
        'BtnEnvoyerQuestion
        '
        Me.BtnEnvoyerQuestion.Location = New System.Drawing.Point(555, 379)
        Me.BtnEnvoyerQuestion.Name = "BtnEnvoyerQuestion"
        Me.BtnEnvoyerQuestion.Size = New System.Drawing.Size(100, 25)
        Me.BtnEnvoyerQuestion.TabIndex = 2
        Me.BtnEnvoyerQuestion.Text = "Envoyer"
        Me.BtnEnvoyerQuestion.UseVisualStyleBackColor = True
        '
        'Frm_Assistant_IA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 504)
        Me.Controls.Add(Me.LblStatutIA)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_Assistant_IA"
        Me.Text = "Assistant IA — Carnet de notes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TabControl1.ResumeLayout(False)
        Me.TabAppreciation.ResumeLayout(False)
        Me.TabAppreciation.PerformLayout()
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabAnalyse.PerformLayout()
        Me.TabChat.ResumeLayout(False)
        Me.TabChat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LblStatutIA As System.Windows.Forms.Label

    Friend WithEvents TabAppreciation As System.Windows.Forms.TabPage
    Friend WithEvents LblNomEleve As System.Windows.Forms.Label
    Friend WithEvents TxtNomEleve As System.Windows.Forms.TextBox
    Friend WithEvents LblMatiere As System.Windows.Forms.Label
    Friend WithEvents TxtMatiere As System.Windows.Forms.TextBox
    Friend WithEvents LblNotes As System.Windows.Forms.Label
    Friend WithEvents TxtNotes As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenererAppreciation As System.Windows.Forms.Button
    Friend WithEvents LblResultatAppreciation As System.Windows.Forms.Label
    Friend WithEvents RtbAppreciation As System.Windows.Forms.RichTextBox

    Friend WithEvents TabAnalyse As System.Windows.Forms.TabPage
    Friend WithEvents LblDonneesClasse As System.Windows.Forms.Label
    Friend WithEvents TxtDonneesClasse As System.Windows.Forms.TextBox
    Friend WithEvents BtnAnalyserClasse As System.Windows.Forms.Button
    Friend WithEvents RtbAnalyse As System.Windows.Forms.RichTextBox

    Friend WithEvents TabChat As System.Windows.Forms.TabPage
    Friend WithEvents RtbConversation As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents BtnEnvoyerQuestion As System.Windows.Forms.Button

End Class
