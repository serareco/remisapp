Public Class Cliente
    Inherits Persona
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _nroCliente As String
    Public Property NroCliente() As String
        Get
            Return _nroCliente
        End Get
        Set(ByVal value As String)
            _nroCliente = value
        End Set
    End Property

End Class
