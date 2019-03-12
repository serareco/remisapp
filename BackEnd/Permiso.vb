Public Class Permiso
    Dim permisoDAL As New DAL.Permiso()
    Public Function Listar() As List(Of EL.Permiso)
        Return permisoDAL.Listar()
    End Function

    Public Function GetById(pId As String) As EL.Permiso
        Return permisoDAL.GetById(pId)
    End Function

End Class
