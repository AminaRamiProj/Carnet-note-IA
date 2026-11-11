<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_controle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GB_Nouveau = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOpservation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_Note = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Radio_justifier = New System.Windows.Forms.RadioButton()
        Me.Radio_Nojustifier = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BTN_Annuler = New System.Windows.Forms.Button()
        Me.BTN_enreg = New System.Windows.Forms.Button()
        Me.BTN_Fermer = New System.Windows.Forms.Button()
        Me.BTN_Nouveau = New System.Windows.Forms.Button()
        Me.GB_Nouveau.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Note.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Nouveau
        '
        Me.GB_Nouveau.Controls.Add(Me.BTN_Nouveau)
        Me.GB_Nouveau.Controls.Add(Me.BTN_Fermer)
        Me.GB_Nouveau.Controls.Add(Me.GB_Note)
        Me.GB_Nouveau.Controls.Add(Me.DataGridView1)
        Me.GB_Nouveau.Location = New System.Drawing.Point(27, 29)
        Me.GB_Nouveau.Name = "GB_Nouveau"
        Me.GB_Nouveau.Size = New System.Drawing.Size(695, 399)
        Me.GB_Nouveau.TabIndex = 0
        Me.GB_Nouveau.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNote, Me.DataGridViewTextBoxColumn1, Me.ColOpservation})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(496, 381)
        Me.DataGridView1.TabIndex = 0
        '
        'ColNote
        '
        Me.ColNote.HeaderText = "Note"
        Me.ColNote.Name = "ColNote"
        Me.ColNote.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Evaluation"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'ColOpservation
        '
        Me.ColOpservation.HeaderText = "Opservation"
        Me.ColOpservation.Name = "ColOpservation"
        Me.ColOpservation.Width = 150
        '
        'GB_Note
        '
        Me.GB_Note.Controls.Add(Me.BTN_enreg)
        Me.GB_Note.Controls.Add(Me.BTN_Annuler)
        Me.GB_Note.Controls.Add(Me.TextBox2)
        Me.GB_Note.Controls.Add(Me.Label4)
        Me.GB_Note.Controls.Add(Me.Radio_Nojustifier)
        Me.GB_Note.Controls.Add(Me.Radio_justifier)
        Me.GB_Note.Controls.Add(Me.TextBox3)
        Me.GB_Note.Controls.Add(Me.TextBox1)
        Me.GB_Note.Controls.Add(Me.Label3)
        Me.GB_Note.Controls.Add(Me.Label2)
        Me.GB_Note.Controls.Add(Me.Label1)
        Me.GB_Note.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GB_Note.Location = New System.Drawing.Point(22, -17)
        Me.GB_Note.Name = "GB_Note"
        Me.GB_Note.Size = New System.Drawing.Size(535, 363)
        Me.GB_Note.TabIndex = 1
        Me.GB_Note.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(66, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Evaluation:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(66, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Note:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(66, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Opservation:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(182, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 28)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(182, 131)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(289, 28)
        Me.TextBox3.TabIndex = 5
        '
        'Radio_justifier
        '
        Me.Radio_justifier.AutoSize = True
        Me.Radio_justifier.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Radio_justifier.Location = New System.Drawing.Point(185, 180)
        Me.Radio_justifier.Name = "Radio_justifier"
        Me.Radio_justifier.Size = New System.Drawing.Size(134, 21)
        Me.Radio_justifier.TabIndex = 8
        Me.Radio_justifier.TabStop = True
        Me.Radio_justifier.Text = "absent justifier"
        Me.Radio_justifier.UseVisualStyleBackColor = True
        '
        'Radio_Nojustifier
        '
        Me.Radio_Nojustifier.AutoSize = True
        Me.Radio_Nojustifier.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Radio_Nojustifier.Location = New System.Drawing.Point(185, 220)
        Me.Radio_Nojustifier.Name = "Radio_Nojustifier"
        Me.Radio_Nojustifier.Size = New System.Drawing.Size(169, 21)
        Me.Radio_Nojustifier.TabIndex = 9
        Me.Radio_Nojustifier.TabStop = True
        Me.Radio_Nojustifier.Text = "absent nom justifier"
        Me.Radio_Nojustifier.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(66, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "N° élève:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(182, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 28)
        Me.TextBox2.TabIndex = 11
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Location = New System.Drawing.Point(401, 309)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(104, 36)
        Me.BTN_Annuler.TabIndex = 12
        Me.BTN_Annuler.Text = "Annuler"
        Me.BTN_Annuler.UseVisualStyleBackColor = True
        '
        'BTN_enreg
        '
        Me.BTN_enreg.Location = New System.Drawing.Point(277, 309)
        Me.BTN_enreg.Name = "BTN_enreg"
        Me.BTN_enreg.Size = New System.Drawing.Size(100, 36)
        Me.BTN_enreg.TabIndex = 13
        Me.BTN_enreg.Text = "Enregistrer"
        Me.BTN_enreg.UseVisualStyleBackColor = True
        '
        'BTN_Fermer
        '
        Me.BTN_Fermer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Fermer.Location = New System.Drawing.Point(565, 347)
        Me.BTN_Fermer.Name = "BTN_Fermer"
        Me.BTN_Fermer.Size = New System.Drawing.Size(93, 36)
        Me.BTN_Fermer.TabIndex = 8
        Me.BTN_Fermer.Text = "Fermer"
        Me.BTN_Fermer.UseVisualStyleBackColor = True
        '
        'BTN_Nouveau
        '
        Me.BTN_Nouveau.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Nouveau.Location = New System.Drawing.Point(583, 146)
        Me.BTN_Nouveau.Name = "BTN_Nouveau"
        Me.BTN_Nouveau.Size = New System.Drawing.Size(93, 36)
        Me.BTN_Nouveau.TabIndex = 9
        Me.BTN_Nouveau.Text = "Nouveau"
        Me.BTN_Nouveau.UseVisualStyleBackColor = True
        '
        'Frm_controle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.GB_Nouveau)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_controle"
        Me.Text = "Frm_controle"
        Me.GB_Nouveau.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Note.ResumeLayout(False)
        Me.GB_Note.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Nouveau As GroupBox
    Friend WithEvents GB_Note As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColNote As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ColOpservation As DataGridViewTextBoxColumn
    Friend WithEvents Radio_justifier As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Radio_Nojustifier As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_enreg As Button
    Friend WithEvents BTN_Annuler As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BTN_Fermer As Button
    Friend WithEvents BTN_Nouveau As Button
End Class
