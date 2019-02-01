Public Class Usuario
    Public Function Listar() As List(Of EL.Usuario)
        Return New DAL.Usuario().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Usuario
        Dim usuario As EL.Usuario = New DAL.Usuario().GetById(pId)
        usuario.Permisos = Login.GetPermisos(usuario.Usuario)
        Return usuario
    End Function

    Public Sub Guardar(usuario As EL.Usuario)
        Dim p As New Persona()
        p.Guardar(usuario)
        Dim e As New DAL.Usuario()
        e.Guardar(usuario)
    End Sub

    Public Sub BlanquearClave(usuario As EL.Usuario)
        Dim e As New DAL.Usuario()
        e.BlanquearClave(usuario)
    End Sub

    Public Sub Quitar(usuario As EL.Usuario)
        Dim e As New DAL.Usuario()
        e.Quitar(usuario)
    End Sub

    Public Function GetByUsuario(pUsuario As String) As EL.Usuario
        Dim usuario As EL.Usuario = New DAL.Usuario().GetByUsuario(pUsuario)
        usuario.Permisos = Login.GetPermisos(usuario.Usuario)
        Return usuario
    End Function

End Class
