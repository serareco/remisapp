Public Class Persona

    Public Function GetById(pId As Int16) As EL.Persona
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim persona As New EL.Persona()
        con.EjecutarConsulta("select *
            from dbo.Persona p 
            where p.id_persona = " & pId)
        con.adp.Fill(datatable)

        persona.Id = datatable.Rows(0).ItemArray(0).ToString()
        persona.Nombre = datatable.Rows(0).ItemArray(1).ToString()
        persona.Apellido = datatable.Rows(0).ItemArray(2).ToString()
        persona.Telefono = datatable.Rows(0).ItemArray(3).ToString()
        persona.Email = datatable.Rows(0).ItemArray(4).ToString()
        persona.NroDocumento = datatable.Rows(0).ItemArray(6).ToString()
        persona.FechaNacimiento = datatable.Rows(0).ItemArray(7).ToString()

        If New Domicilio().GetByPersonaId(persona.Id).Count > 0 Then
            persona.Domicilio = New Domicilio().GetByPersonaId(persona.Id)(0)
        End If

        Return persona
    End Function


    Public Sub Guardar(ByRef persona As EL.Persona)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        Dim pRespuesta As New SqlClient.SqlParameter("@id_persona", SqlDbType.Int)

        parametros.Add(New SqlClient.SqlParameter("@fecha_nacimiento", persona.FechaNacimiento))
        parametros.Add(New SqlClient.SqlParameter("@nro_documento", persona.NroDocumento))
        parametros.Add(New SqlClient.SqlParameter("@nombre", persona.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", persona.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@calle", persona.Domicilio.Calle))
        parametros.Add(New SqlClient.SqlParameter("@numero", persona.Domicilio.Nro))
        parametros.Add(New SqlClient.SqlParameter("@dpto", persona.Domicilio.Dpto))
        parametros.Add(New SqlClient.SqlParameter("@piso", persona.Domicilio.Piso))
        parametros.Add(New SqlClient.SqlParameter("@cp", persona.Domicilio.CP))
        parametros.Add(New SqlClient.SqlParameter("@localidad", persona.Domicilio.Localidad))
        parametros.Add(New SqlClient.SqlParameter("@provincia", persona.Domicilio.Provincia))
        parametros.Add(New SqlClient.SqlParameter("@telefono", persona.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", persona.Email))
        If persona.Id = 0 Then
            pRespuesta.Direction = ParameterDirection.Output
        Else
            pRespuesta.Value = persona.Id
        End If
        parametros.Add(pRespuesta)
        con.EjecutarStoredProcedure("dbo.GuardarPersona", parametros)
        If persona.Id = 0 Then
            persona.Id = pRespuesta.Value
        End If
    End Sub
End Class
