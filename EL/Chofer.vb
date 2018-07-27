Public Class Chofer
    Inherits Persona : Implements IEmpleado
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _comision As Decimal
    Public Property Comision() As Decimal
        Get
            Return _comision
        End Get
        Set(ByVal value As Decimal)
            _comision = value
        End Set
    End Property
    Private _fechaVencimiento As Date
    Public Property FechaVencimiento() As Date
        Get
            Return _fechaVencimiento
        End Get
        Set(ByVal value As Date)
            _fechaVencimiento = value
        End Set
    End Property
    Private _auto As Auto
    Public Property Auto() As Auto
        Get
            Return _auto
        End Get
        Set(ByVal value As Auto)
            _auto = value
        End Set
    End Property

    Private _fechaNacimiento As String
    Public Property FechaNacimiento As String Implements IEmpleado.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nroDocumento As String
    Public Property NroDocumento As String Implements IEmpleado.NroDocumento
        Get
            Return _nroDocumento
        End Get
        Set(ByVal value As String)
            _nroDocumento = value
        End Set
    End Property
End Class
