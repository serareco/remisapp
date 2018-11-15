Public Class Usuario
    Public Function MostrarLista() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("     
        select u.id_usuario, p.apellido, p.nombre, u.nro_documento, p.telefono, p.domicilio
        from Usuarios u inner join Personas p on u.id_persona = p.id_persona where u.estado = 'A'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(usuario As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@usuario", usuario.Usuario))
        parametros.Add(New SqlClient.SqlParameter("@password", usuario.Password))
        parametros.Add(New SqlClient.SqlParameter("@fecha_nacimiento", usuario.FechaNacimiento))
        parametros.Add(New SqlClient.SqlParameter("@nro_documento", usuario.NroDocumento))
        parametros.Add(New SqlClient.SqlParameter("@nombre", usuario.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", usuario.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", usuario.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", usuario.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", usuario.Email))
        con.EjecutarStoredProcedure("dbo.GuardarUsuario", parametros)
        parametros = Nothing
        parametros = New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@usuario", usuario.Usuario))
        Dim roles As String = ""
        For Each rol As EL.Permiso In usuario.Permisos
            roles += rol.Id + ";"
        Next
        roles = roles.Substring(0, roles.Length() - 1)
        parametros.Add(New SqlClient.SqlParameter("@roles", roles))
        con.EjecutarStoredProcedure("dbo.GuardarRolesUsuario", parametros)
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
        con.EjecutarConsulta("select id_usuario, p.nombre, p.apellido,p.domicilio,p.email,p.telefono, nro_documento, fecha_nacimiento from usuarios u inner join Personas p on u.id_persona = p.id_persona where id_usuario = '" + pUsuario + "'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function GetRolesByUsuario(pUsuario As String) As DataTable
        Dim con As New Conexion()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select id_usuario, id_rol from usuarios_roles where id_usuario = '" + pUsuario + "'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

End Class
