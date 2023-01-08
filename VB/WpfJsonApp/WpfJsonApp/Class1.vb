
Public Class LeagueContainer
    Public Property type As String
    Public Property version As String
    Public Property data As Dictionary(Of String, DataItem)
End Class

Public Class DataItem
    Public Property id As Integer
    Public Property key As String
    Public Property name As String
    Public Property title As String
End Class


