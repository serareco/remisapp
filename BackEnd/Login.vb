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
            UsuarioConectado.Roles = GetRoles(pDatosLogin.Usuario)
        End If
        Return resultLogin

    End Function

    Public Function GetRoles(pUsuario As String) As List(Of EL.Rol)
        Dim roles As New List(Of EL.Rol)
        For Each item As DataRow In New DAL.Login().GetRoles(pUsuario).Rows
            roles.Add(New BLL.Rol().GetById(item.ItemArray(0).ToString()))
        Next
        Return roles
    End Function

    Public Function EsOperador() As Boolean
        For Each rol As EL.Rol In UsuarioConectado.Roles
            If rol.Id = "O" Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function EsResponsable() As Boolean
        For Each rol As EL.Rol In UsuarioConectado.Roles
            If rol.Id = "R" Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
