Public Class Usuario
    Public Function MostrarLista() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("     
        select u.id_usuario, p.apellido, p.nombre, u.nro_documento, p.telefono, p.domicilio
        from dbo.Usuario u inner join dbo.Persona p on u.id_persona = p.id_persona where u.estado = 'A'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

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

    Public Function GetByUsuario(pUsuario As String) As DataTable
        Dim con As New Conexion()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select id_usuario, p.nombre, p.apellido,p.domicilio,p.email,p.telefono, nro_documento, fecha_nacimiento from dbo.usuario u inner join dbo.Persona p on u.id_persona = p.id_persona where id_usuario = '" + pUsuario + "'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function GetRolesByUsuario(pUsuario As String) As DataTable
        Dim con As New Conexion()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select id_usuario, id_permiso from dbo.usuario_permiso where id_usuario = '" + pUsuario + "'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

End Class
