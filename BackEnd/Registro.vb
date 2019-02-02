Public Class Registro
    Public Function GetByChoferId(pId As Int16) As EL.Registro
        Return New DAL.Registro().GetByChoferId(pId)
    End Function
End Class
