Public Class Persona
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property
    Private _domicilio As Domicilio
    Public Property Domicilio() As Domicilio
        Get
            Return _domicilio
        End Get
        Set(ByVal value As Domicilio)
            _domicilio = value
        End Set
    End Property
    'Private _domicilio As String
    'Public Property Domicilio() As String
    'Get
    'Return _domicilio
    'End Get
    'Set(ByVal value As String)
    '       _domicilio = value
    'End Set
    'End Property
    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Private _nroDocumento As Int64
    Public Property NroDocumento() As Int64
        Get
            Return _nroDocumento
        End Get
        Set(ByVal value As Int64)
            _nroDocumento = value
        End Set
    End Property
End Class
