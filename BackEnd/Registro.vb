Public Class Registro
    Dim registroDAL As New DAL.Registro()
    Public Function GetByChoferId(pId As Int16) As EL.Registro
        Return registroDAL.GetByChoferId(pId)
    End Function
End Class
