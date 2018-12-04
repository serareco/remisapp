Public Class Socio
    Public Function GetById(pId As Int16) As EL.Socio
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select s.id_persona, nro_socio, fecha_asociacion, p.nombre, p.apellido,p.email,p.telefono, p.fecha_nacimiento, p.nro_documento from dbo.Socio s inner join dbo.Persona p on s.id_persona = p.id_persona where id_socio = " & pId)
        con.adp.Fill(datatable)
        Dim socio As New EL.Socio()
        If (datatable.Rows.Count > 0) Then
            socio.Id = datatable.Rows(0).ItemArray(0).ToString()
            socio.NroSocio = datatable.Rows(0).ItemArray(1).ToString()
            socio.FechaAsociado = datatable.Rows(0).ItemArray(2).ToString()
            socio.Nombre = datatable.Rows(0).ItemArray(3).ToString()
            socio.Apellido = datatable.Rows(0).ItemArray(4).ToString()
            socio.Email = datatable.Rows(0).ItemArray(5).ToString()
            socio.Telefono = datatable.Rows(0).ItemArray(6).ToString()
            socio.FechaNacimiento = datatable.Rows(0).ItemArray(7).ToString()
            socio.NroDocumento = datatable.Rows(0).ItemArray(8).ToString()
            socio.Domicilio = New Domicilio().GetByPersonaId(socio.Id)(0)
        End If
        Return socio
    End Function

    Public Function Listar() As List(Of EL.Socio)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim socios As New List(Of EL.Socio)
        con.EjecutarConsulta("select id_socio from dbo.Socio c inner join dbo.Persona p on c.id_persona = p.id_persona")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            socios.Add(New Socio().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return socios
    End Function

    Public Sub Guardar(socio As EL.Socio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", socio.Id))
        con.EjecutarStoredProcedure("dbo.GuardarSocio", parametros)
    End Sub

    Public Sub Quitar(socio As EL.Socio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", socio.Id))
        con.EjecutarStoredProcedure("dbo.QuitarCliente", parametros)
    End Sub

End Class
