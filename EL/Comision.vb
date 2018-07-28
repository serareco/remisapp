Public Class Comision
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _porcentaje As Decimal
    Public Property Porcentaje() As Decimal
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Decimal)
            _porcentaje = value
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

End Class
