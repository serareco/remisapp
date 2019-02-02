Public Class Vehiculo
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _modelo As Modelo
    Public Property Modelo() As Modelo
        Get
            Return _modelo
        End Get
        Set(ByVal value As Modelo)
            _modelo = value
        End Set
    End Property
    Private _anioFabricacion As Int16
    Public Property AnioFabricacion() As Int16
        Get
            Return _anioFabricacion
        End Get
        Set(ByVal value As Int16)
            _anioFabricacion = value
        End Set
    End Property
    Private _patente As String
    Public Property Patente() As String
        Get
            Return _patente
        End Get
        Set(ByVal value As String)
            _patente = value
        End Set
    End Property
    Private _chasis As String
    Public Property Chasis() As String
        Get
            Return _chasis
        End Get
        Set(ByVal value As String)
            _chasis = value
        End Set
    End Property
    Private _motor As String
    Public Property Motor() As String
        Get
            Return _motor
        End Get
        Set(ByVal value As String)
            _motor = value
        End Set
    End Property
    Private _fechaVencimientoVTV As Date
    Public Property FechaVencimientoVTV() As Date
        Get
            Return _fechaVencimientoVTV
        End Get
        Set(ByVal value As Date)
            _fechaVencimientoVTV = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Patente + " - " + Modelo.Descripcion + " " + Modelo.Marca.Descripcion
    End Function
End Class
