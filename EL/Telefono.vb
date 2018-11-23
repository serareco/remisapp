Public Class Telefono
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _codigoPais As String
    Public Property CodigoPais() As String
        Get
            Return _codigoPais
        End Get
        Set(ByVal value As String)
            _codigoPais = value
        End Set
    End Property
    Private _codigoArea As String
    Public Property CodigoArea() As String
        Get
            Return _codigoArea
        End Get
        Set(ByVal value As String)
            _codigoArea = value
        End Set
    End Property
    Private _numero As String
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property
    Private _tipoTelefono As Int16
    Public Property TipoTelefono() As Int16
        Get
            Return _tipoTelefono
        End Get
        Set(ByVal value As Int16)
            _tipoTelefono = value
        End Set
    End Property
End Class
