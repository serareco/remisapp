Public Class Beneficio
    Public Function GetById(pId As Int16) As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Beneficio where id_beneficio = " & pId)
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function Mostrar() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * From dbo.Beneficio where estado = 'A' ")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarVigentes() As DataTable
        Dim con As New Conexion
        Dim datatable As New DataTable()
        con.EjecutarConsulta("  
        select id_beneficio, descripcion From dbo.Beneficio where estado = 'A' and  ISNULL(vigencia_hasta,GETDATE()) >= GETDATE()
        ")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar(promocion As EL.Beneficio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_beneficio", promocion.Id))
        parametros.Add(New SqlClient.SqlParameter("@descuento", promocion.Descuento))
        parametros.Add(New SqlClient.SqlParameter("@descripcion", promocion.Descripcion))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_desde", promocion.VigenciaDesde))
        parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", promocion.VigenciaHasta))

        con.EjecutarStoredProcedure("dbo.GuardarBeneficio", parametros)
    End Sub

    Public Sub Quitar(promocion As EL.Beneficio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_beneficio", promocion.Id))
        con.EjecutarStoredProcedure("dbo.QuitarBeneficio", parametros)
    End Sub

End Class
