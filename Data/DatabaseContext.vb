Imports Microsoft.Data.Sqlite
Imports System.IO

''' <summary>
''' Point d'entrée unique vers la base SQLite locale "carnet_de_notes.db".
''' Remplace les fichiers à accès aléatoire (FileOpen/OpenMode.Random) de la version
''' initiale par un vrai moteur de base de données relationnelle : requêtes SQL,
''' intégrité des données, et surtout une base exploitable directement par les
''' modules Machine Learning et statistiques (couche ML / Services).
''' </summary>
Public Module DatabaseContext

    Private ReadOnly CheminBase As String =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "carnet_de_notes.db")

    Public Function NouvelleConnexion() As SqliteConnection
        Dim connexion As New SqliteConnection($"Data Source={CheminBase}")
        connexion.Open()
        Return connexion
    End Function

    ''' <summary>
    ''' Crée les tables si elles n'existent pas encore. À appeler une fois au démarrage
    ''' de l'application (voir ApplicationEvents.vb).
    ''' </summary>
    Public Sub InitialiserBase()
        Using connexion = NouvelleConnexion()
            Dim script As String = "
                CREATE TABLE IF NOT EXISTS Eleves (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Numero TEXT NOT NULL UNIQUE,
                    Nom TEXT NOT NULL,
                    Prenom TEXT NOT NULL,
                    Genre TEXT,
                    DateNaissance TEXT
                );

                CREATE TABLE IF NOT EXISTS Notes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    EleveId INTEGER NOT NULL,
                    NumEvaluation TEXT NOT NULL,
                    Valeur REAL,
                    Absent INTEGER NOT NULL DEFAULT 0,
                    AbsenceJustifiee INTEGER NOT NULL DEFAULT 0,
                    Observation TEXT,
                    DateNote TEXT,
                    FOREIGN KEY (EleveId) REFERENCES Eleves(Id)
                );

                CREATE TABLE IF NOT EXISTS ConversationsIA (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Role TEXT NOT NULL,
                    Texte TEXT NOT NULL,
                    DateMessage TEXT NOT NULL
                );
            "
            Using commande = connexion.CreateCommand()
                commande.CommandText = script
                commande.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
