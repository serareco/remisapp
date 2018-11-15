Public Class Marca
    Public Function GetById(pId As Int16) As EL.Marca
        Dim con As New Conexion
        Dim marca As New EL.Marca()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Autos_Marcas where id_marca = " & pId)
        con.adp.Fill(datatable)
        marca.Id = datatable.Rows(0).ItemArray(0).ToString()
        marca.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        Return marca
    End Function

    Public Function Listar() As List(Of EL.Marca)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim marcas As New List(Of EL.Marca)
        con.EjecutarConsulta("Select id_marca From dbo.Autos_Marcas")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            marcas.Add(New Marca().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return marcas
    End Function

End Class
