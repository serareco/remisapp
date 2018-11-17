Public Class TicketComprobante
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _fechaEmision As Date
    Public Property FechaEmision() As Date
        Get
            Return _fechaEmision
        End Get
        Set(ByVal value As Date)
            _fechaEmision = value
        End Set
    End Property
    Private _total As Double
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property
    Private _viaje As Viaje
    Public Property Viaje() As Viaje
        Get
            Return _viaje
        End Get
        Set(ByVal value As Viaje)
            _viaje = value
        End Set
    End Property
End Class
