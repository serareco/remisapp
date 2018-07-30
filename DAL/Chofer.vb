Imports EL
Public Class Chofer
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

    Public Function MostrarDisponibles() As DataTable
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

    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select c.id_chofer,
	        p.apellido,
	        p.nombre,
	        p.domicilio,
	        p.email,
	        p.telefono,
	        c.id_comision,
	        c.id_auto,
	        c.fecha_vencimiento_registro,
	        c.fecha_nacimiento,
            c.nro_documento from choferes c inner join 
            personas p on c.id_persona = p.id_persona where c.id_chofer = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(chofer As EL.Chofer)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", chofer.Id))
        parametros.Add(New SqlClient.SqlParameter("@id_comision", chofer.Comision.Id))
        parametros.Add(New SqlClient.SqlParameter("@fecha_vencimiento_registro", chofer.FechaVencimiento))
        parametros.Add(New SqlClient.SqlParameter("@id_auto", chofer.Auto.Id))
        parametros.Add(New SqlClient.SqlParameter("@nombre", chofer.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", chofer.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@fecha_nacimiento", chofer.FechaNacimiento))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", chofer.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", chofer.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", chofer.Email))
        parametros.Add(New SqlClient.SqlParameter("@nro_documento", chofer.NroDocumento))
        con.EjecutarStoredProcedure("dbo.GuardarChofer", parametros)
    End Sub

    Public Sub Quitar(chofer As EL.Chofer)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", chofer.Id))
        con.EjecutarStoredProcedure("dbo.QuitarChofer", parametros)
    End Sub

End Class
