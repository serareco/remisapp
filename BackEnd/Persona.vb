Public Class Persona
    Dim personaDAL As New DAL.Persona()
    Public Sub Guardar(persona As EL.Persona)
        personaDAL.Guardar(persona, Login.UsuarioConectado)
    End Sub

    Public Function GetById(pId As Int16) As EL.Persona
        Return personaDAL.GetById(pId)
    End Function

End Class
