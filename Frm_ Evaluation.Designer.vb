<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm__Evaluation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GB_Noveau = New System.Windows.Forms.GroupBox()
        Me.GB_Evaluation = New System.Windows.Forms.GroupBox()
        Me.BTN_enreg = New System.Windows.Forms.Button()
        Me.BTN_Annuler = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Fermer = New System.Windows.Forms.Button()
        Me.BTN_Nouveau = New System.Windows.Forms.Button()
        Me.DGV_Evaluation = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRemarque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GB_Noveau.SuspendLayout()
        Me.GB_Evaluation.SuspendLayout()
        CType(Me.DGV_Evaluation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Noveau
        '
        Me.GB_Noveau.Controls.Add(Me.GB_Evaluation)
        Me.GB_Noveau.Controls.Add(Me.BTN_Fermer)
        Me.GB_Noveau.Controls.Add(Me.BTN_Nouveau)
        Me.GB_Noveau.Controls.Add(Me.DGV_Evaluation)
        Me.GB_Noveau.Location = New System.Drawing.Point(12, 12)
        Me.GB_Noveau.Name = "GB_Noveau"
        Me.GB_Noveau.Size = New System.Drawing.Size(733, 423)
        Me.GB_Noveau.TabIndex = 0
        Me.GB_Noveau.TabStop = False
        '
        'GB_Evaluation
        '
        Me.GB_Evaluation.Controls.Add(Me.TextBox2)
        Me.GB_Evaluation.Controls.Add(Me.BTN_enreg)
        Me.GB_Evaluation.Controls.Add(Me.BTN_Annuler)
        Me.GB_Evaluation.Controls.Add(Me.DateTimePicker2)
        Me.GB_Evaluation.Controls.Add(Me.DateTimePicker1)
        Me.GB_Evaluation.Controls.Add(Me.TextBox1)
        Me.GB_Evaluation.Controls.Add(Me.Label4)
        Me.GB_Evaluation.Controls.Add(Me.Label3)
        Me.GB_Evaluation.Controls.Add(Me.Label2)
        Me.GB_Evaluation.Controls.Add(Me.Label1)
        Me.GB_Evaluation.Location = New System.Drawing.Point(81, 16)
        Me.GB_Evaluation.Name = "GB_Evaluation"
        Me.GB_Evaluation.Size = New System.Drawing.Size(473, 407)
        Me.GB_Evaluation.TabIndex = 12
        Me.GB_Evaluation.TabStop = False
        '
        'BTN_enreg
        '
        Me.BTN_enreg.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_enreg.Location = New System.Drawing.Point(201, 323)
        Me.BTN_enreg.Name = "BTN_enreg"
        Me.BTN_enreg.Size = New System.Drawing.Size(100, 36)
        Me.BTN_enreg.TabIndex = 14
        Me.BTN_enreg.Text = "Enregistrer"
        Me.BTN_enreg.UseVisualStyleBackColor = True
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Annuler.Location = New System.Drawing.Point(333, 323)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(104, 36)
        Me.BTN_Annuler.TabIndex = 13
        Me.BTN_Annuler.Text = "Annuler"
        Me.BTN_Annuler.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(212, 133)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 23)
        Me.DateTimePicker2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(212, 94)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(56, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Remarque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(56, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date de correction:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(56, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(56, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Evaluation:"
        '
        'BTN_Fermer
        '
        Me.BTN_Fermer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Fermer.Location = New System.Drawing.Point(634, 354)
        Me.BTN_Fermer.Name = "BTN_Fermer"
        Me.BTN_Fermer.Size = New System.Drawing.Size(93, 36)
        Me.BTN_Fermer.TabIndex = 11
        Me.BTN_Fermer.Text = "Fermer"
        Me.BTN_Fermer.UseVisualStyleBackColor = True
        '
        'BTN_Nouveau
        '
        Me.BTN_Nouveau.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Nouveau.Location = New System.Drawing.Point(634, 142)
        Me.BTN_Nouveau.Name = "BTN_Nouveau"
        Me.BTN_Nouveau.Size = New System.Drawing.Size(93, 36)
        Me.BTN_Nouveau.TabIndex = 10
        Me.BTN_Nouveau.Text = "Nouveau"
        Me.BTN_Nouveau.UseVisualStyleBackColor = True
        '
        'DGV_Evaluation
        '
        Me.DGV_Evaluation.AllowUserToAddRows = False
        Me.DGV_Evaluation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_Evaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Evaluation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DGV_Evaluation.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_Evaluation.Location = New System.Drawing.Point(23, 16)
        Me.DGV_Evaluation.Name = "DGV_Evaluation"
        Me.DGV_Evaluation.RowTemplate.Height = 25
        Me.DGV_Evaluation.Size = New System.Drawing.Size(575, 365)
        Me.DGV_Evaluation.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° Evaluation"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date de correction"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Remarque"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'Coldate
        '
        Me.Coldate.HeaderText = "Date"
        Me.Coldate.Name = "Coldate"
        '
        'ColRemarque
        '
        Me.ColRemarque.HeaderText = "Remarque"
        Me.ColRemarque.Name = "ColRemarque"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date de correction"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(156, 203)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(311, 84)
        Me.TextBox2.TabIndex = 15
        '
        'Frm__Evaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.GB_Noveau)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm__Evaluation"
        Me.Text = "Frm__Evaluation"
        Me.GB_Noveau.ResumeLayout(False)
        Me.GB_Evaluation.ResumeLayout(False)
        Me.GB_Evaluation.PerformLayout()
        CType(Me.DGV_Evaluation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Noveau As GroupBox
    Friend WithEvents DGV_Evaluation As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Coldate As DataGridViewTextBoxColumn
    Friend WithEvents ColRemarque As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BTN_Nouveau As Button
    Friend WithEvents GB_Evaluation As GroupBox
    Friend WithEvents BTN_Fermer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTN_Annuler As Button
    Friend WithEvents BTN_enreg As Button
    Friend WithEvents TextBox2 As TextBox
End Class
