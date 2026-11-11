Public Class Frm_eleve
    Private Sub BTN_Nouveau_Click(sender As Object, e As EventArgs) Handles BTN_Nouveau.Click
        GB_Nouveau.Visible = True
        GB_liste.Visible = False
        'Vider  tout les zones
        txtNum.Text = "" : txtNum.Text = ""
        TxtNom.Text = "" : TxtNom.Text = ""
        Txtprenom.Text = "" : Txtprenom.Text = ""

        txtNum.Focus()

    End Sub

    Private Sub Frm_eleve_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_Fermer_Click(sender As Object, e As EventArgs) Handles BTN_Fermer.Click
        Me.Dispose()

    End Sub

    Private Sub BTN_Annuler_Click(sender As Object, e As EventArgs) Handles BTN_Annuler.Click
        GB_Nouveau.Visible = False
        GB_liste.Visible = True

    End Sub

    Private Sub BTN_Enre_Click(sender As Object, e As EventArgs) Handles BTN_Enre.Click
        'vérifier la validité des donnes entrer
        If txtNum.Text = "" Then
            MsgBox("veulliez entrer le Num_eleve", vbYesNo + vbCritical + vbDefaultButton1)
            txtNum.Focus() : Exit Sub
        End If
        If TxtNom.Text = "" Then
            MsgBox("veulliez entrer le Nom_eleve", vbYesNo + vbCritical + vbDefaultButton1)
            TxtNom.Focus() : Exit Sub
        End If
        If Txtprenom.Text = "" Then
            MsgBox("veulliez entrer le Prenom_eleve", vbYesNo + vbCritical + vbDefaultButton1)
            TxtNom.Focus() : Exit Sub
        End If
        If Radio_Féminin.Checked = False And Radio_Masculin.Checked = False Then
            MsgBox("veuillez cocher soit sur Féminin soit sur Masculin", vbYesNo + vbCritical + vbDefaultButton1)
            Exit Sub
        End If

        enregistrer_les_donnes()
        MsgBox("Élève enregistré avec succès.", vbInformation)
        GB_Nouveau.Visible = False
        GB_liste.Visible = True
    End Sub

    Private Sub enregistrer_les_donnes()
        ' Remplit l'enregistrement à partir des zones de saisie
        Enreg_eleve.Num_eleve = txtNum.Text
        Enreg_eleve.Nom_eleve = TxtNom.Text
        Enreg_eleve.Prenom_eleve = Txtprenom.Text
        Enreg_eleve.genre_eleve = If(Radio_Féminin.Checked, "Féminin", "Masculin")

        Dim M As Integer = Len(Enreg_eleve)
        FileOpen(1, "eleve.RM", OpenMode.Random, OpenAccess.ReadWrite, , M)
        Try
            Dim numeroEnregistrement As Integer = CInt(LOF(1) / M) + 1
            FilePut(1, Enreg_eleve, numeroEnregistrement)
        Finally
            FileClose(1)
        End Try
    End Sub

    Private Sub GB_liste_Enter(sender As Object, e As EventArgs) Handles GB_liste.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class