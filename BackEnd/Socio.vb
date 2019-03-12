Public Class Socio
    Dim socioDAL As New DAL.Socio()
    Dim personaDAL As New DAL.Persona()
    Public Function GetById(pId As Int16) As EL.Socio
        Return socioDAL.GetById(pId)
    End Function

    Public Function Listar() As List(Of EL.Socio)
        Return socioDAL.Listar()
    End Function

    Public Sub Guardar(cliente As EL.Socio)
        personaDAL.Guardar(cliente, Login.UsuarioConectado)
        socioDAL.Guardar(cliente, Login.UsuarioConectado)
    End Sub

    Public Sub Quitar(cliente As EL.Socio)
        socioDAL.Quitar(cliente, Login.UsuarioConectado)
    End Sub

End Class
