Public Class Domicilio
    Public Function GetById(pId As Int16) As EL.Domicilio
        Return New DAL.Domicilio().GetById(pId)
    End Function
End Class
