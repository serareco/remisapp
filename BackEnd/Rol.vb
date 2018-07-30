Public Class Rol
    Public Function Listar() As DataTable
        Return New DAL.Rol().Listar()
    End Function

    Public Function GetById(pId As String) As EL.Rol
        Dim rol As New EL.Rol()
        Dim datatable As DataTable = New DAL.Rol().GetById(pId)
        rol.Id = datatable.Rows(0).ItemArray(0).ToString()
        rol.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        Return rol
    End Function

End Class
