Public Class Viaje
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _origen As String
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    Private _destino As String
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    Private _fechaSalida As DateTime
    Public Property FechaSalida() As DateTime
        Get
            Return _fechaSalida
        End Get
        Set(ByVal value As DateTime)
            _fechaSalida = value
        End Set
    End Property

    Private _fechaArribo As DateTime
    Public Property FechaArribo() As DateTime
        Get
            Return _fechaArribo
        End Get
        Set(ByVal value As DateTime)
            _fechaArribo = value
        End Set
    End Property

    Private _kmRecorridos As Int16
    Public Property KmRecorridos() As Int16
        Get
            Return _kmRecorridos
        End Get
        Set(ByVal value As Int16)
            _kmRecorridos = value
        End Set
    End Property

    Private _comentarios As String
    Public Property Comentarios() As String
        Get
            Return _comentarios
        End Get
        Set(ByVal value As String)
            _comentarios = value
        End Set
    End Property

    Private _chofer As Chofer
    Public Property Chofer() As Chofer
        Get
            Return _chofer
        End Get
        Set(ByVal value As Chofer)
            _chofer = value
        End Set
    End Property

    Private _cliente As Cliente
    Public Property Cliente() As Cliente
        Get
            Return _cliente
        End Get
        Set(ByVal value As Cliente)
            _cliente = value
        End Set
    End Property

    Private _idaYVuelta As Boolean
    Public Property IdaYVuelta() As Boolean
        Get
            Return _idaYVuelta
        End Get
        Set(ByVal value As Boolean)
            _idaYVuelta = value
        End Set
    End Property

    Private _promociones As List(Of Promocion)
    Public Property Promociones() As List(Of Promocion)
        Get
            Return _promociones
        End Get
        Set(ByVal value As List(Of Promocion))
            _promociones = value
        End Set
    End Property

    Private _estado As EstadoViaje
    Public Property Estado() As EstadoViaje
        Get
            Return _estado
        End Get
        Set(ByVal value As EstadoViaje)
            _estado = value
        End Set
    End Property

    Private _precio As Decimal
    Public Property Precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property

    Public Function MostrarEnCurso()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta(" 
        select id_viaje,
                origen,
                destino,
                fecha_salida,
                ida_vuelta,
                p.apellido,
                p.nombre,
                p.telefono,
                ama.descripcion,
                am.descripcion,
                a.patente,
                te.descripcion
        from Viajes v	inner join Choferes c on v.id_chofer = c.id_chofer 
				        inner join Personas p on p.id_persona = c.id_persona
				        inner join Autos a on a.id_Auto = c.id_auto
				        inner join Autos_Modelos am on am.id_modelo = a.id_Modelo
				        inner join Autos_Marcas ama	on ama.id_marca = a.id_Marca
				        inner join Tipos_Estado_Viaje te on v.id_estado = te.id_estado
        where te.grupo = 'Alta' ")

        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarHistorico()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta(" 
        select id_viaje,
                origen,
                destino,
                fecha_salida,
                ida_vuelta,
                p.apellido,
                p.nombre,
                p.telefono,
                ama.descripcion,
                am.descripcion,
                a.patente,
                te.descripcion
        from Viajes v	inner join Choferes c on v.id_chofer = c.id_chofer 
				        inner join Personas p on p.id_persona = c.id_persona
				        inner join Autos a on a.id_Auto = c.id_auto
				        inner join Autos_Modelos am on am.id_modelo = a.id_Modelo
				        inner join Autos_Marcas ama	on ama.id_marca = a.id_Marca
				        inner join Tipos_Estado_Viaje te on v.id_estado = te.id_estado")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub GetById(pId As Int16)
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from viajes v where id_viaje = " & pId)
        con.adp.Fill(datatable)
        If (datatable.Rows.Count > 0) Then
            Me.Id = datatable.Rows(0).ItemArray(0).ToString()
            Me.Origen = datatable.Rows(0).ItemArray(1).ToString()
            Me.Destino = datatable.Rows(0).ItemArray(2).ToString()
            Me.FechaSalida = datatable.Rows(0).ItemArray(3).ToString()
            If (datatable.Rows(0).ItemArray(4).ToString() <> "") Then
                Me.FechaArribo = datatable.Rows(0).ItemArray(4).ToString()
            End If
            If (datatable.Rows(0).ItemArray(5).ToString() <> "") Then
                Me.KmRecorridos = datatable.Rows(0).ItemArray(5).ToString()
            End If
            Me.Comentarios = datatable.Rows(0).ItemArray(6).ToString()
            If (datatable.Rows(0).ItemArray(7).ToString() <> "") Then
                Me.Cliente = New Cliente()
                Me.Cliente.GetById(datatable.Rows(0).ItemArray(7).ToString())
            End If
            If (datatable.Rows(0).ItemArray(8).ToString() = "S") Then
                Me.IdaYVuelta = True
            Else
                Me.IdaYVuelta = False
            End If
            If (datatable.Rows(0).ItemArray(9).ToString() <> "") Then
                Me.Chofer = New Chofer()
                Me.Chofer.GetById(datatable.Rows(0).ItemArray(9).ToString())
            End If
            Me.Estado = New EstadoViaje()
            Me.Estado.GetById(datatable.Rows(0).ItemArray(10).ToString())
            If (datatable.Rows(0).ItemArray(11).ToString() <> "") Then
                Me.Precio = datatable.Rows(0).ItemArray(11).ToString()
            End If
        End If
    End Sub

    Public Sub Guardar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        If (Me.Id > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@id_viaje", Me.Id))
        End If
        parametros.Add(New SqlClient.SqlParameter("@origen", Me.Origen))
        parametros.Add(New SqlClient.SqlParameter("@destino", Me.Destino))
        parametros.Add(New SqlClient.SqlParameter("@fechaSalida", Me.FechaSalida))
        If (Me.FechaArribo <> DateTime.MinValue) Then
            parametros.Add(New SqlClient.SqlParameter("@fechaArribo", Me.FechaArribo))
        End If
        If Me.KmRecorridos > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@kmRecorridos", Me.KmRecorridos))
        End If
        If Me.Precio > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@precio", Me.Precio))
        End If
        parametros.Add(New SqlClient.SqlParameter("@comentarios", Me.Comentarios))
        If (Me.Cliente.Id > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@id_cliente", Me.Cliente.Id))
        End If
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", Me.Chofer.Id))
        Dim _idaYVuelta As String
        If (Me.IdaYVuelta) Then
            _idaYVuelta = "S"
        Else
            _idaYVuelta = "N"
        End If
        parametros.Add(New SqlClient.SqlParameter("@ida_Vuelta", _idaYVuelta))
        parametros.Add(New SqlClient.SqlParameter("@id_estado", Me.Estado.Id))
        con.EjecutarStoredProcedure("dbo.GuardarViaje", parametros)
    End Sub

End Class
