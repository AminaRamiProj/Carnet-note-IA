Imports System.IO

''' <summary>
''' Gère la lecture de la clé API IA sans jamais l'écrire en dur dans le code source.
''' Ordre de recherche :
'''   1) Variable d'environnement ANTHROPIC_API_KEY
'''   2) Fichier "api_key.txt" placé à côté de l'exécutable (dans bin\Debug\...)
''' </summary>
Public Module IAConfig

    Public Function ObtenirCleApi() As String
        ' 1) Variable d'environnement (recommandé : évite tout risque si le projet est partagé)
        Dim cle As String = Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY")
        If Not String.IsNullOrWhiteSpace(cle) Then
            Return cle.Trim()
        End If

        ' 2) Fichier local api_key.txt (pratique pour les tests, mais à NE JAMAIS
        '    committer dans un dépôt Git partagé — ajoutez-le à .gitignore)
        Dim chemin As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "api_key.txt")
        If File.Exists(chemin) Then
            Return File.ReadAllText(chemin).Trim()
        End If

        Return String.Empty
    End Function

End Module
