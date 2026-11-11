Module carnetdenote
    Public Structure Str_eleve
        <VBFixedString(13)> Dim Num_eleve As String
        <VBFixedString(60)> Dim Nom_eleve As String
        <VBFixedString(100)> Dim Prenom_eleve As String
        <VBFixedString(20)> Dim Age As String
        <VBFixedString(10)> Dim genre_eleve As String
    End Structure
    Public Structure Str_Note
        <VBFixedString(20)> Dim Nu_eleve As String
        <VBFixedString(40)> Dim Num_evaluation As String
        <VBFixedString(70)> Dim opservation As String
    End Structure
    Public Structure Str_Evaluation
        <VBFixedString(50)> Dim Nm_evaluation As String
        <VBFixedString(20)> Dim jour As String
        <VBFixedString(30)> Dim Date_Correction As String
        <VBFixedString(30)> Dim remarque As String
    End Structure

    'Déclaration des enregistrements des structures
    Public Enreg_eleve As Str_eleve
    Public Enreg_Note As Str_Note
    Public Enreg_Evaluation As Str_Evaluation
    'Generer le Num_eleve



End Module
