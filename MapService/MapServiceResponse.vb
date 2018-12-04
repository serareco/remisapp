Public Class MapServiceResponse
    Private _requestId As Int64
    Public Property RequestID() As Int64
        Get
            Return _requestId
        End Get
        Set(ByVal value As Int64)
            _requestId = value
        End Set
    End Property

    Private _from As String
    Public Property From() As String
        Get
            Return _from
        End Get
        Set(ByVal value As String)
            _from = value
        End Set
    End Property

    Private _dest As String
    Public Property Dest() As String
        Get
            Return _dest
        End Get
        Set(ByVal value As String)
            _dest = value
        End Set
    End Property

    Private _distance As Decimal
    Public Property Distance() As Decimal
        Get
            Return _distance
        End Get
        Set(ByVal value As Decimal)
            _distance = value
        End Set
    End Property

    Private _time As Decimal
    Public Property Time() As Decimal
        Get
            Return _time
        End Get
        Set(ByVal value As Decimal)
            _time = value
        End Set
    End Property

    Public Function GetResponse() As MapServiceResponse
        Me.Distance = Math.Ceiling(Rnd() * 150)
        Me.Time = Math.Ceiling(Rnd() * 120)
        Return Me
    End Function

End Class
