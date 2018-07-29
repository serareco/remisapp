Public Class Promocion
    Public Function Mostrar() As DataTable
        Return New DAL.Promocion().Mostrar()
    End Function

    Public Function GetById(pId As Int16) As EL.Promocion
        Dim promocion As New EL.Promocion()
        Dim datatable As DataTable
        datatable = New DAL.Promocion().GetById(pId)
        promocion.Id = datatable.Rows(0).ItemArray(0).ToString()
        promocion.Descuento = datatable.Rows(0).ItemArray(1).ToString()
        promocion.VigenciaDesde = datatable.Rows(0).ItemArray(2).ToString()
        promocion.VigenciaHasta = datatable.Rows(0).ItemArray(3).ToString()
        promocion.Descripcion = datatable.Rows(0).ItemArray(4).ToString()
        Return promocion
    End Function

    Public Sub Guardar(promocion As EL.Promocion)
        Dim e As New DAL.Promocion()
        e.Guardar(promocion)
    End Sub

    Public Sub Quitar(promocion As EL.Promocion)
        Dim e As New DAL.Promocion()
        e.Quitar(promocion)
    End Sub
End Class
