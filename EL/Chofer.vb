Public Class Chofer
    Inherits Usuario
    Public Sub New()
        Me.Registro = New Registro()
    End Sub
    Public Sub New(usuarioBase As Usuario)
        Me.Registro = New Registro()
        Me.Turnos = New List(Of Turno)()
        Id = usuarioBase.Id
        Usuario = usuarioBase.Usuario
        Password = usuarioBase.Password
        Permisos = usuarioBase.Permisos
        Nombre = usuarioBase.Nombre
        NroDocumento = usuarioBase.NroDocumento
        FechaNacimiento = usuarioBase.FechaNacimiento
        Apellido = usuarioBase.Apellido
        Email = usuarioBase.Email
        Telefono = usuarioBase.Telefono
        Domicilio = usuarioBase.Domicilio
    End Sub
    Private _comision As Comision
    Public Property Comision() As Comision
        Get
            Return _comision
        End Get
        Set(ByVal value As Comision)
            _comision = value
        End Set
    End Property
    Private _auto As Vehiculo
    Public Property Auto() As Vehiculo
        Get
            Return _auto
        End Get
        Set(ByVal value As Vehiculo)
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
    Private _acciones As List(Of EL.Accion)
    Public Property Acciones() As List(Of EL.Accion)
        Get
            Return _acciones
        End Get
        Set(ByVal value As List(Of EL.Accion))
            _acciones = value
        End Set
    End Property

End Class
