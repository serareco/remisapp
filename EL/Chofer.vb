Public Class Chofer
    Inherits Usuario
    Private _comision As Comision
    Public Property Comision() As Comision
        Get
            Return _comision
        End Get
        Set(ByVal value As Comision)
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
    Private _turnos As List(Of Turno)
    Public Property Turnos() As List(Of Turno)
        Get
            Return _turnos
        End Get
        Set(ByVal value As List(Of Turno))
            _turnos = value
        End Set
    End Property
    Private _registro As Registro
    Public Property Registro() As Registro
        Get
            Return _registro
        End Get
        Set(ByVal value As Registro)
            _registro = value
        End Set
    End Property
End Class
