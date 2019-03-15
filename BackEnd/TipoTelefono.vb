Public Class TipoTelefono
    Dim tipoTelefonoDAL As New DAL.TipoTelefono()
    Public Function Listar() As List(Of EL.TipoTelefono)
        Return tipoTelefonoDAL.Listar()
    End Function

    Public Function GetById(pId As String) As EL.TipoTelefono
        Return tipoTelefonoDAL.GetById(pId)
    End Function
End Class
