Imports DAL
Public Class Vehiculo
    Public Function Listar() As List(Of EL.Vehiculo)
        Return New DAL.Vehiculo().Listar()
    End Function
    Public Function GetById(pId As Int16) As EL.Vehiculo
        Return New DAL.Vehiculo().GetById(pId)
    End Function
    Public Sub Guardar(auto As EL.Vehiculo)
        Dim e As New DAL.Vehiculo()
        e.Guardar(auto)
    End Sub
    Public Sub Quitar(auto As EL.Vehiculo)
        Dim e As New DAL.Vehiculo()
        e.Quitar(auto)
    End Sub
End Class
