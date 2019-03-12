Public Class Accion
    Dim accionDAL As New DAL.Accion()
    Public Function Listar() As List(Of EL.Accion)
        Return accionDAL.Listar()
    End Function

    Public Function GetById(pId As Int16) As EL.Accion
        Return accionDAL.GetById(pId)
    End Function

    Public Sub Guardar(pAccion As EL.Accion)
        accionDAL.Guardar(pAccion, Login.UsuarioConectado)
    End Sub

    Public Sub Guardar(pChofer As EL.Chofer, pAccion As EL.Accion)
        accionDAL.Guardar(pChofer, pAccion)
    End Sub
End Class
