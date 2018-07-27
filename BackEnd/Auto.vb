Imports DAL
Public Class Auto
    Public Function Mostrar() As DataTable
        Return New DAL.Auto().Mostrar()
    End Function

    Public Function MostrarDisponibles() As DataTable
        Return New DAL.Auto().MostrarDisponibles()
    End Function

    Public Function MostrarMarcas() As DataTable
        Return New DAL.Auto().MostrarMarcas()
    End Function
    Public Function MostrarModelos(pIdMarca As Int16) As DataTable
        Return New DAL.Auto().MostrarModelos(pIdMarca)
    End Function
    Public Function GetById(pId As Int16) As EL.Auto
        Dim auto As New EL.Auto()
        Dim datatable As DataTable
        datatable = New DAL.Auto().GetById(pId)
        auto.Id = datatable.Rows(0).ItemArray(0).ToString()
        auto.Marca = datatable.Rows(0).ItemArray(1).ToString()
        auto.Modelo = datatable.Rows(0).ItemArray(2).ToString()
        auto.AnioFabricacion = datatable.Rows(0).ItemArray(3).ToString()
        auto.Patente = datatable.Rows(0).ItemArray(4).ToString()
        auto.Motor = datatable.Rows(0).ItemArray(5).ToString()
        auto.Chasis = datatable.Rows(0).ItemArray(6).ToString()
        Return auto
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
