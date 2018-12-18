Public Class Usuario
    Public Function Listar() As List(Of EL.Usuario)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim usuarios As New List(Of EL.Usuario)
        con.EjecutarConsulta("
        select u.id_persona
         from dbo.Usuario u
         where u.estado = 'A'
           and u.usuario <> 'admin'")
        con.adp.Fill(datatable)

        For index = 0 To datatable.Rows.Count - 1
            usuarios.Add(New Usuario().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return usuarios
    End Function

    Public Function GetById(pId As Int16) As EL.Usuario
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim usuario As EL.Usuario
        con.EjecutarConsulta("select * from dbo.Usuario u where u.id_persona = " & pId)
        con.adp.Fill(datatable)
        usuario = New EL.Usuario(New Persona().GetById(datatable.Rows(0).ItemArray(0).ToString())) With {
            .Usuario = datatable.Rows(0).ItemArray(1).ToString(),
            .Password = datatable.Rows(0).ItemArray(2).ToString()
        }
        Return usuario

    End Function

    Public Sub BlanquearClave(usuario As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", usuario.Id))
        parametros.Add(New SqlClient.SqlParameter("@usuario", usuario.Usuario))
        con.EjecutarStoredProcedure("dbo.BlanquearClave", parametros)
    End Sub

    Public Sub Guardar(usuario As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", usuario.Id))
        parametros.Add(New SqlClient.SqlParameter("@usuario", usuario.Usuario))
        parametros.Add(New SqlClient.SqlParameter("@password", usuario.Password))
        con.EjecutarStoredProcedure("dbo.GuardarUsuario", parametros)

        parametros = Nothing
        parametros = New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@usuario", usuario.Usuario))
        Dim permisos As String = ""
        For Each permiso As EL.Permiso In usuario.Permisos
            permisos += permiso.Id + ";"
        Next
        permisos = permisos.Substring(0, permisos.Length() - 1)
        parametros.Add(New SqlClient.SqlParameter("@permisos", permisos))
        con.EjecutarStoredProcedure("dbo.GuardarPermisosUsuario", parametros)
    End Sub

    Public Sub Quitar(usuario As EL.Usuario)
        Dim con As New Conexion()
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@usuario", usuario.Usuario))
        con.EjecutarStoredProcedure("dbo.QuitarUsuario", parametros)
    End Sub

    Public Function GetByUsuario(pUsuario As String) As EL.Usuario
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim usuario As EL.Usuario
        con.EjecutarConsulta("select id_persona from dbo.Usuario u
            where u.usuario = '" + pUsuario + "'")
        con.adp.Fill(datatable)
        usuario = New Usuario().GetById(datatable.Rows(0).ItemArray(0).ToString())
        Return usuario
    End Function

End Class
