Public Class Modelo
    Public Function GetById(pId As Int16) As EL.Modelo
        Dim con As New Conexion
        Dim modelo As New EL.Modelo()
        Dim datatable As New DataTable()
        Dim marca As New Marca()
        con.EjecutarConsulta("select * from dbo.Modelo where id_modelo = " & pId)
        con.adp.Fill(datatable)
        modelo.Id = datatable.Rows(0).ItemArray(0).ToString()
        modelo.Descripcion = datatable.Rows(0).ItemArray(2).ToString()
        marca.GetById(datatable.Rows(0).ItemArray(1).ToString(), modelo.Marca)
        Return modelo
    End Function
    Public Function Listar() As List(Of EL.Modelo)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim modelos As New List(Of EL.Modelo)
        con.EjecutarConsulta("Select id_marca From dbo.Modelo")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            modelos.Add(New Modelo().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return modelos
    End Function
    Public Function Listar(pIdMarca As Int16) As List(Of EL.Modelo)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim modelos As New List(Of EL.Modelo)
        con.EjecutarConsulta("Select id_modelo From dbo.Modelo where id_marca = " & pIdMarca)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            modelos.Add(New Modelo().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return modelos
    End Function
End Class
