Public Module Login
    Private _usuarioConectado As EL.Usuario
    Public Property UsuarioConectado() As EL.Usuario
        Get
            Return _usuarioConectado
        End Get
        Set(ByVal value As EL.Usuario)
            _usuarioConectado = value
        End Set
    End Property

    Public Function GetInforamcionUsuario() As String
        Return "Usuario: " + UsuarioConectado.Usuario + " - " + UsuarioConectado.Apellido + ", " + UsuarioConectado.Nombre
    End Function

    Public Function Login(pUsuarioLogin As EL.Usuario) As Boolean
        Dim resultLogin As Boolean = New DAL.Login().Login(pUsuarioLogin)
        If resultLogin Then
            UsuarioConectado = New Usuario().GetByUsuario(pUsuarioLogin.Usuario)
        End If
        Return resultLogin

    End Function

    Public Function GetPermisos(pUsuario As String) As List(Of EL.Permiso)
        Dim permisos As New List(Of EL.Permiso)
        For Each item As DataRow In New DAL.Login().GetPermisos(pUsuario).Rows
            permisos.Add(New BLL.Permiso().GetById(item.ItemArray(0).ToString()))
        Next
        Return permisos
    End Function

    Private Sub GetPermisos()
        UsuarioConectado.Permisos = New List(Of EL.Permiso)
        For Each item As DataRow In New DAL.Login().GetPermisos(UsuarioConectado.Usuario).Rows
            UsuarioConectado.Permisos.Add(New BLL.Permiso().GetById(item.ItemArray(0).ToString()))
        Next
    End Sub

    Public Function EsAdministrador() As Boolean
        For Each permiso As EL.Permiso In UsuarioConectado.Permisos
            If permiso.Id = "A" Then
                Return True
            End If
        Next
        Return False
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
