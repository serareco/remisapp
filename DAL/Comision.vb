Public Class Comision
    Public Function GetById(pId As Int16) As EL.Comision
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from comisiones where estado = 'A' and id_comision = " & pId)
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

    Public Function Listar() As List(Of EL.Comision)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim comisiones As New List(Of EL.Comision)
        con.EjecutarConsulta("select * From dbo.comisiones where estado = 'A' ")
        con.adp.Fill(datatable)

        For index = 0 To datatable.Rows.Count - 1
            comisiones.Add(New Comision().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return comisiones
    End Function

    Public Function MostrarVigentes() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * From dbo.comisiones where estado = 'A' and (vigencia_hasta >= GETDATE() or vigencia_hasta is null)")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(comision As EL.Comision)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_comision", comision.Id))
        parametros.Add(New SqlClient.SqlParameter("@porcentaje", comision.Porcentaje))
        parametros.Add(New SqlClient.SqlParameter("@descripcion", comision.Descripcion))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_desde", comision.VigenciaDesde))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", comision.VigenciaHasta))

        con.EjecutarStoredProcedure("dbo.GuardarComision", parametros)
    End Sub

    Public Sub Quitar(comision As EL.Comision)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_comision", comision.Id))
        con.EjecutarStoredProcedure("dbo.QuitarComision", parametros)
    End Sub

End Class
