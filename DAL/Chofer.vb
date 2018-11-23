Imports EL
Public Class Chofer
    Public Function Listar() As List(Of EL.Chofer)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim choferes As New List(Of EL.Chofer)
        con.EjecutarConsulta("
        select c.id_persona
         from dbo.Chofer c
         where c.estado = 'A'")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            choferes.Add(New Chofer().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return choferes
    End Function

    Public Function GetById(pId As Int16) As EL.Chofer
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim chofer As New EL.Chofer()
        con.EjecutarConsulta("select c.id_persona,
	        p.apellido,
	        p.nombre,
	        p.email,
	        p.telefono,
	        c.id_comision,
	        c.id_vehiculo,
	        p.fecha_nacimiento,
            p.nro_documento,
            u.usuario,
            u.password
            from dbo.Chofer c inner join 
            dbo.Persona p on c.id_persona = p.id_persona
            inner join dbo.Usuario u on u.id_persona = p.id_persona
            where c.id_persona = " & pId)
        con.adp.Fill(datatable)

        chofer.Id = datatable.Rows(0).ItemArray(0).ToString()
        chofer.Apellido = datatable.Rows(0).ItemArray(1).ToString()
        chofer.Nombre = datatable.Rows(0).ItemArray(2).ToString()
        chofer.Email = datatable.Rows(0).ItemArray(3).ToString()
        chofer.Telefono = datatable.Rows(0).ItemArray(4).ToString()
        chofer.Comision = New Comision().GetById(datatable.Rows(0).ItemArray(5).ToString())
        chofer.Auto = New Vehiculo().GetById(datatable.Rows(0).ItemArray(6).ToString())
        chofer.Domicilio = New Domicilio().GetByPersonaId(chofer.Id)(0)
        chofer.Registro = New Registro().GetById(chofer.Id)
        chofer.FechaNacimiento = datatable.Rows(0).ItemArray(7).ToString()
        chofer.NroDocumento = datatable.Rows(0).ItemArray(8).ToString()
        chofer.Usuario = datatable.Rows(0).ItemArray(9).ToString()
        chofer.Password = datatable.Rows(0).ItemArray(10).ToString()
        Return chofer
    End Function

    Public Sub Guardar(chofer As EL.Chofer)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", chofer.Id))
        parametros.Add(New SqlClient.SqlParameter("@id_comision", chofer.Comision.Id))
        parametros.Add(New SqlClient.SqlParameter("@fecha_vencimiento_registro", chofer.Registro.FechaVencimiento))
        parametros.Add(New SqlClient.SqlParameter("@categoria_registro", chofer.Registro.Categoria))
        parametros.Add(New SqlClient.SqlParameter("@id_vehiculo", chofer.Auto.Id))
        con.EjecutarStoredProcedure("dbo.GuardarChofer", parametros)
    End Sub

    Public Sub Quitar(chofer As EL.Chofer)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", chofer.Id))
        con.EjecutarStoredProcedure("dbo.QuitarChofer", parametros)
    End Sub

End Class
