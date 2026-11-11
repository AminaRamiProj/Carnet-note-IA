<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAssistantIA = New System.Windows.Forms.Button()
        Me.BtnMLAvance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAssistantIA
        '
        Me.BtnAssistantIA.Location = New System.Drawing.Point(24, 24)
        Me.BtnAssistantIA.Name = "BtnAssistantIA"
        Me.BtnAssistantIA.Size = New System.Drawing.Size(220, 40)
        Me.BtnAssistantIA.TabIndex = 0
        Me.BtnAssistantIA.Text = "Assistant IA"
        Me.BtnAssistantIA.UseVisualStyleBackColor = True
        '
        'BtnMLAvance
        '
        Me.BtnMLAvance.Location = New System.Drawing.Point(24, 76)
        Me.BtnMLAvance.Name = "BtnMLAvance"
        Me.BtnMLAvance.Size = New System.Drawing.Size(220, 40)
        Me.BtnMLAvance.TabIndex = 1
        Me.BtnMLAvance.Text = "Prédictions ML && Statistiques"
        Me.BtnMLAvance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 371)
        Me.Controls.Add(Me.BtnMLAvance)
        Me.Controls.Add(Me.BtnAssistantIA)
        Me.Name = "Form1"
        Me.Text = "form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAssistantIA As System.Windows.Forms.Button
    Friend WithEvents BtnMLAvance As System.Windows.Forms.Button

End Class
