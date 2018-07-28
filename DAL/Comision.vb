Public Class Comision
    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from comisiones where estado = 'A' and id_comision = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function Mostrar() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * From dbo.comisiones where estado = 'A' ")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarVigentes() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * From dbo.comisiones where ISNULL(vigencia_hasta,GETDATE()) >= GETDATE()")
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
