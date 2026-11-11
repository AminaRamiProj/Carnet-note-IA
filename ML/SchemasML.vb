Imports Microsoft.ML.Data

''' <summary>
''' Vecteur de caractéristiques (features) décrivant la trajectoire d'un élève.
''' Utilisé à la fois pour l'entraînement (avec les colonnes Label) et l'inférence.
''' </summary>
Public Class DonneesEleveML
    Public Property Note1 As Single
    Public Property Note2 As Single
    Public Property Note3 As Single
    Public Property Absences As Single
    Public Property MoyennePrecedente As Single

    ' Label pour la régression : note finale réellement obtenue
    Public Property NoteFinale As Single

    ' Label pour la classification binaire : l'élève est-il en difficulté (moyenne < 10) ?
    Public Property EnDifficulte As Boolean
End Class

''' <summary>Sortie du modèle de régression (prédiction de la note finale, /20).</summary>
Public Class PredictionNoteFinale
    <ColumnName("Score")>
    Public Property NoteFinalePredite As Single
End Class

''' <summary>Sortie du modèle de classification (risque de décrochage).</summary>
Public Class PredictionRisque
    <ColumnName("PredictedLabel")>
    Public Property EnDifficulte As Boolean

    Public Property Probability As Single
    Public Property Score As Single
End Class
