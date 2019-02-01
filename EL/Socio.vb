Imports EL

Public Class Socio
    Inherits Persona
    Public Sub New()
    End Sub

    Public Sub New(pPersona As Persona)
        Id = pPersona.Id
        Nombre = pPersona.Nombre
        Apellido = pPersona.Apellido
        Domicilio = pPersona.Domicilio
        Email = pPersona.Email
        Telefono = pPersona.Telefono
        NroDocumento = pPersona.NroDocumento
        FechaNacimiento = pPersona.FechaNacimiento
    End Sub
    Private _nroSocio As String
    Public Property NroSocio() As String
        Get
            Return _nroSocio
        End Get
        Set(ByVal value As String)
            _nroSocio = value
        End Set
    End Property
    Private _activo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
    Private _fechaAsociado As Date
    Public Property FechaAsociado() As Date
        Get
            Return _fechaAsociado
        End Get
        Set(ByVal value As Date)
            _fechaAsociado = value
        End Set
    End Property
End Class
