Public Module Login
    Private _usuarioConectado As EL.Login
    Public Property UsuarioConectado() As EL.Login
        Get
            Return _usuarioConectado
        End Get
        Set(ByVal value As EL.Login)
            _usuarioConectado = value
        End Set
    End Property

    Public Function Login(pDatosLogin As EL.Login) As Boolean
        Dim resultLogin As Boolean = New DAL.Login().Login(pDatosLogin)
        If resultLogin Then
            UsuarioConectado = pDatosLogin
            UsuarioConectado.Roles = New DAL.Login().GetRoles(pDatosLogin.Usuario)
        End If
        Return resultLogin

    End Function

    Public Function EsOperador() As Boolean
        If UsuarioConectado.Roles(0).Id = "O" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EsResponsable() As Boolean
        If UsuarioConectado.Roles(0).Id = "R" Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
