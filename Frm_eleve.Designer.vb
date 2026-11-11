<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_eleve
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_Fermer = New System.Windows.Forms.Button()
        Me.BTN_Nouveau = New System.Windows.Forms.Button()
        Me.GB_liste = New System.Windows.Forms.GroupBox()
        Me.BTN_Enre = New System.Windows.Forms.Button()
        Me.BTN_Annuler = New System.Windows.Forms.Button()
        Me.Radio_Masculin = New System.Windows.Forms.RadioButton()
        Me.Radio_Féminin = New System.Windows.Forms.RadioButton()
        Me.DTPnaissance = New System.Windows.Forms.DateTimePicker()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Txtprenom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_Nouveau = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chec_oui = New System.Windows.Forms.CheckBox()
        Me.Check_Non = New System.Windows.Forms.CheckBox()
        Me.GB_liste.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Nouveau.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_Fermer
        '
        Me.BTN_Fermer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Fermer.Location = New System.Drawing.Point(658, 378)
        Me.BTN_Fermer.Name = "BTN_Fermer"
        Me.BTN_Fermer.Size = New System.Drawing.Size(93, 36)
        Me.BTN_Fermer.TabIndex = 7
        Me.BTN_Fermer.Text = "Fermer"
        Me.BTN_Fermer.UseVisualStyleBackColor = True
        '
        'BTN_Nouveau
        '
        Me.BTN_Nouveau.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Nouveau.Location = New System.Drawing.Point(658, 160)
        Me.BTN_Nouveau.Name = "BTN_Nouveau"
        Me.BTN_Nouveau.Size = New System.Drawing.Size(93, 36)
        Me.BTN_Nouveau.TabIndex = 6
        Me.BTN_Nouveau.Text = "Nouveau"
        Me.BTN_Nouveau.UseVisualStyleBackColor = True
        '
        'GB_liste
        '
        Me.GB_liste.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GB_liste.Controls.Add(Me.Check_Non)
        Me.GB_liste.Controls.Add(Me.Chec_oui)
        Me.GB_liste.Controls.Add(Me.Label7)
        Me.GB_liste.Controls.Add(Me.Label6)
        Me.GB_liste.Controls.Add(Me.ComboBox1)
        Me.GB_liste.Controls.Add(Me.BTN_Enre)
        Me.GB_liste.Controls.Add(Me.BTN_Annuler)
        Me.GB_liste.Controls.Add(Me.Radio_Masculin)
        Me.GB_liste.Controls.Add(Me.Radio_Féminin)
        Me.GB_liste.Controls.Add(Me.DTPnaissance)
        Me.GB_liste.Controls.Add(Me.TxtNom)
        Me.GB_liste.Controls.Add(Me.Txtprenom)
        Me.GB_liste.Controls.Add(Me.Label5)
        Me.GB_liste.Controls.Add(Me.Label4)
        Me.GB_liste.Controls.Add(Me.Label3)
        Me.GB_liste.Controls.Add(Me.Label2)
        Me.GB_liste.Controls.Add(Me.Label1)
        Me.GB_liste.Location = New System.Drawing.Point(21, 22)
        Me.GB_liste.Name = "GB_liste"
        Me.GB_liste.Size = New System.Drawing.Size(594, 414)
        Me.GB_liste.TabIndex = 5
        Me.GB_liste.TabStop = False
        '
        'BTN_Enre
        '
        Me.BTN_Enre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Enre.Location = New System.Drawing.Point(358, 370)
        Me.BTN_Enre.Name = "BTN_Enre"
        Me.BTN_Enre.Size = New System.Drawing.Size(109, 38)
        Me.BTN_Enre.TabIndex = 13
        Me.BTN_Enre.Text = "Enregistrer"
        Me.BTN_Enre.UseVisualStyleBackColor = True
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BTN_Annuler.Location = New System.Drawing.Point(473, 370)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(115, 38)
        Me.BTN_Annuler.TabIndex = 12
        Me.BTN_Annuler.Text = "Annuler"
        Me.BTN_Annuler.UseVisualStyleBackColor = True
        '
        'Radio_Masculin
        '
        Me.Radio_Masculin.AutoSize = True
        Me.Radio_Masculin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Radio_Masculin.Location = New System.Drawing.Point(370, 277)
        Me.Radio_Masculin.Name = "Radio_Masculin"
        Me.Radio_Masculin.Size = New System.Drawing.Size(97, 25)
        Me.Radio_Masculin.TabIndex = 11
        Me.Radio_Masculin.TabStop = True
        Me.Radio_Masculin.Text = "Masculin"
        Me.Radio_Masculin.UseVisualStyleBackColor = True
        '
        'Radio_Féminin
        '
        Me.Radio_Féminin.AutoSize = True
        Me.Radio_Féminin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Radio_Féminin.Location = New System.Drawing.Point(217, 277)
        Me.Radio_Féminin.Name = "Radio_Féminin"
        Me.Radio_Féminin.Size = New System.Drawing.Size(90, 25)
        Me.Radio_Féminin.TabIndex = 10
        Me.Radio_Féminin.TabStop = True
        Me.Radio_Féminin.Text = "Féminin"
        Me.Radio_Féminin.UseVisualStyleBackColor = True
        '
        'DTPnaissance
        '
        Me.DTPnaissance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPnaissance.Location = New System.Drawing.Point(272, 330)
        Me.DTPnaissance.Name = "DTPnaissance"
        Me.DTPnaissance.Size = New System.Drawing.Size(103, 23)
        Me.DTPnaissance.TabIndex = 9
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(217, 180)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(190, 23)
        Me.TxtNom.TabIndex = 8
        '
        'Txtprenom
        '
        Me.Txtprenom.Location = New System.Drawing.Point(217, 232)
        Me.Txtprenom.Name = "Txtprenom"
        Me.Txtprenom.Size = New System.Drawing.Size(190, 23)
        Me.Txtprenom.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(141, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(141, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prenom:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(141, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(141, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date naissance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(141, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N°:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ColNom, Me.ColPrenom, Me.ColSexe, Me.ColDate})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(594, 416)
        Me.DataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'ColNom
        '
        Me.ColNom.FillWeight = 150.0!
        Me.ColNom.HeaderText = "Nom"
        Me.ColNom.Name = "ColNom"
        Me.ColNom.ReadOnly = True
        '
        'ColPrenom
        '
        Me.ColPrenom.HeaderText = "Prenom"
        Me.ColPrenom.Name = "ColPrenom"
        Me.ColPrenom.ReadOnly = True
        '
        'ColSexe
        '
        Me.ColSexe.HeaderText = "Sexe"
        Me.ColSexe.Name = "ColSexe"
        Me.ColSexe.ReadOnly = True
        '
        'ColDate
        '
        Me.ColDate.HeaderText = "Date naissance"
        Me.ColDate.Name = "ColDate"
        Me.ColDate.ReadOnly = True
        '
        'GB_Nouveau
        '
        Me.GB_Nouveau.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GB_Nouveau.Controls.Add(Me.BTN_Nouveau)
        Me.GB_Nouveau.Controls.Add(Me.GB_liste)
        Me.GB_Nouveau.Controls.Add(Me.BTN_Fermer)
        Me.GB_Nouveau.Controls.Add(Me.DataGridView1)
        Me.GB_Nouveau.Location = New System.Drawing.Point(33, 12)
        Me.GB_Nouveau.Name = "GB_Nouveau"
        Me.GB_Nouveau.Size = New System.Drawing.Size(764, 460)
        Me.GB_Nouveau.TabIndex = 8
        Me.GB_Nouveau.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(217, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.LightYellow
        Me.Label6.Location = New System.Drawing.Point(97, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(385, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Entrer les informations des eleves"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(15, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tu es l'enseignement des eleves ?"
        '
        'Chec_oui
        '
        Me.Chec_oui.AutoSize = True
        Me.Chec_oui.Location = New System.Drawing.Point(298, 32)
        Me.Chec_oui.Name = "Chec_oui"
        Me.Chec_oui.Size = New System.Drawing.Size(46, 19)
        Me.Chec_oui.TabIndex = 17
        Me.Chec_oui.Text = "OUI"
        Me.Chec_oui.UseVisualStyleBackColor = True
        '
        'Check_Non
        '
        Me.Check_Non.AutoSize = True
        Me.Check_Non.Location = New System.Drawing.Point(370, 32)
        Me.Check_Non.Name = "Check_Non"
        Me.Check_Non.Size = New System.Drawing.Size(49, 19)
        Me.Check_Non.TabIndex = 18
        Me.Check_Non.Text = "Non"
        Me.Check_Non.UseVisualStyleBackColor = True
        '
        'Frm_eleve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.GB_Nouveau)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_eleve"
        Me.Text = "Frm_eleve"
        Me.GB_liste.ResumeLayout(False)
        Me.GB_liste.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Nouveau.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_Fermer As Button
    Friend WithEvents BTN_Nouveau As Button
    Friend WithEvents GB_liste As GroupBox
    Friend WithEvents DTPnaissance As DateTimePicker
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Txtprenom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Radio_Masculin As RadioButton
    Friend WithEvents Radio_Féminin As RadioButton
    Friend WithEvents BTN_Enre As Button
    Friend WithEvents BTN_Annuler As Button
    Friend WithEvents GB_Nouveau As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
    Friend WithEvents ColPrenom As DataGridViewTextBoxColumn
    Friend WithEvents ColSexe As DataGridViewTextBoxColumn
    Friend WithEvents ColDate As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Check_Non As CheckBox
    Friend WithEvents Chec_oui As CheckBox
End Class
