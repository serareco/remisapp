Public Class Parametro
    Public Function Listar() As List(Of EL.Parametro)
        Return New DAL.Parametro().Listar("D")
    End Function

    Public Function ListarVigentes() As List(Of EL.Parametro)
        Return New DAL.Parametro().Listar("V")
    End Function

    Public Function GetById(pId As Int16) As EL.Parametro
        Return New DAL.Parametro().GetById(pId)
    End Function

    Public Sub Guardar(parametro As EL.Parametro)
        Dim e As New DAL.Parametro()
        e.Guardar(parametro)
    End Sub

    Public Sub Quitar(comision As EL.Parametro)
        Dim e As New DAL.Parametro()
        e.Quitar(comision)
    End Sub
End Class
