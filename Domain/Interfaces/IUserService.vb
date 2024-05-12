Public Interface IUserService
    Function GetUser() As Task(Of List(Of User))
    Function InsUser(user As User) As Task(Of Boolean)
End Interface