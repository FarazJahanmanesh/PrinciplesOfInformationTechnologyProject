
Public Class ActionResponse(Of T)
    Public Sub New()
        Errors = New List(Of String)()
    End Sub

    Public Property Status As Integer
    Public Property Message As String
    Public Property Data As T
    Public Property State As ResponseStateEnum
    Public Property Errors As List(Of String)
End Class



Public Class ActionResponse

    Public Sub New()
        Errors = New List(Of String)()
    End Sub

    Public Property Status As Integer
    Public Property Message As String
    Public Property State As ResponseStateEnum
    Public Property Errors As List(Of String)
End Class


Public Enum ResponseStateEnum
    FAILED = 0
    SUCCESS = 1
    NOTAUTHORIZED = 2
End Enum