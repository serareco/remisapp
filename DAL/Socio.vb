Public Class Socio
    Public Function GetById(pId As Int16) As EL.Socio
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select id_cliente, nro_cliente, p.nombre, p.apellido,p.domicilio,p.email,p.telefono from clientes c inner join Personas p on c.id_persona = p.id_persona where id_cliente = " & pId)
        con.adp.Fill(datatable)
        Dim socio As New EL.Socio()
        If (datatable.Rows.Count > 0) Then
            socio.Id = datatable.Rows(0).ItemArray(0).ToString()
            socio.NroSocio = datatable.Rows(0).ItemArray(1).ToString()
            socio.Nombre = datatable.Rows(0).ItemArray(2).ToString()
            socio.Apellido = datatable.Rows(0).ItemArray(3).ToString()
            'socio.Domicilio = datatable.Rows(0).ItemArray(4).ToString() TODO: GET BY ID DOMICILIO
            socio.Email = datatable.Rows(0).ItemArray(5).ToString()
            socio.Telefono = datatable.Rows(0).ItemArray(6).ToString()
        End If
        Return socio
    End Function

    Public Function Listar() As List(Of EL.Socio)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim socios As New List(Of EL.Socio)
        con.EjecutarConsulta("select id_cliente from Clientes c inner join Personas p on c.id_persona = p.id_persona")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            socios.Add(New Socio().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return socios
    End Function

    Public Sub Guardar(socio As EL.Socio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", socio.Id))
        parametros.Add(New SqlClient.SqlParameter("@nombre", socio.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", socio.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", socio.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", socio.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", socio.Email))
        con.EjecutarStoredProcedure("dbo.GuardarCliente", parametros)
    End Sub

    Public Sub Quitar(socio As EL.Socio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", socio.Id))
        con.EjecutarStoredProcedure("dbo.QuitarCliente", parametros)
    End Sub

End Class
