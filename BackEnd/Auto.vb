Imports DAL
Public Class Auto
    Public Function Listar() As List(Of EL.Auto)
        Return New DAL.Auto().Listar()
    End Function
    Public Function GetById(pId As Int16) As EL.Auto
        Return New DAL.Auto().GetById(pId)
    End Function
    Public Sub Guardar(auto As EL.Auto)
        Dim e As New DAL.Auto()
        e.Guardar(auto)
    End Sub
    Public Sub Quitar(auto As EL.Auto)
        Dim e As New DAL.Auto()
        e.Quitar(auto)
    End Sub
End Class
