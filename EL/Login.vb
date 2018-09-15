Public Class Login
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
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _roles As List(Of Rol)
    Public Property Roles() As List(Of Rol)
        Get
            Return _roles
        End Get
        Set(ByVal value As List(Of Rol))
            _roles = value
        End Set
    End Property
End Class
