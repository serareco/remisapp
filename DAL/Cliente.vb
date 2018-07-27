Public Class Cliente
    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select id_cliente, nro_cliente, p.nombre, p.apellido,p.domicilio,p.email,p.telefono from clientes c inner join Personas p on c.id_persona = p.id_persona where id_cliente = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function Mostrar()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_cliente,'Seleccione una opción' descripcion union         
        select id_cliente, p.apellido + ' ' + p.nombre + ' ('+ convert(varchar(18),c.nro_cliente)+')'from Clientes c inner join Personas p on c.id_persona = p.id_persona")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarLista()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("     
        select id_cliente, p.apellido, p.nombre, c.nro_cliente, p.telefono, p.domicilio
        from Clientes c inner join Personas p on c.id_persona = p.id_persona
        where c.estado = 'A' ")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(cliente As EL.Cliente)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", cliente.Id))
        parametros.Add(New SqlClient.SqlParameter("@nombre", cliente.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", cliente.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", cliente.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", cliente.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", cliente.Email))
        con.EjecutarStoredProcedure("dbo.GuardarCliente", parametros)
    End Sub

    Public Sub Quitar(cliente As EL.Cliente)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", cliente.Id))
        con.EjecutarStoredProcedure("dbo.QuitarCliente", parametros)
    End Sub

End Class
