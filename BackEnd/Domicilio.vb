Public Class Domicilio
    Public Function GetById(pId As Int16) As EL.Domicilio
        Return New DAL.Domicilio().GetById(pId)
    End Function

    Public Function GetByPersonaId(pId As Int16) As List(Of EL.Domicilio)
        Return New DAL.Domicilio().GetByPersonaId(pId)
    End Function

End Class
