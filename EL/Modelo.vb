Public Class Modelo
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
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Private _marca As Marca
    Public Property Marca() As Marca
        Get
            Return _marca
        End Get
        Set(ByVal value As Marca)
            _marca = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Marca.Descripcion + " - " + Descripcion
    End Function
End Class
