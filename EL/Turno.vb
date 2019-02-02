Public Class Turno
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _horaEntrada As String
    Public Property HoraEntrada() As String
        Get
            Return _horaEntrada
        End Get
        Set(ByVal value As String)
            _horaEntrada = value
        End Set
    End Property

    Private _horaSalida As String
    Public Property HoraSalida() As String
        Get
            Return _horaSalida
        End Get
        Set(ByVal value As String)
            _horaSalida = value
        End Set
    End Property
End Class
