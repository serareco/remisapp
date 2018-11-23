Public Class Persona
    Public Sub Guardar(usuario As EL.Persona)
        Dim e As New DAL.Persona()
        e.Guardar(usuario)
    End Sub
End Class
