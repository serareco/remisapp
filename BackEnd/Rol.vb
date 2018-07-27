Public Class Rol
    Public Function Listar() As DataTable
        Return New DAL.Rol().Listar()
    End Function
End Class
