Public Class Permiso
    Public Function Listar() As List(Of EL.Permiso)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim permisos As New List(Of EL.Permiso)
        con.EjecutarConsulta("
        select id_permiso,descripcion
        from dbo.Permiso 
        where estado = 'A' ")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            permisos.Add(New Permiso().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return permisos
    End Function

    Public Function GetById(pId As String) As EL.Permiso
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim permiso As New EL.Permiso()
        con.EjecutarConsulta("select * from dbo.Permiso where id_permiso = '" + pId + "'")
        con.adp.Fill(datatable)
        permiso.Id = datatable.Rows(0).ItemArray(0).ToString()
        permiso.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        Return permiso
    End Function

End Class
