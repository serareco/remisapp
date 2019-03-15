Public Class Modelo
    Public Sub GetById(pId As Int16, ByRef pModelo As EL.Modelo)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim marcaDAL As New Marca()
        con.EjecutarConsulta("select * from dbo.Modelo where id_modelo = " & pId)
        con.adp.Fill(datatable)
        pModelo.Id = datatable.Rows(0).ItemArray(0).ToString()
        pModelo.Descripcion = datatable.Rows(0).ItemArray(2).ToString()
        marcaDAL.GetById(datatable.Rows(0).ItemArray(1).ToString(), pModelo.Marca)
    End Sub
    Public Function Listar() As List(Of EL.Modelo)
        Dim con As New Conexion
        Dim datatable As New DataTable()
        Dim modelos As New List(Of EL.Modelo)
        con.EjecutarConsulta("Select id_modelo From dbo.Modelo")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            Dim modelo As New EL.Modelo()
            GetById(datatable.Rows(index).ItemArray(0).ToString(), modelo)
            modelos.Add(modelo)
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
            Dim modelo As New EL.Modelo()
            GetById(datatable.Rows(index).ItemArray(0).ToString(), modelo)
            modelos.Add(modelo)
        Next
        Return modelos
    End Function
End Class
