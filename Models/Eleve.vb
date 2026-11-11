''' <summary>
''' Représentation d'un élève dans la base de données (couche Models).
''' Remplace la structure Str_eleve à taille fixe utilisée dans la version d'origine :
''' plus flexible, plus facile à faire évoluer, et compatible avec Entity/Dapper/ADO.NET.
''' </summary>
Public Class Eleve
    Public Property Id As Integer
    Public Property Numero As String
    Public Property Nom As String
    Public Property Prenom As String
    Public Property Genre As String            ' "Masculin" / "Féminin"
    Public Property DateNaissance As String

    Public ReadOnly Property NomComplet As String
        Get
            Return $"{Prenom} {Nom}"
        End Get
    End Property
End Class
