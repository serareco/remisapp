Public Class Beneficio
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _descuento As Decimal
    Public Property Descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property

    Private _vigenciaDesde As Date
    Public Property VigenciaDesde() As Date
        Get
            Return _vigenciaDesde
        End Get
        Set(ByVal value As Date)
            _vigenciaDesde = value
        End Set
    End Property

    Private _vigenciaHasta As Date
    Public Property VigenciaHasta() As Date
        Get
            Return _vigenciaHasta
        End Get
        Set(ByVal value As Date)
            _vigenciaHasta = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _totalAcumulado As Double
    Public Property TotalAcumulado() As Double
        Get
            Return _totalAcumulado
        End Get
        Set(ByVal value As Double)
            _totalAcumulado = value
        End Set
    End Property

    Private _cantidadViajes As Int16
    Public Property CantidadViajes() As Int16
        Get
            Return _cantidadViajes
        End Get
        Set(ByVal value As Int16)
            _cantidadViajes = value
        End Set
    End Property
End Class
