Public Class Beneficio
    Public Function Verificar(pIdSocio As Int16) As List(Of EL.Beneficio)
        Return New DAL.Beneficio().Verificar(pIdSocio)
    End Function

    Public Function Listar() As List(Of EL.Beneficio)
        Return New DAL.Beneficio().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Beneficio
        Return New DAL.Beneficio().GetById(pId)
    End Function

    Public Sub Guardar(promocion As EL.Beneficio)
        Dim e As New DAL.Beneficio()
        e.Guardar(promocion)
    End Sub

    Public Sub Quitar(promocion As EL.Beneficio)
        Dim e As New DAL.Beneficio()
        e.Quitar(promocion)
    End Sub
End Class
