Public Class Parametro
    Dim parametroDAL As New DAL.Parametro()
    Public Function Listar() As List(Of EL.Parametro)
        Return parametroDAL.Listar("D")
    End Function

    Public Function ListarVigentes() As List(Of EL.Parametro)
        Return parametroDAL.Listar("V")
    End Function

    Public Function GetById(pId As Int16) As EL.Parametro
        Return parametroDAL.GetById(pId)
    End Function

    Public Sub Guardar(parametro As EL.Parametro)
        parametroDAL.Guardar(parametro, Login.UsuarioConectado)
    End Sub

    Public Sub Quitar(parametro As EL.Parametro)
        parametroDAL.Quitar(parametro, Login.UsuarioConectado)
    End Sub

    Public Function GetValueByKey(pclave As String) As String
        Return parametroDAL.GetValueByKey(pclave)
    End Function

End Class
