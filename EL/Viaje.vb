Public Class Viaje
    Public Sub New()
        Estado = New EstadoViaje()
        ChoferEstimado = New Chofer()
        ' Chofer = New Chofer()
        Socio = New Socio()
    End Sub

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

    Private _fechaSalidaEstimada As DateTime
    Public Property FechaSalidaEstimada() As DateTime
        Get
            Return _fechaSalidaEstimada
        End Get
        Set(ByVal value As DateTime)
            _fechaSalidaEstimada = value
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

    Private _fechaArriboEstimado As DateTime
    Public Property FechaArriboEstimado() As DateTime
        Get
            Return _fechaArriboEstimado
        End Get
        Set(ByVal value As DateTime)
            _fechaArriboEstimado = value
        End Set
    End Property

    Private _kmRecorridos As Decimal
    Public Property KmRecorridos() As Decimal
        Get
            Return _kmRecorridos
        End Get
        Set(ByVal value As Decimal)
            _kmRecorridos = value
        End Set
    End Property

    Private _kmEstimados As Decimal
    Public Property KmEstimados() As Decimal
        Get
            Return _kmEstimados
        End Get
        Set(ByVal value As Decimal)
            _kmEstimados = value
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

    Private _choferEstimado As Chofer
    Public Property ChoferEstimado() As Chofer
        Get
            Return _choferEstimado
        End Get
        Set(ByVal value As Chofer)
            _choferEstimado = value
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

    Private _beneficios As List(Of Beneficio)
    Public Property Beneficios() As List(Of Beneficio)
        Get
            Return _beneficios
        End Get
        Set(ByVal value As List(Of Beneficio))
            _beneficios = value
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

    Private _precioEstimado As Decimal
    Public Property PrecioEstimado() As Decimal
        Get
            Return _precioEstimado
        End Get
        Set(ByVal value As Decimal)
            _precioEstimado = value
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

    Private _ahorro As Decimal
    Public Property Ahorro() As Decimal
        Get
            Return _ahorro
        End Get
        Set(ByVal value As Decimal)
            _ahorro = value
        End Set
    End Property

    Private _duracionEstimada As Integer
    Public Property DuracionEstimada() As Integer
        Get
            Return _duracionEstimada
        End Get
        Set(ByVal value As Integer)
            _duracionEstimada = value
        End Set
    End Property

    Private _duracion As Integer
    Public Property Duracion() As Integer
        Get
            Return _duracion
        End Get
        Set(ByVal value As Integer)
            _duracion = value
        End Set
    End Property
End Class
