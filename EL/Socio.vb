Public Class Socio
    Inherits Persona
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
