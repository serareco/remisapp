Public Class MapServiceRequest
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

    Public Sub MapServiceRequest()
    End Sub

    Public Function SendRequest() As MapServiceResponse
        Return New MapServiceResponse() With {
        .Dest = Me.Dest,
        .From = Me.From
        }.GetResponse()

    End Function

End Class
