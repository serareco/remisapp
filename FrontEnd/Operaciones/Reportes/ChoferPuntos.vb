Public Class ChoferPuntos
    Private _apellidoNombreChofer As String
    Public Property ApellidoNombreChofer() As String
        Get
            Return _apellidoNombreChofer
        End Get
        Set(ByVal value As String)
            _apellidoNombreChofer = value
        End Set
    End Property

    Private _nroDocumento As String
    Public Property NroDocumento() As String
        Get
            Return _nroDocumento
        End Get
        Set(ByVal value As String)
            _nroDocumento = value
        End Set
    End Property

    Private _fechaAccion As Date
    Public Property FechaAccion() As Date
        Get
            Return _fechaAccion
        End Get
        Set(ByVal value As Date)
            _fechaAccion = value
        End Set
    End Property

    Private _accion As String
    Public Property Accion() As String
        Get
            Return _accion
        End Get
        Set(ByVal value As String)
            _accion = value
        End Set
    End Property

    Private _puntos As String
    Public Property Puntos() As String
        Get
            Return _puntos
        End Get
        Set(ByVal value As String)
            _puntos = value
        End Set
    End Property

    Public Function Consultar(pIdChofer As Int32, pFechaDesde As Date, pFechaHasta As Date, pActivo As Boolean, pVigente As Boolean, pAcciones As String) As List(Of ChoferPuntos)
        Dim choferService As New BLL.Chofer()
        Dim chofer As New EL.Chofer()
        Dim resultado As New List(Of ChoferPuntos)

        chofer = choferService.GetAcciones(pIdChofer, pFechaDesde, pFechaHasta, pActivo, pVigente, pAcciones)

        For Each accion As EL.Accion In chofer.Acciones
            Dim pRegistro As New ChoferPuntos()
            pRegistro.ApellidoNombreChofer = chofer.Apellido + ", " + chofer.Nombre
            pRegistro.NroDocumento = chofer.NroDocumento
            pRegistro.Accion = accion.Descripcion
            pRegistro.Puntos = accion.Puntos
            'TODO FECHA DE LA ACCION
            resultado.Add(pRegistro)
        Next

        Return resultado
    End Function

End Class
