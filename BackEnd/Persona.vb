Public Class Persona
    Public Sub Guardar(persona As EL.Persona)
        Dim e As New DAL.Persona()
        e.Guardar(persona)
    End Sub

    Public Function GetById(pId As Int16) As EL.Persona
        Return New DAL.Persona().GetById(pId)
    End Function

End Class
