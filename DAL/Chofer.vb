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
        Dim registro As New Registro()
        Dim datatable As New DataTable
        con.EjecutarConsulta("
         select c.id_comision, c.id_vehiculo
           from dbo.Chofer c inner join dbo.Persona p on c.id_persona = p.id_persona
            inner join dbo.Usuario u on u.id_persona = p.id_persona
          where c.id_persona = " & pId)
        con.adp.Fill(datatable)
        Dim chofer As New EL.Chofer(New Usuario().GetById(pId))
        chofer.Comision = New Comision().GetById(datatable.Rows(0).ItemArray(0).ToString())
        chofer.Auto = New Vehiculo().GetById(datatable.Rows(0).ItemArray(1).ToString())
        registro.GetById(chofer.Id, chofer.Registro)
        chofer.Turnos = New Turno().GetByChoferId(pId)

        Dim conAcciones As New Conexion
        Dim datatableAcciones As New DataTable
        conAcciones.EjecutarConsulta("
        SELECT ca.id_accion 
          FROM dbo.Chofer c INNER JOIN dbo.Chofer_Accion ca
            ON c.id_persona = ca.id_persona
         WHERE c.id_persona =  " & pId)
        conAcciones.adp.Fill(datatableAcciones)
        If datatableAcciones.Rows.Count > 0 Then
            chofer.Acciones = New List(Of EL.Accion)
            For index = 0 To datatableAcciones.Rows.Count - 1
                chofer.Acciones.Add(New Accion().GetById(datatableAcciones.Rows(index).ItemArray(0).ToString()))
            Next
        End If

        Return chofer
    End Function

    Public Sub Guardar(chofer As EL.Chofer, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", chofer.Id))
        parametros.Add(New SqlClient.SqlParameter("@id_comision", chofer.Comision.Id))
        parametros.Add(New SqlClient.SqlParameter("@fecha_vencimiento_registro", chofer.Registro.FechaVencimiento))
        parametros.Add(New SqlClient.SqlParameter("@categoria_registro", chofer.Registro.Categoria))
        parametros.Add(New SqlClient.SqlParameter("@id_vehiculo", chofer.Auto.Id))
        Dim turnos As String = ""
        For Each turno As EL.Turno In chofer.Turnos
            turnos += turno.Id.ToString + ";"
        Next
        turnos = turnos.Substring(0, turnos.Length() - 1)
        parametros.Add(New SqlClient.SqlParameter("@turnos", turnos))
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.GuardarChofer", parametros)
    End Sub

    Public Sub Quitar(chofer As EL.Chofer, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_persona", chofer.Id))
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.QuitarChofer", parametros)
    End Sub

    Public Function ListarEnCondiciones() As List(Of EL.Chofer)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim choferes As New List(Of EL.Chofer)
        con.EjecutarConsulta("
        select c.id_persona
        from dbo.Chofer c inner join dbo.Registro r ON c.id_persona = r.id_persona
		 inner join dbo.Vehiculo v ON c.id_vehiculo = v.id_vehiculo
         where c.estado = 'A'
		 and r.fecha_vencimiento >= CONVERT(date, getdate())
		 and v.fecha_vencimiento_VTV >= CONVERT(date, getdate())")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            choferes.Add(New Chofer().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return choferes
    End Function

    Public Function ListarDisponibles(pFechaHoraViaje As DateTime) As List(Of EL.Chofer)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim choferes As New List(Of EL.Chofer)
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@fechaHoraViaje", pFechaHoraViaje))
        con.EjecutarStoredProcedureDa("dbo.ConsultaChoferesParaViajes", parametros)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            choferes.Add(New Chofer().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return choferes
    End Function

    Public Function GetAcciones(pIdChofer As Int32, pFechaDesde As Date, pFechaHasta As Date, pActivo As Boolean, pVigente As Boolean, pAcciones As String) As EL.Chofer
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim chofer As New EL.Chofer()
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_chofer", pIdChofer))
        If pFechaDesde <> Date.MinValue Then
            parametros.Add(New SqlClient.SqlParameter("@fecha_desde", pFechaDesde))
        End If
        If pFechaHasta <> Date.MinValue Then
            parametros.Add(New SqlClient.SqlParameter("@fecha_hasta", pFechaHasta))
        End If
        If pActivo Then
            parametros.Add(New SqlClient.SqlParameter("@activo", "S"))
        Else
            parametros.Add(New SqlClient.SqlParameter("@activo", "N"))
        End If
        If pVigente Then
            parametros.Add(New SqlClient.SqlParameter("@vigente", "S"))
        Else
            parametros.Add(New SqlClient.SqlParameter("@vigente", "N"))
        End If
        If pAcciones <> "" Then
            parametros.Add(New SqlClient.SqlParameter("@acciones", pAcciones))
        End If

        con.EjecutarStoredProcedureDa("dbo.ConsultaPuntosChoferes", parametros)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            If index = 0 Then
                chofer = New Chofer().GetById(datatable.Rows(0).ItemArray(0).ToString())
                chofer.Acciones = New List(Of EL.Accion)
            End If
            chofer.Acciones.Add(New Accion().GetById(datatable.Rows(index).ItemArray(1).ToString()))
        Next
        Return chofer
    End Function

End Class
