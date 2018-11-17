Public Class Registro
    Private _categoria As String
    Public Property Categoria() As String
        Get
            Return _categoria
        End Get
        Set(ByVal value As String)
            _categoria = value
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
End Class
