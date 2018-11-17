Public Class Viaje
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _origen As String
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    Private _destino As String
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    Private _fechaSalida As DateTime
    Public Property FechaSalida() As DateTime
        Get
            Return _fechaSalida
        End Get
        Set(ByVal value As DateTime)
            _fechaSalida = value
        End Set
    End Property

    Private _fechaArribo As DateTime
    Public Property FechaArribo() As DateTime
        Get
            Return _fechaArribo
        End Get
        Set(ByVal value As DateTime)
            _fechaArribo = value
        End Set
    End Property

    Private _kmRecorridos As Int16
    Public Property KmRecorridos() As Int16
        Get
            Return _kmRecorridos
        End Get
        Set(ByVal value As Int16)
            _kmRecorridos = value
        End Set
    End Property

    Private _comentarios As String
    Public Property Comentarios() As String
        Get
            Return _comentarios
        End Get
        Set(ByVal value As String)
            _comentarios = value
        End Set
    End Property

    Private _chofer As Chofer
    Public Property Chofer() As Chofer
        Get
            Return _chofer
        End Get
        Set(ByVal value As Chofer)
            _chofer = value
        End Set
    End Property

    Private _socio As Socio
    Public Property Socio() As Socio
        Get
            Return _socio
        End Get
        Set(ByVal value As Socio)
            _socio = value
        End Set
    End Property

    Private _idaYVuelta As Boolean
    Public Property IdaYVuelta() As Boolean
        Get
            Return _idaYVuelta
        End Get
        Set(ByVal value As Boolean)
            _idaYVuelta = value
        End Set
    End Property

    Private _promociones As List(Of Promocion)
    Public Property Promociones() As List(Of Promocion)
        Get
            Return _promociones
        End Get
        Set(ByVal value As List(Of Promocion))
           _promociones = value
    End Set
    End Property

    Private _estado As EstadoViaje
    Public Property Estado() As EstadoViaje
        Get
            Return _estado
        End Get
        Set(ByVal value As EstadoViaje)
            _estado = value
        End Set
    End Property

    Private _precio As Decimal
    Public Property Precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property

End Class
