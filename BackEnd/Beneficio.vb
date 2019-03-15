Public Class Beneficio
    Dim beneficioDAL As New DAL.Beneficio()
    Public Function Verificar(pIdSocio As Int16) As List(Of EL.Beneficio)
        Return beneficioDAL.Verificar(pIdSocio)
    End Function

    Public Function Listar() As List(Of EL.Beneficio)
        Return beneficioDAL.Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Beneficio
        Return beneficioDAL.GetById(pId)
    End Function

    Public Sub Guardar(beneficio As EL.Beneficio)
        beneficioDAL.Guardar(beneficio, Login.UsuarioConectado)
    End Sub

    Public Sub Quitar(pBeneficio As EL.Beneficio)
        beneficioDAL.Quitar(pBeneficio, Login.UsuarioConectado)
    End Sub
End Class
