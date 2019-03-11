Public Class Beneficio
    Dim beneficioDAL As New DAL.Beneficio()
    Public Function Verificar(pIdSocio As Int16) As List(Of EL.Beneficio)
        Return beneficioDAL.Verificar(pIdSocio)
    End Function

    Public Function Listar() As List(Of EL.Beneficio)
        Return New DAL.Beneficio().Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Beneficio
        Return beneficioDAL.GetById(pId)
    End Function

    Public Sub Guardar(beneficio As EL.Beneficio)
        beneficioDAL.Guardar(beneficio)
    End Sub

    Public Sub Quitar(promocion As EL.Beneficio)
        beneficioDAL.Quitar(promocion)
    End Sub
End Class
