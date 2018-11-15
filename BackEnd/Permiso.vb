Public Class Permiso
    Public Function Listar() As List(Of EL.Permiso)
        Return New DAL.Permiso().Listar()
    End Function

    Public Function GetById(pId As String) As EL.Permiso
        Return New DAL.Permiso().GetById(pId)
    End Function

End Class
