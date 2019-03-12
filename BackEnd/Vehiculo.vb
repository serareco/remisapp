Imports DAL
Public Class Vehiculo
    Dim vehiculoDAL As New DAL.Vehiculo()
    Public Function Listar() As List(Of EL.Vehiculo)
        Return vehiculoDAL.Listar()
    End Function
    Public Function GetById(pId As Int16) As EL.Vehiculo
        Return vehiculoDAL.GetById(pId)
    End Function
    Public Sub Guardar(auto As EL.Vehiculo)
        vehiculoDAL.Guardar(auto, Login.UsuarioConectado)
    End Sub
    Public Sub Quitar(auto As EL.Vehiculo)
        vehiculoDAL.Quitar(auto, Login.UsuarioConectado)
    End Sub
End Class
