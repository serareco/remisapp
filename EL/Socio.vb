Public Class Socio
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
    Private _nroSocio As String
    Public Property NroSocio() As String
        Get
            Return _nroSocio
        End Get
        Set(ByVal value As String)
            _nroSocio = value
        End Set
    End Property
End Class
