Public Class Socio
    Dim socioDAL As New DAL.Socio()
    Dim personaService As New Persona()
    Public Function GetById(pId As Int16) As EL.Socio
        Return socioDAL.GetById(pId)
    End Function

    Public Function Listar() As List(Of EL.Socio)
        Return socioDAL.Listar()
    End Function

    Public Sub Guardar(socio As EL.Socio)
        personaService.Guardar(socio)
        socioDAL.Guardar(socio, Login.UsuarioConectado)
    End Sub

    Public Sub Quitar(socio As EL.Socio)
        socioDAL.Quitar(socio, Login.UsuarioConectado)
    End Sub

End Class
