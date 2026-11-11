<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ML_Avance
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

        Me.TabPredictions = New System.Windows.Forms.TabPage()
        Me.BtnEntrainer = New System.Windows.Forms.Button()
        Me.LblStatutML = New System.Windows.Forms.Label()
        Me.LblN1 = New System.Windows.Forms.Label()
        Me.TxtN1 = New System.Windows.Forms.TextBox()
        Me.LblN2 = New System.Windows.Forms.Label()
        Me.TxtN2 = New System.Windows.Forms.TextBox()
        Me.LblN3 = New System.Windows.Forms.Label()
        Me.TxtN3 = New System.Windows.Forms.TextBox()
        Me.LblAbsences = New System.Windows.Forms.Label()
        Me.TxtAbsences = New System.Windows.Forms.TextBox()
        Me.LblMoyennePrecedente = New System.Windows.Forms.Label()
        Me.TxtMoyennePrecedente = New System.Windows.Forms.TextBox()
        Me.BtnPredireNote = New System.Windows.Forms.Button()
        Me.BtnPredireRisque = New System.Windows.Forms.Button()
        Me.LblResultatPrediction = New System.Windows.Forms.Label()

        Me.TabStatistiques = New System.Windows.Forms.TabPage()
        Me.LblDonneesClasseStats = New System.Windows.Forms.Label()
        Me.TxtDonneesClasseStats = New System.Windows.Forms.TextBox()
        Me.BtnAnalyserClusters = New System.Windows.Forms.Button()
        Me.RtbClusters = New System.Windows.Forms.RichTextBox()

        Me.TabControl1.SuspendLayout()
        Me.TabPredictions.SuspendLayout()
        Me.TabStatistiques.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPredictions)
        Me.TabControl1.Controls.Add(Me.TabStatistiques)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 480)
        Me.TabControl1.TabIndex = 0
        '
        'TabPredictions
        '
        Me.TabPredictions.Controls.Add(Me.BtnEntrainer)
        Me.TabPredictions.Controls.Add(Me.LblStatutML)
        Me.TabPredictions.Controls.Add(Me.LblN1)
        Me.TabPredictions.Controls.Add(Me.TxtN1)
        Me.TabPredictions.Controls.Add(Me.LblN2)
        Me.TabPredictions.Controls.Add(Me.TxtN2)
        Me.TabPredictions.Controls.Add(Me.LblN3)
        Me.TabPredictions.Controls.Add(Me.TxtN3)
        Me.TabPredictions.Controls.Add(Me.LblAbsences)
        Me.TabPredictions.Controls.Add(Me.TxtAbsences)
        Me.TabPredictions.Controls.Add(Me.LblMoyennePrecedente)
        Me.TabPredictions.Controls.Add(Me.TxtMoyennePrecedente)
        Me.TabPredictions.Controls.Add(Me.BtnPredireNote)
        Me.TabPredictions.Controls.Add(Me.BtnPredireRisque)
        Me.TabPredictions.Controls.Add(Me.LblResultatPrediction)
        Me.TabPredictions.Location = New System.Drawing.Point(4, 24)
        Me.TabPredictions.Name = "TabPredictions"
        Me.TabPredictions.Padding = New System.Windows.Forms.Padding(12)
        Me.TabPredictions.Size = New System.Drawing.Size(672, 452)
        Me.TabPredictions.TabIndex = 0
        Me.TabPredictions.Text = "Prédictions ML"
        Me.TabPredictions.UseVisualStyleBackColor = True
        '
        'BtnEntrainer
        '
        Me.BtnEntrainer.Location = New System.Drawing.Point(15, 15)
        Me.BtnEntrainer.Name = "BtnEntrainer"
        Me.BtnEntrainer.Size = New System.Drawing.Size(260, 32)
        Me.BtnEntrainer.TabIndex = 0
        Me.BtnEntrainer.Text = "Entraîner les modèles"
        Me.BtnEntrainer.UseVisualStyleBackColor = True
        '
        'LblStatutML
        '
        Me.LblStatutML.Location = New System.Drawing.Point(15, 55)
        Me.LblStatutML.Name = "LblStatutML"
        Me.LblStatutML.Size = New System.Drawing.Size(640, 55)
        Me.LblStatutML.TabIndex = 1
        Me.LblStatutML.Text = "Modèles non entraînés."
        '
        'LblN1
        '
        Me.LblN1.AutoSize = True
        Me.LblN1.Location = New System.Drawing.Point(15, 125)
        Me.LblN1.Name = "LblN1"
        Me.LblN1.Size = New System.Drawing.Size(120, 15)
        Me.LblN1.TabIndex = 2
        Me.LblN1.Text = "Note 1 (période) :"
        '
        'TxtN1
        '
        Me.TxtN1.Location = New System.Drawing.Point(220, 122)
        Me.TxtN1.Name = "TxtN1"
        Me.TxtN1.Size = New System.Drawing.Size(100, 23)
        Me.TxtN1.TabIndex = 3
        '
        'LblN2
        '
        Me.LblN2.AutoSize = True
        Me.LblN2.Location = New System.Drawing.Point(15, 155)
        Me.LblN2.Name = "LblN2"
        Me.LblN2.Size = New System.Drawing.Size(120, 15)
        Me.LblN2.TabIndex = 4
        Me.LblN2.Text = "Note 2 (période) :"
        '
        'TxtN2
        '
        Me.TxtN2.Location = New System.Drawing.Point(220, 152)
        Me.TxtN2.Name = "TxtN2"
        Me.TxtN2.Size = New System.Drawing.Size(100, 23)
        Me.TxtN2.TabIndex = 5
        '
        'LblN3
        '
        Me.LblN3.AutoSize = True
        Me.LblN3.Location = New System.Drawing.Point(15, 185)
        Me.LblN3.Name = "LblN3"
        Me.LblN3.Size = New System.Drawing.Size(120, 15)
        Me.LblN3.TabIndex = 6
        Me.LblN3.Text = "Note 3 (période) :"
        '
        'TxtN3
        '
        Me.TxtN3.Location = New System.Drawing.Point(220, 182)
        Me.TxtN3.Name = "TxtN3"
        Me.TxtN3.Size = New System.Drawing.Size(100, 23)
        Me.TxtN3.TabIndex = 7
        '
        'LblAbsences
        '
        Me.LblAbsences.AutoSize = True
        Me.LblAbsences.Location = New System.Drawing.Point(15, 215)
        Me.LblAbsences.Name = "LblAbsences"
        Me.LblAbsences.Size = New System.Drawing.Size(120, 15)
        Me.LblAbsences.TabIndex = 8
        Me.LblAbsences.Text = "Nombre d'absences :"
        '
        'TxtAbsences
        '
        Me.TxtAbsences.Location = New System.Drawing.Point(220, 212)
        Me.TxtAbsences.Name = "TxtAbsences"
        Me.TxtAbsences.Size = New System.Drawing.Size(100, 23)
        Me.TxtAbsences.TabIndex = 9
        '
        'LblMoyennePrecedente
        '
        Me.LblMoyennePrecedente.AutoSize = True
        Me.LblMoyennePrecedente.Location = New System.Drawing.Point(15, 245)
        Me.LblMoyennePrecedente.Name = "LblMoyennePrecedente"
        Me.LblMoyennePrecedente.Size = New System.Drawing.Size(150, 15)
        Me.LblMoyennePrecedente.TabIndex = 10
        Me.LblMoyennePrecedente.Text = "Moyenne précédente :"
        '
        'TxtMoyennePrecedente
        '
        Me.TxtMoyennePrecedente.Location = New System.Drawing.Point(220, 242)
        Me.TxtMoyennePrecedente.Name = "TxtMoyennePrecedente"
        Me.TxtMoyennePrecedente.Size = New System.Drawing.Size(100, 23)
        Me.TxtMoyennePrecedente.TabIndex = 11
        '
        'BtnPredireNote
        '
        Me.BtnPredireNote.Enabled = False
        Me.BtnPredireNote.Location = New System.Drawing.Point(15, 285)
        Me.BtnPredireNote.Name = "BtnPredireNote"
        Me.BtnPredireNote.Size = New System.Drawing.Size(260, 32)
        Me.BtnPredireNote.TabIndex = 12
        Me.BtnPredireNote.Text = "Prédire la note finale"
        Me.BtnPredireNote.UseVisualStyleBackColor = True
        '
        'BtnPredireRisque
        '
        Me.BtnPredireRisque.Enabled = False
        Me.BtnPredireRisque.Location = New System.Drawing.Point(285, 285)
        Me.BtnPredireRisque.Name = "BtnPredireRisque"
        Me.BtnPredireRisque.Size = New System.Drawing.Size(260, 32)
        Me.BtnPredireRisque.TabIndex = 13
        Me.BtnPredireRisque.Text = "Évaluer le risque de difficulté"
        Me.BtnPredireRisque.UseVisualStyleBackColor = True
        '
        'LblResultatPrediction
        '
        Me.LblResultatPrediction.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblResultatPrediction.Location = New System.Drawing.Point(15, 330)
        Me.LblResultatPrediction.Name = "LblResultatPrediction"
        Me.LblResultatPrediction.Size = New System.Drawing.Size(640, 60)
        Me.LblResultatPrediction.TabIndex = 14
        '
        'TabStatistiques
        '
        Me.TabStatistiques.Controls.Add(Me.LblDonneesClasseStats)
        Me.TabStatistiques.Controls.Add(Me.TxtDonneesClasseStats)
        Me.TabStatistiques.Controls.Add(Me.BtnAnalyserClusters)
        Me.TabStatistiques.Controls.Add(Me.RtbClusters)
        Me.TabStatistiques.Location = New System.Drawing.Point(4, 24)
        Me.TabStatistiques.Name = "TabStatistiques"
        Me.TabStatistiques.Padding = New System.Windows.Forms.Padding(12)
        Me.TabStatistiques.Size = New System.Drawing.Size(672, 452)
        Me.TabStatistiques.TabIndex = 1
        Me.TabStatistiques.Text = "Statistiques & Clustering"
        Me.TabStatistiques.UseVisualStyleBackColor = True
        '
        'LblDonneesClasseStats
        '
        Me.LblDonneesClasseStats.AutoSize = True
        Me.LblDonneesClasseStats.Location = New System.Drawing.Point(15, 15)
        Me.LblDonneesClasseStats.Name = "LblDonneesClasseStats"
        Me.LblDonneesClasseStats.Size = New System.Drawing.Size(430, 15)
        Me.LblDonneesClasseStats.TabIndex = 0
        Me.LblDonneesClasseStats.Text = "Élèves — une ligne par élève, format : Nom;note1,note2,note3"
        '
        'TxtDonneesClasseStats
        '
        Me.TxtDonneesClasseStats.Location = New System.Drawing.Point(15, 35)
        Me.TxtDonneesClasseStats.Multiline = True
        Me.TxtDonneesClasseStats.Name = "TxtDonneesClasseStats"
        Me.TxtDonneesClasseStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDonneesClasseStats.Size = New System.Drawing.Size(640, 100)
        Me.TxtDonneesClasseStats.TabIndex = 1
        '
        'BtnAnalyserClusters
        '
        Me.BtnAnalyserClusters.Location = New System.Drawing.Point(15, 145)
        Me.BtnAnalyserClusters.Name = "BtnAnalyserClusters"
        Me.BtnAnalyserClusters.Size = New System.Drawing.Size(300, 32)
        Me.BtnAnalyserClusters.TabIndex = 2
        Me.BtnAnalyserClusters.Text = "Regrouper par profil (K-Means)"
        Me.BtnAnalyserClusters.UseVisualStyleBackColor = True
        '
        'RtbClusters
        '
        Me.RtbClusters.Location = New System.Drawing.Point(15, 185)
        Me.RtbClusters.Name = "RtbClusters"
        Me.RtbClusters.ReadOnly = True
        Me.RtbClusters.Size = New System.Drawing.Size(640, 225)
        Me.RtbClusters.TabIndex = 3
        Me.RtbClusters.Text = ""
        '
        'Frm_ML_Avance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 504)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_ML_Avance"
        Me.Text = "Prédictions ML & Statistiques — Carnet de notes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TabControl1.ResumeLayout(False)
        Me.TabPredictions.ResumeLayout(False)
        Me.TabPredictions.PerformLayout()
        Me.TabStatistiques.ResumeLayout(False)
        Me.TabStatistiques.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

    Friend WithEvents TabPredictions As System.Windows.Forms.TabPage
    Friend WithEvents BtnEntrainer As System.Windows.Forms.Button
    Friend WithEvents LblStatutML As System.Windows.Forms.Label
    Friend WithEvents LblN1 As System.Windows.Forms.Label
    Friend WithEvents TxtN1 As System.Windows.Forms.TextBox
    Friend WithEvents LblN2 As System.Windows.Forms.Label
    Friend WithEvents TxtN2 As System.Windows.Forms.TextBox
    Friend WithEvents LblN3 As System.Windows.Forms.Label
    Friend WithEvents TxtN3 As System.Windows.Forms.TextBox
    Friend WithEvents LblAbsences As System.Windows.Forms.Label
    Friend WithEvents TxtAbsences As System.Windows.Forms.TextBox
    Friend WithEvents LblMoyennePrecedente As System.Windows.Forms.Label
    Friend WithEvents TxtMoyennePrecedente As System.Windows.Forms.TextBox
    Friend WithEvents BtnPredireNote As System.Windows.Forms.Button
    Friend WithEvents BtnPredireRisque As System.Windows.Forms.Button
    Friend WithEvents LblResultatPrediction As System.Windows.Forms.Label

    Friend WithEvents TabStatistiques As System.Windows.Forms.TabPage
    Friend WithEvents LblDonneesClasseStats As System.Windows.Forms.Label
    Friend WithEvents TxtDonneesClasseStats As System.Windows.Forms.TextBox
    Friend WithEvents BtnAnalyserClusters As System.Windows.Forms.Button
    Friend WithEvents RtbClusters As System.Windows.Forms.RichTextBox

End Class
