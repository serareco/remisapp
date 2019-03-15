Public Class Domicilio
    Dim domicilioDAL As New DAL.Domicilio()
    Public Function GetById(pId As Int16) As EL.Domicilio
        Return domicilioDAL.GetById(pId)
    End Function

    Public Function GetByPersonaId(pId As Int16) As List(Of EL.Domicilio)
        Return domicilioDAL.GetByPersonaId(pId)
    End Function

End Class
