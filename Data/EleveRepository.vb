Imports Microsoft.Data.Sqlite

''' <summary>
''' Accès aux données "Eleves" : encapsule toutes les requêtes SQL pour ne jamais
''' avoir de SQL brut dispersé dans les formulaires (séparation des responsabilités).
''' </summary>
Public Class EleveRepository

    Public Function Ajouter(e As Eleve) As Integer
        Using connexion = DatabaseContext.NouvelleConnexion()
            Using commande = connexion.CreateCommand()
                commande.CommandText = "
                    INSERT INTO Eleves (Numero, Nom, Prenom, Genre, DateNaissance)
                    VALUES ($numero, $nom, $prenom, $genre, $naissance);
                    SELECT last_insert_rowid();"
                commande.Parameters.AddWithValue("$numero", e.Numero)
                commande.Parameters.AddWithValue("$nom", e.Nom)
                commande.Parameters.AddWithValue("$prenom", e.Prenom)
                commande.Parameters.AddWithValue("$genre", e.Genre)
                commande.Parameters.AddWithValue("$naissance", e.DateNaissance)
                Return CInt(CLng(commande.ExecuteScalar()))
            End Using
        End Using
    End Function

    Public Function ListerTous() As List(Of Eleve)
        Dim liste As New List(Of Eleve)
        Using connexion = DatabaseContext.NouvelleConnexion()
            Using commande = connexion.CreateCommand()
                commande.CommandText = "SELECT Id, Numero, Nom, Prenom, Genre, DateNaissance FROM Eleves ORDER BY Nom"
                Using lecteur = commande.ExecuteReader()
                    While lecteur.Read()
                        liste.Add(New Eleve With {
                            .Id = lecteur.GetInt32(0),
                            .Numero = lecteur.GetString(1),
                            .Nom = lecteur.GetString(2),
                            .Prenom = lecteur.GetString(3),
                            .Genre = If(lecteur.IsDBNull(4), "", lecteur.GetString(4)),
                            .DateNaissance = If(lecteur.IsDBNull(5), "", lecteur.GetString(5))
                        })
                    End While
                End Using
            End Using
        End Using
        Return liste
    End Function

    Public Sub Supprimer(id As Integer)
        Using connexion = DatabaseContext.NouvelleConnexion()
            Using commande = connexion.CreateCommand()
                commande.CommandText = "DELETE FROM Eleves WHERE Id = $id"
                commande.Parameters.AddWithValue("$id", id)
                commande.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
