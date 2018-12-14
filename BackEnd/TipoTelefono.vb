Public Class TipoTelefono
    Public Function Listar() As List(Of EL.TipoTelefono)
        Return New DAL.TipoTelefono().Listar()
    End Function

    Public Function GetById(pId As String) As EL.TipoTelefono
        Return New DAL.TipoTelefono().GetById(pId)
    End Function
End Class
