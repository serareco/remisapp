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
            UsuarioConectado.Permisos = GetRoles(pDatosLogin.Usuario)
        End If
        Return resultLogin

    End Function

    Public Function GetRoles(pUsuario As String) As List(Of EL.Permiso)
        Dim permisos As New List(Of EL.Permiso)
        For Each item As DataRow In New DAL.Login().GetRoles(pUsuario).Rows
            permisos.Add(New BLL.Permiso().GetById(item.ItemArray(0).ToString()))
        Next
        Return permisos
    End Function

    Public Function EsOperador() As Boolean
        For Each permiso As EL.Permiso In UsuarioConectado.Permisos
            If permiso.Id = "O" Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function EsResponsable() As Boolean
        For Each permiso As EL.Permiso In UsuarioConectado.Permisos
            If permiso.Id = "R" Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function EsGerente() As Boolean
        For Each permiso As EL.Permiso In UsuarioConectado.Permisos
            If permiso.Id = "G" Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function EsChofer() As Boolean
        For Each permiso As EL.Permiso In UsuarioConectado.Permisos
            If permiso.Id = "C" Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
