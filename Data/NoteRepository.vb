Imports Microsoft.Data.Sqlite

''' <summary>
''' Accès aux données "Notes". Fournit aussi des requêtes agrégées directement
''' exploitables par la couche Services (statistiques) et ML (features d'entraînement).
''' </summary>
Public Class NoteRepository

    Public Sub Ajouter(n As NoteEleve)
        Using connexion = DatabaseContext.NouvelleConnexion()
            Using commande = connexion.CreateCommand()
                commande.CommandText = "
                    INSERT INTO Notes (EleveId, NumEvaluation, Valeur, Absent, AbsenceJustifiee, Observation, DateNote)
                    VALUES ($eleveId, $eval, $valeur, $absent, $justifiee, $obs, $date)"
                commande.Parameters.AddWithValue("$eleveId", n.EleveId)
                commande.Parameters.AddWithValue("$eval", n.NumEvaluation)
                commande.Parameters.AddWithValue("$valeur", n.Valeur)
                commande.Parameters.AddWithValue("$absent", If(n.Absent, 1, 0))
                commande.Parameters.AddWithValue("$justifiee", If(n.AbsenceJustifiee, 1, 0))
                commande.Parameters.AddWithValue("$obs", If(n.Observation, ""))
                commande.Parameters.AddWithValue("$date", n.DateNote.ToString("yyyy-MM-dd"))
                commande.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>Renvoie, pour chaque élève, la liste ordonnée de ses notes (utile aux features ML).</summary>
    Public Function ListerParEleve(eleveId As Integer) As List(Of Double)
        Dim notes As New List(Of Double)
        Using connexion = DatabaseContext.NouvelleConnexion()
            Using commande = connexion.CreateCommand()
                commande.CommandText = "SELECT Valeur FROM Notes WHERE EleveId = $id AND Absent = 0 ORDER BY DateNote"
                commande.Parameters.AddWithValue("$id", eleveId)
                Using lecteur = commande.ExecuteReader()
                    While lecteur.Read()
                        If Not lecteur.IsDBNull(0) Then notes.Add(lecteur.GetDouble(0))
                    End While
                End Using
            End Using
        End Using
        Return notes
    End Function

    ''' <summary>Nombre d'absences (justifiées ou non) pour un élève.</summary>
    Public Function CompterAbsences(eleveId As Integer) As Integer
        Using connexion = DatabaseContext.NouvelleConnexion()
            Using commande = connexion.CreateCommand()
                commande.CommandText = "SELECT COUNT(*) FROM Notes WHERE EleveId = $id AND Absent = 1"
                commande.Parameters.AddWithValue("$id", eleveId)
                Return CInt(CLng(commande.ExecuteScalar()))
            End Using
        End Using
    End Function

End Class
