Imports System.Linq

''' <summary>
''' Statistiques descriptives sur la classe, et regroupement des élèves par profil de
''' performance via un algorithme K-Means implémenté ici "à la main" (sans librairie
''' externe) : distance euclidienne, réaffectation itérative, recalcul des centroïdes.
''' Choix pédagogique volontaire pour un projet de portfolio : montre la compréhension
''' de l'algorithme, au-delà du simple appel à une bibliothèque.
''' </summary>
Public Class StatistiquesService

    Public Class ProfilEleve
        Public Property Nom As String
        Public Property Moyenne As Double
        Public Property EcartType As Double   ' régularité (faible = régulier)
        Public Property Tendance As Double    ' pente approx. (positif = progresse)
        Public Property Cluster As Integer
    End Class

    ' ------------------------------------------------------------------
    ' Statistiques descriptives
    ' ------------------------------------------------------------------
    Public Function Moyenne(valeurs As List(Of Double)) As Double
        Return If(valeurs.Count > 0, valeurs.Average(), 0)
    End Function

    Public Function EcartType(valeurs As List(Of Double)) As Double
        If valeurs.Count < 2 Then Return 0
        Dim m = Moyenne(valeurs)
        Dim varianceSomme = valeurs.Sum(Function(v) (v - m) * (v - m))
        Return Math.Sqrt(varianceSomme / (valeurs.Count - 1))
    End Function

    ''' <summary>Coefficient de corrélation de Pearson entre deux séries de même longueur.</summary>
    Public Function Correlation(x As List(Of Double), y As List(Of Double)) As Double
        If x.Count <> y.Count OrElse x.Count < 2 Then Return 0
        Dim mx = Moyenne(x), my = Moyenne(y)
        Dim covariance = x.Zip(y, Function(a, b) (a - mx) * (b - my)).Sum()
        Dim ecx = Math.Sqrt(x.Sum(Function(a) (a - mx) * (a - mx)))
        Dim ecy = Math.Sqrt(y.Sum(Function(b) (b - my) * (b - my)))
        If ecx = 0 OrElse ecy = 0 Then Return 0
        Return covariance / (ecx * ecy)
    End Function

    ''' <summary>Pente approximative (régression linéaire simple) pour estimer la tendance d'un élève.</summary>
    Public Function Tendance(notes As List(Of Double)) As Double
        If notes.Count < 2 Then Return 0
        Dim xs = Enumerable.Range(0, notes.Count).Select(Function(i) CDbl(i)).ToList()
        Dim mx = Moyenne(xs), my = Moyenne(notes)
        Dim numerateur = xs.Zip(notes, Function(a, b) (a - mx) * (b - my)).Sum()
        Dim denominateur = xs.Sum(Function(a) (a - mx) * (a - mx))
        If denominateur = 0 Then Return 0
        Return numerateur / denominateur
    End Function

    ' ------------------------------------------------------------------
    ' Clustering K-Means (2 dimensions : moyenne, régularité)
    ' ------------------------------------------------------------------

    ''' <summary>
    ''' Regroupe les élèves en `k` profils selon (moyenne, écart-type des notes).
    ''' Retourne la liste des élèves enrichie de leur numéro de cluster.
    ''' </summary>
    Public Function RegrouperParProfil(eleves As Dictionary(Of String, List(Of Double)),
                                        Optional k As Integer = 3,
                                        Optional iterationsMax As Integer = 50) As List(Of ProfilEleve)
        Dim profils As New List(Of ProfilEleve)
        For Each paire In eleves
            If paire.Value.Count = 0 Then Continue For
            profils.Add(New ProfilEleve With {
                .Nom = paire.Key,
                .Moyenne = Moyenne(paire.Value),
                .EcartType = EcartType(paire.Value),
                .Tendance = Tendance(paire.Value)
            })
        Next

        If profils.Count = 0 Then Return profils
        k = Math.Min(k, profils.Count)

        ' Initialisation des centroïdes : k élèves pris régulièrement dans la liste triée par moyenne
        Dim tries = profils.OrderBy(Function(p) p.Moyenne).ToList()
        Dim centroides(k - 1, 1) As Double ' colonne 0 = moyenne, colonne 1 = écart-type
        For i As Integer = 0 To k - 1
            Dim indexElement = CInt(i * (tries.Count - 1) / Math.Max(1, k - 1))
            centroides(i, 0) = tries(indexElement).Moyenne
            centroides(i, 1) = tries(indexElement).EcartType
        Next

        For iteration As Integer = 1 To iterationsMax
            Dim changement As Boolean = False

            ' Étape 1 : assigner chaque élève au centroïde le plus proche
            For Each p In profils
                Dim meilleurCluster As Integer = 0
                Dim meilleureDistance As Double = Double.MaxValue
                For c As Integer = 0 To k - 1
                    Dim d = Distance(p.Moyenne, p.EcartType, centroides(c, 0), centroides(c, 1))
                    If d < meilleureDistance Then
                        meilleureDistance = d
                        meilleurCluster = c
                    End If
                Next
                If p.Cluster <> meilleurCluster Then changement = True
                p.Cluster = meilleurCluster
            Next

            If Not changement Then Exit For

            ' Étape 2 : recalculer les centroïdes
            For c As Integer = 0 To k - 1
                Dim membres = profils.Where(Function(p) p.Cluster = c).ToList()
                If membres.Count > 0 Then
                    centroides(c, 0) = membres.Average(Function(p) p.Moyenne)
                    centroides(c, 1) = membres.Average(Function(p) p.EcartType)
                End If
            Next
        Next

        Return profils
    End Function

    Private Function Distance(m1 As Double, e1 As Double, m2 As Double, e2 As Double) As Double
        Return Math.Sqrt((m1 - m2) ^ 2 + (e1 - e2) ^ 2)
    End Function

    ''' <summary>Donne un libellé lisible à un cluster en fonction de la moyenne de ses membres.</summary>
    Public Function LibellerCluster(membres As List(Of ProfilEleve)) As String
        If membres.Count = 0 Then Return "Vide"
        Dim moyenneCluster = membres.Average(Function(p) p.Moyenne)
        If moyenneCluster >= 14 Then Return "Excellents"
        If moyenneCluster >= 10 Then Return "Réguliers"
        Return "À accompagner"
    End Function

End Class
