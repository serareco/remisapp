Public Class Persona
    Public Function GetById(pId As Int16) As EL.Persona
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim persona As New EL.Persona()
        Dim domicilioService As New Domicilio()
        Dim telefonoService As New Telefono()
        con.EjecutarConsulta("select * from dbo.Persona p where p.id_persona = " & pId)
        con.adp.Fill(datatable)
        persona.Id = datatable.Rows(0).ItemArray(0).ToString()
        persona.Nombre = datatable.Rows(0).ItemArray(1).ToString()
        persona.Apellido = datatable.Rows(0).ItemArray(2).ToString()
        Try
            telefonoService.GetByPersonaId(persona.Id, persona.Telefono)
        Catch ex As Exception
            persona.Telefono = Nothing
        End Try

        persona.Email = datatable.Rows(0).ItemArray(3).ToString()
        persona.NroDocumento = datatable.Rows(0).ItemArray(5).ToString()
        Try
            persona.FechaNacimiento = datatable.Rows(0).ItemArray(6).ToString()
        Catch ex As Exception
            persona.FechaNacimiento = Nothing
        End Try
        Try
            persona.Domicilio = domicilioService.GetByPersonaId(persona.Id)(0)
            domicilioService.GetByPersonaId(persona.Id, persona.Domicilio)
        Catch ex As Exception
            persona.Domicilio = Nothing
        End Try

        Return persona
    End Function

    Public Sub Guardar(ByRef persona As EL.Persona, usuarioConectado As EL.Usuario)
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
        parametros.Add(New SqlClient.SqlParameter("@cod_pais", persona.Telefono.CodigoPais))
        parametros.Add(New SqlClient.SqlParameter("@cod_area", persona.Telefono.CodigoArea))
        parametros.Add(New SqlClient.SqlParameter("@nro_telefono", persona.Telefono.Numero))
        parametros.Add(New SqlClient.SqlParameter("@id_tipo_telefono", persona.Telefono.TipoTelefono.Id))
        parametros.Add(New SqlClient.SqlParameter("@email", persona.Email))
        If persona.Id = 0 Then
            pRespuesta.Direction = ParameterDirection.Output
        Else
            pRespuesta.Value = persona.Id
        End If
        parametros.Add(pRespuesta)
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.GuardarPersona", parametros)
        If persona.Id = 0 Then
            persona.Id = pRespuesta.Value
        End If
    End Sub
End Class
