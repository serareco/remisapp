Public Class Registro
    Public Function GetById(pId As Int16) As EL.Registro
        Return New DAL.Registro().GetById(pId)
    End Function
End Class
