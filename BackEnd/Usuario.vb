Public Class Usuario
    Dim personaService As New Persona()
    Dim usuarioDAL As New DAL.Usuario()
    Public Function Listar() As List(Of EL.Usuario)
        Return New DAL.Usuario().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Usuario
        Dim usuario As EL.Usuario = usuarioDAL.GetById(pId)
        usuario.Permisos = Login.GetPermisos(usuario.Usuario)
        Return usuario
    End Function

    Public Sub Guardar(usuario As EL.Usuario)
        personaService.Guardar(usuario)
        usuarioDAL.Guardar(usuario, Login.UsuarioConectado)
    End Sub

    Public Sub BlanquearClave(usuario As EL.Usuario)
        usuarioDAL.BlanquearClave(usuario)
    End Sub

    Public Sub Quitar(usuario As EL.Usuario)
        usuarioDAL.Quitar(usuario, Login.UsuarioConectado)
    End Sub

    Public Function GetByUsuario(pUsuario As String) As EL.Usuario
        Dim usuario As EL.Usuario = usuarioDAL.GetByUsuario(pUsuario)
        usuario.Permisos = Login.GetPermisos(usuario.Usuario)
        Return usuario
    End Function

End Class
