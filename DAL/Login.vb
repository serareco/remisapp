Public Class Login
    Public Function Login(pDatosLogin As EL.Login) As Boolean
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Usuario", pDatosLogin.Usuario))
        parametros.Add(New SqlClient.SqlParameter("@Password", pDatosLogin.Password))
        Dim pRespuesta As New SqlClient.SqlParameter("@Respuesta", SqlDbType.Int)
        pRespuesta.Direction = ParameterDirection.Output
        parametros.Add(pRespuesta)

        con.EjecutarStoredProcedure("dbo.Login", parametros)

        If pRespuesta.Value = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
