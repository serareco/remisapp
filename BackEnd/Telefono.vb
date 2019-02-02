Public Class Telefono
    Public Function GetById(pId As Int16) As EL.Telefono
        Return New DAL.Telefono().GetById(pId)
    End Function

    Public Function GetByPersonaId(pId As Int16) As List(Of EL.Telefono)
        Return New DAL.Telefono().GetByPersonaId(pId)
    End Function
End Class
