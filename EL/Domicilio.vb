Public Class Domicilio
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _calle As String
    Public Property Calle() As String
        Get
            Return _calle
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property
    Private _nro As Int16
    Public Property Nro() As Int16
        Get
            Return _nro
        End Get
        Set(ByVal value As Int16)
            _nro = value
        End Set
    End Property
    Private _piso As Int16
    Public Property Piso() As Int16
        Get
            Return _piso
        End Get
        Set(ByVal value As Int16)
            _piso = value
        End Set
    End Property
    Private _dpto As String
    Public Property Dpto() As String
        Get
            Return _dpto
        End Get
        Set(ByVal value As String)
            _dpto = value
        End Set
    End Property
    Private _cp As String
    Public Property CP() As String
        Get
            Return _cp
        End Get
        Set(ByVal value As String)
            _cp = value
        End Set
    End Property
    Private _localidad As String
    Public Property Localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property
    Private _provincia As String
    Public Property Provincia() As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property
End Class
