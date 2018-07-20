Public Module Login
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Private Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Function Login() As Boolean
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Usuario", Usuario))
        parametros.Add(New SqlClient.SqlParameter("@Password", Password))
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

End Module
