Public Class Comision
    Public Function GetById(pId As Int16) As EL.Comision
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Comision where id_comision = " & pId)
        con.adp.Fill(datatable)
        Dim comision As New EL.Comision()
        comision.Id = datatable.Rows(0).ItemArray(0).ToString()
        comision.Porcentaje = datatable.Rows(0).ItemArray(1).ToString()
        comision.Descripcion = datatable.Rows(0).ItemArray(2).ToString()
        comision.VigenciaDesde = datatable.Rows(0).ItemArray(3).ToString()
        If Not datatable.Rows(0).ItemArray(4).ToString() = "" Then
            comision.VigenciaHasta = datatable.Rows(0).ItemArray(4).ToString()
        End If
        Return comision
    End Function

    Public Function GetDefault() As EL.Comision
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Comision where estado = 'D'")
        con.adp.Fill(datatable)
        Dim comision As New EL.Comision()
        comision.Id = datatable.Rows(0).ItemArray(0).ToString()
        comision.Porcentaje = datatable.Rows(0).ItemArray(1).ToString()
        comision.Descripcion = datatable.Rows(0).ItemArray(2).ToString()
        comision.VigenciaDesde = datatable.Rows(0).ItemArray(3).ToString()
        If Not datatable.Rows(0).ItemArray(4).ToString() = "" Then
            comision.VigenciaHasta = datatable.Rows(0).ItemArray(4).ToString()
        End If
        Return comision
    End Function

    Public Function Listar(Optional pTipoConsulta As Char = "D") As List(Of EL.Comision)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim comisiones As New List(Of EL.Comision)
        If pTipoConsulta = "V" Then
            con.EjecutarConsulta("select * From dbo.Comision where estado IN ('A','D') and (vigencia_hasta >= GETDATE() Or vigencia_hasta IS NULL) ")
        ElseIf pTipoConsulta = "D" Then
            con.EjecutarConsulta("select * From dbo.Comision where estado IN ('A','D') ")
        End If
        con.adp.Fill(datatable)

        For index = 0 To datatable.Rows.Count - 1
            comisiones.Add(New Comision().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return comisiones
    End Function

    Public Sub Guardar(comision As EL.Comision, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_comision", comision.Id))
        parametros.Add(New SqlClient.SqlParameter("@porcentaje", comision.Porcentaje))
        parametros.Add(New SqlClient.SqlParameter("@descripcion", comision.Descripcion))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_desde", comision.VigenciaDesde))
        If comision.VigenciaHasta <> DateTime.MinValue Then
            parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", comision.VigenciaHasta))
        End If
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.GuardarComision", parametros)
    End Sub

    Public Sub Quitar(comision As EL.Comision, usuarioConectado As EL.Usuario)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_comision", comision.Id))
        parametros.Add(New SqlClient.SqlParameter("@usuario_operacion", usuarioConectado.Usuario))
        con.EjecutarStoredProcedure("dbo.QuitarComision", parametros)
    End Sub

End Class
