Public Class Comision
    Public Function Listar() As List(Of EL.Comision)
        Return New DAL.Comision().Listar("D")
    End Function

    Public Function ListarVigentes() As List(Of EL.Comision)
        Return New DAL.Comision().Listar("V")
    End Function

    Public Function GetById(pId As Int16) As EL.Comision
        Return New DAL.Comision().GetById(pId)
    End Function

    Public Function GetDefault() As EL.Comision
        Return New DAL.Comision().GetDefault()
    End Function

    Public Sub Guardar(comision As EL.Comision)
        Dim e As New DAL.Comision()
        e.Guardar(comision)
    End Sub

    Public Sub Quitar(comision As EL.Comision)
        Dim e As New DAL.Comision()
        e.Quitar(comision)
    End Sub
End Class
