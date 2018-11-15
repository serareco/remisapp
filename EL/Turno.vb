Public Class Turno
    Private _dia As String
    Public Property Dia() As String
        Get
            Return _dia
        End Get
        Set(ByVal value As String)
            _dia = value
        End Set
    End Property

    Private _horaEntrada As Int16
    Public Property HoraEntrada() As Int16
        Get
            Return _horaEntrada
        End Get
        Set(ByVal value As Int16)
            _horaEntrada = value
        End Set
    End Property

    Private _horaSalida As Int16
    Public Property HoraSalida() As Int16
        Get
            Return _horaSalida
        End Get
        Set(ByVal value As Int16)
            _horaSalida = value
        End Set
    End Property
End Class
