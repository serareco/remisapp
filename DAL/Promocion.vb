Public Class Promocion
    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.promociones where id_promocion = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function Mostrar() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * From dbo.promociones")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarVigentes() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * From dbo.promociones where ISNULL(vigencia_hasta,GETDATE()) >= GETDATE()")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(promocion As EL.Promocion)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_comision", promocion.Id))
        parametros.Add(New SqlClient.SqlParameter("@descuento", promocion.Descuento))
        parametros.Add(New SqlClient.SqlParameter("@descripcion", promocion.Descripcion))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_desde", promocion.VigenciaDesde))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", promocion.VigenciaHasta))

        con.EjecutarStoredProcedure("dbo.GuardarPromocion", parametros)
    End Sub

    Public Sub Quitar(promocion As EL.Promocion)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_promocion", promocion.Id))
        con.EjecutarStoredProcedure("dbo.QuitarPromocion", parametros)
    End Sub

End Class
