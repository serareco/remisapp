Public Class Usuario
    Inherits Persona : Implements IEmpleado
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

    Private _fechaNacimiento As String
    Public Property FechaNacimiento As String Implements IEmpleado.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nroDocumento As String
    Public Property NroDocumento As String Implements IEmpleado.NroDocumento
        Get
            Return _nroDocumento
        End Get
        Set(ByVal value As String)
            _nroDocumento = value
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
