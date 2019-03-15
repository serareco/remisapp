Public Class Telefono
    Dim telefonoDAL As New DAL.Telefono()
    Public Function GetById(pId As Int16) As EL.Telefono
        Return telefonoDAL.GetById(pId)
    End Function

    Public Function GetByPersonaId(pId As Int16) As List(Of EL.Telefono)
        Return telefonoDAL.GetByPersonaId(pId)
    End Function
End Class
