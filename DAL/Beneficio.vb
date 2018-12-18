Public Class Beneficio
    Public Function Verificar(pIdSocio As Int16) As List(Of EL.Beneficio)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim beneficios As New List(Of EL.Beneficio)
        con.EjecutarConsulta("EXEC GetBeneficiosSocio @id_socio = " & pIdSocio)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            beneficios.Add(New Beneficio().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return beneficios
    End Function

    Public Function GetById(pId As Int16) As EL.Beneficio
        Dim con As New Conexion
        Dim beneficio As New EL.Beneficio()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Beneficio where id_beneficio = " & pId)
        con.adp.Fill(datatable)
        beneficio.Id = datatable.Rows(0).ItemArray(0).ToString()
        beneficio.Descuento = datatable.Rows(0).ItemArray(1).ToString()
        beneficio.VigenciaDesde = datatable.Rows(0).ItemArray(2).ToString()
        Try
            beneficio.VigenciaHasta = datatable.Rows(0).ItemArray(3).ToString()
        Catch ex As Exception
            beneficio.VigenciaHasta = Nothing
        End Try
        beneficio.Descripcion = datatable.Rows(0).ItemArray(4).ToString()
        Return beneficio
    End Function

    Public Function Listar() As List(Of EL.Beneficio)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim beneficios As New List(Of EL.Beneficio)
        con.EjecutarConsulta("select id_beneficio From dbo.Beneficio where estado = 'A'")
        con.adp.Fill(datatable)

        For index = 0 To datatable.Rows.Count - 1
            beneficios.Add(New Beneficio().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return beneficios
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

        If promocion.VigenciaHasta = Nothing Then
            parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", System.Data.SqlTypes.SqlDateTime.Null))
        Else
            parametros.Add(New SqlClient.SqlParameter("@vigencia_hasta", promocion.VigenciaHasta))
        End If

        con.EjecutarStoredProcedure("dbo.GuardarBeneficio", parametros)

    End Sub

    Public Sub Quitar(promocion As EL.Beneficio)
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_beneficio", promocion.Id))
        con.EjecutarStoredProcedure("dbo.QuitarBeneficio", parametros)
    End Sub

End Class
