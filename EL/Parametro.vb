Public Class Parametro
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _clave As String
    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Private _valor As String
    Public Property Valor() As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
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
    Public Overrides Function ToString() As String
        Return Clave.ToString() + "% - " + Valor
    End Function

End Class
