Public Class Login
    Public Function Login(ByRef pDatosLogin As EL.Login) As Boolean
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Usuario", pDatosLogin.Usuario.Usuario))
        parametros.Add(New SqlClient.SqlParameter("@Password", pDatosLogin.Usuario.Password))

        Dim pRespuesta As New SqlClient.SqlParameter("@Respuesta", SqlDbType.Int)
        pRespuesta.Direction = ParameterDirection.Output
        parametros.Add(pRespuesta)

        Dim primerIngreso As New SqlClient.SqlParameter("@PrimerIngreso", SqlDbType.VarChar, 1)
        primerIngreso.Direction = ParameterDirection.Output
        parametros.Add(primerIngreso)

        con.EjecutarStoredProcedure("dbo.Login", parametros)

        pDatosLogin.PrimerIngreso = primerIngreso.Value = "S"

        If pRespuesta.Value = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function GetPermisos(pUsuario As String) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select id_permiso from usuario_permiso where usuario = '" + pUsuario + "'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub ActualizarPassword(pUsuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Usuario", pUsuarioConectado.Usuario))
        parametros.Add(New SqlClient.SqlParameter("@Password", pUsuarioConectado.Password))
        con.EjecutarStoredProcedure("dbo.ActualizarPassword", parametros)
    End Sub

End Class
