Public Class BaseEntity(Of T)
    Public Property Id As T
End Class

Public Class BaseEntity
    Inherits BaseEntity(Of Long)
End Class
