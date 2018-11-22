Public Class Beneficio
    Public Function Mostrar() As DataTable
        Return New DAL.Beneficio().Mostrar()
    End Function

    Public Function MostrarVigentes() As DataTable
        Return New DAL.Beneficio().MostrarVigentes()
    End Function

    Public Function GetById(pId As Int16) As EL.Beneficio
        Dim promocion As New EL.Beneficio()
        Dim datatable As DataTable
        datatable = New DAL.Beneficio().GetById(pId)
        promocion.Id = datatable.Rows(0).ItemArray(0).ToString()
        promocion.Descuento = datatable.Rows(0).ItemArray(1).ToString()
        promocion.VigenciaDesde = datatable.Rows(0).ItemArray(2).ToString()
        promocion.VigenciaHasta = datatable.Rows(0).ItemArray(3).ToString()
        promocion.Descripcion = datatable.Rows(0).ItemArray(4).ToString()
        Return promocion
    End Function

    Public Sub Guardar(promocion As EL.Beneficio)
        Dim e As New DAL.Beneficio()
        e.Guardar(promocion)
    End Sub

    Public Sub Quitar(promocion As EL.Beneficio)
        Dim e As New DAL.Beneficio()
        e.Quitar(promocion)
    End Sub
End Class
