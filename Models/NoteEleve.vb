''' <summary>
''' Une note obtenue par un élève à une évaluation donnée.
''' </summary>
Public Class NoteEleve
    Public Property Id As Integer
    Public Property EleveId As Integer
    Public Property NumEvaluation As String
    Public Property Valeur As Double
    Public Property Absent As Boolean
    Public Property AbsenceJustifiee As Boolean
    Public Property Observation As String
    Public Property DateNote As DateTime
End Class
