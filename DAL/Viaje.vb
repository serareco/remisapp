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
				        inner join Autos a on a.id_vehiculo = c.id_vehiculo
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
				        inner join Autos a on a.id_vehiculo = c.id_vehiculo
				        inner join Autos_Modelos am on am.id_modelo = a.id_Modelo
				        inner join Autos_Marcas ama	on ama.id_marca = a.id_Marca
				        inner join Tipos_Estado_Viaje te on v.id_estado = te.id_estado")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function Listar() As List(Of EL.Viaje)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim viajes As New List(Of EL.Viaje)
        con.EjecutarConsulta("
        select v.id_viaje
         from dbo.Viaje v")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            viajes.Add(New Viaje().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return viajes
    End Function

    Public Function GetById(pId As Int16) As EL.Viaje
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim viaje As New EL.Viaje()
        con.EjecutarConsulta("select * from dbo.viaje v where id_viaje = " & pId)
        con.adp.Fill(datatable)
        viaje.Id = datatable.Rows(0).ItemArray(0).ToString()
        viaje.Origen = datatable.Rows(0).ItemArray(1).ToString()
        viaje.Destino = datatable.Rows(0).ItemArray(2).ToString()
        'viaje.FechaSalida = datatable.Rows(0).ItemArray(3).ToString()
        'viaje.FechaArribo = datatable.Rows(0).ItemArray(4).ToString()
        viaje.KmRecorridos = datatable.Rows(0).ItemArray(5).ToString()
        viaje.Comentarios = datatable.Rows(0).ItemArray(6).ToString()
        'viaje.Socio = datatable.Rows(0).ItemArray(7).ToString()
        'viaje.IdaYVuelta = datatable.Rows(0).ItemArray(8).ToString()
        viaje.Chofer = New Chofer().GetById(datatable.Rows(0).ItemArray(9).ToString())
        'viaje.Estado = datatable.Rows(0).ItemArray(10).ToString()
        viaje.Precio = datatable.Rows(0).ItemArray(11).ToString()
        Return viaje
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
        If (viaje.Socio.Id > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@id_cliente", viaje.Socio.Id))
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
                For Each promocion As EL.Beneficio In viaje.Promociones
                    promociones += promocion.Id.ToString() + ";"
                Next
                promociones = promociones.Substring(0, promociones.Length() - 1)
                parametros.Add(New SqlClient.SqlParameter("@promociones", promociones))
            End If
        End If
            con.EjecutarStoredProcedure("dbo.GuardarViaje", parametros)
    End Sub

End Class
