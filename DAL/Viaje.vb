Public Class Viaje
    Public Function Listar(Optional pTipoConsulta As Char = "D") As List(Of EL.Viaje)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim viajes As New List(Of EL.Viaje)
        If pTipoConsulta = "D" Then
            con.EjecutarConsulta("select v.id_viaje from dbo.Viaje v Order By fecha_salida_estimada Desc")
        ElseIf pTipoConsulta = "H" Then
            con.EjecutarConsulta("select v.id_viaje from dbo.Viaje v Where id_estado in (4,5) Order by fecha_salida Desc")
        ElseIf pTipoConsulta = "C" Then
            con.EjecutarConsulta("select v.id_viaje from dbo.Viaje v where id_estado in (1)  Order by fecha_salida Desc")
        ElseIf pTipoConsulta = "P" Then
            con.EjecutarConsulta("select v.id_viaje from dbo.Viaje v where id_estado in (2,3)  Order by fecha_salida_estimada Desc")
        ElseIf pTipoConsulta = "M" Then
            con.EjecutarConsulta("select  v.id_viaje from dbo.Viaje v
                                   where concat(year(isnull(fecha_salida,fecha_salida_estimada)),MONTH (isnull(fecha_salida,fecha_salida_estimada))) = concat(year(getdate()),MONTH(getdate()))
                                order by fecha_salida_estimada Desc")
        ElseIf pTipoConsulta = "V" Then
            con.EjecutarConsulta("select v.id_viaje from dbo.Viaje v Where id_estado in (3) OR CONVERT (date, ISNULL(v.fecha_salida,fecha_salida_estimada)) = CONVERT (date, GETDATE()) Order by fecha_salida Desc")
        End If
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            viajes.Add(New Viaje().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return viajes
    End Function

    Public Function GetProximoViajePendiente() As EL.Viaje
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim viaje As New EL.Viaje()
        con.EjecutarConsulta("select top 1 v.id_viaje from dbo.Viaje v where id_estado in (2,3) order by fecha_salida_estimada desc")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            viaje = (New Viaje().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return Viaje
    End Function

    Public Function GetProximoViajeVuelta() As EL.Viaje
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim viaje As New EL.Viaje()
        con.EjecutarConsulta("select top 1 v.id_viaje from dbo.Viaje v where id_estado in (1) order by fecha_salida_estimada desc")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            viaje = (New Viaje().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return viaje
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
        Try
            viaje.FechaSalidaEstimada = datatable.Rows(0).ItemArray(3).ToString()
        Catch ex As Exception
            viaje.FechaSalidaEstimada = Nothing
        End Try
        Try
            viaje.FechaArriboEstimado = datatable.Rows(0).ItemArray(4).ToString()
        Catch ex As Exception
            viaje.FechaArriboEstimado = Nothing
        End Try
        viaje.KmEstimados = datatable.Rows(0).ItemArray(5).ToString()
        viaje.Comentarios = datatable.Rows(0).ItemArray(6).ToString()
        viaje.Socio = New Socio().GetById(datatable.Rows(0).ItemArray(7).ToString())
        viaje.IdaYVuelta = (datatable.Rows(0).ItemArray(8).ToString() = "S")
        viaje.ChoferEstimado = New Chofer().GetById(datatable.Rows(0).ItemArray(9).ToString())
        viaje.Estado = New EstadoViaje().GetById(datatable.Rows(0).ItemArray(10).ToString())
        If datatable.Rows(0).ItemArray(11).ToString() <> "" Then
            viaje.Precio = datatable.Rows(0).ItemArray(11).ToString()
        End If
        If datatable.Rows(0).ItemArray(12).ToString() <> "" Then
            viaje.KmRecorridos = datatable.Rows(0).ItemArray(12).ToString()
        End If
        Try
            viaje.FechaSalida = datatable.Rows(0).ItemArray(13).ToString()
        Catch ex As Exception
            viaje.FechaSalida = Nothing
        End Try
        Try
            viaje.FechaArribo = datatable.Rows(0).ItemArray(14).ToString()
        Catch ex As Exception
            viaje.FechaArribo = Nothing
        End Try
        Try
            viaje.Chofer = New Chofer().GetById(datatable.Rows(0).ItemArray(15).ToString())
        Catch ex As Exception
            viaje.Chofer = Nothing
        End Try
        viaje.PrecioEstimado = datatable.Rows(0).ItemArray(16).ToString()
        If datatable.Rows(0).ItemArray(17).ToString() > 0 Then
            viaje.DuracionEstimada = datatable.Rows(0).ItemArray(17).ToString()
        End If
        Try
            viaje.Duracion = datatable.Rows(0).ItemArray(18).ToString()
        Catch ex As Exception
            viaje.Duracion = 0
        End Try
        Try
            viaje.Ahorro = datatable.Rows(0).ItemArray(19).ToString()
        Catch ex As Exception
            viaje.Ahorro = 0
        End Try
        Return viaje
    End Function

    Public Sub Guardar(viaje As EL.Viaje, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        If (viaje.Id > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@id_viaje", viaje.Id))
        End If
        parametros.Add(New SqlClient.SqlParameter("@origen", viaje.Origen))
        parametros.Add(New SqlClient.SqlParameter("@destino", viaje.Destino))
        If (viaje.FechaSalida <> DateTime.MinValue) Then
            parametros.Add(New SqlClient.SqlParameter() With {.ParameterName = "@fecha_salida", .SqlDbType = SqlDbType.DateTimeOffset, .Value = viaje.FechaSalida})
        End If
        If (viaje.FechaSalidaEstimada <> DateTime.MinValue) Then
            parametros.Add(New SqlClient.SqlParameter() With {.ParameterName = "@fecha_salida_estimada", .SqlDbType = SqlDbType.DateTimeOffset, .Value = viaje.FechaSalidaEstimada})
        End If
        If (viaje.FechaArribo <> DateTime.MinValue) Then
            parametros.Add(New SqlClient.SqlParameter() With {.ParameterName = "@fecha_arribo", .SqlDbType = SqlDbType.DateTimeOffset, .Value = viaje.FechaArribo})
        End If
        If (viaje.FechaArriboEstimado <> DateTime.MinValue) Then
            parametros.Add(New SqlClient.SqlParameter() With {.ParameterName = "@fecha_arribo_estimado", .SqlDbType = SqlDbType.DateTimeOffset, .Value = viaje.FechaArriboEstimado})
        End If
        If viaje.KmRecorridos > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@km_recorridos", viaje.KmRecorridos))
        End If
        If viaje.KmEstimados > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@km_estimados", viaje.KmEstimados))
        End If
        If viaje.Precio > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@precio", viaje.Precio))
        End If
        If viaje.PrecioEstimado > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@precio_estimado", viaje.PrecioEstimado))
        End If
        If viaje.Ahorro > 0 Then
            parametros.Add(New SqlClient.SqlParameter("@ahorro", viaje.Ahorro))
        End If
        parametros.Add(New SqlClient.SqlParameter("@comentarios", viaje.Comentarios))
        parametros.Add(New SqlClient.SqlParameter("@id_socio", viaje.Socio.Id))
        If (viaje.Chofer IsNot Nothing) Then
            parametros.Add(New SqlClient.SqlParameter("@id_chofer", viaje.Chofer.Id))
        End If
        parametros.Add(New SqlClient.SqlParameter("@id_chofer_estimado", viaje.ChoferEstimado.Id))
        Dim _idaYVuelta As String
        If (viaje.IdaYVuelta) Then
            _idaYVuelta = "S"
        Else
            _idaYVuelta = "N"
        End If
        parametros.Add(New SqlClient.SqlParameter("@duracion_estimada", viaje.DuracionEstimada))
        If (viaje.Duracion > 0) Then
            parametros.Add(New SqlClient.SqlParameter("@duracion", viaje.Duracion))
        End If
        parametros.Add(New SqlClient.SqlParameter("@ida_Vuelta", _idaYVuelta))
        parametros.Add(New SqlClient.SqlParameter("@id_estado", viaje.Estado.Id))
        If Not IsNothing(viaje.Beneficios) Then
            If viaje.Beneficios.Count > 0 Then
                parametros.Add(New SqlClient.SqlParameter("@id_viaje", viaje.Id))
                Dim beneficios As String = ""
                For Each beneficio As EL.Beneficio In viaje.Beneficios
                    beneficios += beneficio.Id.ToString() + ";"
                Next
                beneficios = beneficios.Substring(0, beneficios.Length() - 1)
                parametros.Add(New SqlClient.SqlParameter("@beneficios", beneficios))
            End If
        End If
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.GuardarViaje", parametros)
    End Sub

End Class
