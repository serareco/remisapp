Imports BackEnd
Public Class Chofer
    Inherits Persona : Implements IEmpleado
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _comision As Decimal
    Public Property Comision() As Decimal
        Get
            Return _comision
        End Get
        Set(ByVal value As Decimal)
            _comision = value
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
    Private _auto As Auto
    Public Property Auto() As Auto
        Get
            Return _auto
        End Get
        Set(ByVal value As Auto)
            _auto = value
        End Set
    End Property

    Private _fechaNacimiento As String
    Public Property FechaNacimiento As String Implements IEmpleado.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nroDocumento As String
    Public Property NroDocumento As String Implements IEmpleado.NroDocumento
        Get
            Return _nroDocumento
        End Get
        Set(ByVal value As String)
            _nroDocumento = value
        End Set
    End Property
    Public Function Mostrar()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        select 
            c.id_chofer,	        
            p.nombre Nombre,
	        p.apellido Apellido,
	        p.telefono Teléfono,
	        c.fecha_vencimiento_registro,
	        m.descripcion Marca,
	        mo.descripcion Modelo,
	        a.Patente Patente
         from Personas p inner join choferes c on p.id_persona = c.id_persona 
	        inner join autos a on c.id_auto = a.Id_Auto
	        inner join Autos_Marcas m on a.Id_Marca = m.id_marca
	        inner join Autos_Modelos mo on a.Id_Modelo = mo.id_modelo and mo.id_marca = a.Id_Marca
         where c.estado = 'A'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarDisponibles()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_chofer,'Seleccione una opción' descripcion union         
        select c.id_chofer, p.nombre +' '+	p.apellido + ' - '+	m.descripcion  + ' '+	mo.descripcion  + ' ('+	a.Patente  + ')'
        from Personas p inner join choferes c on p.id_persona = c.id_persona 
	    inner join autos a on c.id_auto = a.Id_Auto
	    inner join Autos_Marcas m on a.Id_Marca = m.id_marca
	    inner join Autos_Modelos mo on a.Id_Modelo = mo.id_modelo and mo.id_marca = a.Id_Marca
        where c.estado = 'A'
        and not exists (select 1 from dbo.viajes v inner join tipos_estado_viaje tv on v.id_estado = tv.id_estado where v.id_chofer=c.id_chofer and tv.grupo = 'Alta')")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub GetById(pId As Int16)
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select c.id_chofer,
	        p.apellido,
	        p.nombre,
	        p.domicilio,
	        p.email,
	        p.telefono,
	        c.comision,
	        c.id_auto,
	        c.fecha_vencimiento_registro,
	        c.fecha_nacimiento,
            c.nro_documento from choferes c inner join 
            personas p on c.id_persona = p.id_persona where c.id_chofer = " & pId)
        con.adp.Fill(datatable)
        Me.Id = datatable.Rows(0).ItemArray(0).ToString()
        Me.Apellido = datatable.Rows(0).ItemArray(1).ToString()
        Me.Nombre = datatable.Rows(0).ItemArray(2).ToString()
        Me.Domicilio = datatable.Rows(0).ItemArray(3).ToString()
        Me.Email = datatable.Rows(0).ItemArray(4).ToString()
        Me.Telefono = datatable.Rows(0).ItemArray(5).ToString()
        Me.Comision = datatable.Rows(0).ItemArray(6).ToString()
        Me.Auto = New Auto
        Me.Auto.GetById(datatable.Rows(0).ItemArray(7).ToString())
        Me.FechaVencimiento = datatable.Rows(0).ItemArray(8).ToString()
        Me.FechaNacimiento = datatable.Rows(0).ItemArray(9).ToString()
        Me.NroDocumento = datatable.Rows(0).ItemArray(10).ToString()
    End Sub

    Public Sub Guardar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", Me.Id))
        parametros.Add(New SqlClient.SqlParameter("@comision", Me.Comision))
        parametros.Add(New SqlClient.SqlParameter("@fecha_vencimiento_registro", Me.FechaVencimiento))
        parametros.Add(New SqlClient.SqlParameter("@id_auto", Me.Auto.Id))
        parametros.Add(New SqlClient.SqlParameter("@nombre", Me.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", Me.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@fecha_nacimiento", Me.FechaNacimiento))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", Me.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", Me.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", Me.Email))
        parametros.Add(New SqlClient.SqlParameter("@nro_documento", Me.NroDocumento))
        con.EjecutarStoredProcedure("dbo.GuardarChofer", parametros)
    End Sub

    Public Sub Quitar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", Me.Id))
        con.EjecutarStoredProcedure("dbo.QuitarChofer", parametros)
    End Sub

End Class
