Public Class Viaje
    Public Function MostrarEnCurso() As DataTable
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

    Public Function MostrarHistorico() As DataTable
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

    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from viajes v where id_viaje = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(viaje As EL.Viaje)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        If (viaje.Id > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@id_viaje", viaje.Id))
        End If
        parametros.Add(New SqlClient.SqlParameter("@origen", viaje.Origen))
        parametros.Add(New SqlClient.SqlParameter("@destino", viaje.Destino))
        parametros.Add(New SqlClient.SqlParameter("@fechaSalida", viaje.FechaSalida))
        If (viaje.FechaArribo <> DateTime.MinValue) Then
            parametros.Add(New SqlClient.SqlParameter("@fechaArribo", viaje.FechaArribo))
        End If
        If viaje.KmRecorridos > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@kmRecorridos", viaje.KmRecorridos))
        End If
        If viaje.Precio > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@precio", viaje.Precio))
        End If
        parametros.Add(New SqlClient.SqlParameter("@comentarios", viaje.Comentarios))
        If (viaje.Cliente.Id > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@id_cliente", viaje.Cliente.Id))
        End If
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", viaje.Chofer.Id))
        Dim _idaYVuelta As String
        If (viaje.IdaYVuelta) Then
            _idaYVuelta = "S"
        Else
            _idaYVuelta = "N"
        End If
        parametros.Add(New SqlClient.SqlParameter("@ida_Vuelta", _idaYVuelta))
        parametros.Add(New SqlClient.SqlParameter("@id_estado", viaje.Estado.Id))
        If Not IsNothing(viaje.Promociones) Then
            If viaje.Promociones.Count > 0 Then
                parametros.Add(New SqlClient.SqlParameter("@id_viaje", viaje.Id))
                Dim promociones As String = ""
                For Each promocion As EL.Promocion In viaje.Promociones
                    promociones += promocion.Id.ToString() + ";"
                Next
                promociones = promociones.Substring(0, promociones.Length() - 1)
                parametros.Add(New SqlClient.SqlParameter("@promociones", promociones))
            End If
        End If
            con.EjecutarStoredProcedure("dbo.GuardarViaje", parametros)
    End Sub

End Class
