Public Class Cliente
    Public Function GetById(pId As Int16) As EL.Cliente
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select id_cliente, nro_cliente, p.nombre, p.apellido,p.domicilio,p.email,p.telefono from clientes c inner join Personas p on c.id_persona = p.id_persona where id_cliente = " & pId)
        con.adp.Fill(datatable)
        Dim cliente As New EL.Cliente()
        If (datatable.Rows.Count > 0) Then
            cliente.Id = datatable.Rows(0).ItemArray(0).ToString()
            cliente.NroCliente = datatable.Rows(0).ItemArray(1).ToString()
            cliente.Nombre = datatable.Rows(0).ItemArray(2).ToString()
            cliente.Apellido = datatable.Rows(0).ItemArray(3).ToString()
            cliente.Domicilio = datatable.Rows(0).ItemArray(4).ToString()
            cliente.Email = datatable.Rows(0).ItemArray(5).ToString()
            cliente.Telefono = datatable.Rows(0).ItemArray(6).ToString()
        End If
        Return cliente
    End Function

    Public Function Listar() As List(Of EL.Cliente)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim clientes As New List(Of EL.Cliente)
        con.EjecutarConsulta("select id_cliente from Clientes c inner join Personas p on c.id_persona = p.id_persona")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            clientes.Add(New Cliente().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return clientes
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
