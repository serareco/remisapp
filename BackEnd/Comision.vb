Public Class Comision
    Public Function Mostrar() As DataTable
        Return New DAL.Comision().Mostrar()
    End Function

    Public Function MostrarVigentes() As DataTable
        Return New DAL.Comision().MostrarVigentes()
    End Function

    Public Function GetById(pId As Int16) As EL.Comision
        Dim comision As New EL.Comision()
        Dim datatable As DataTable
        datatable = New DAL.Comision().GetById(pId)
        comision.Id = datatable.Rows(0).ItemArray(0).ToString()
        comision.Porcentaje = datatable.Rows(0).ItemArray(1).ToString()
        comision.Descripcion = datatable.Rows(0).ItemArray(2).ToString()
        comision.VigenciaDesde = datatable.Rows(0).ItemArray(3).ToString()
        If Not datatable.Rows(0).ItemArray(4).ToString() = "" Then
            comision.VigenciaHasta = datatable.Rows(0).ItemArray(4).ToString()
        End If
        Return comision
    End Function

    Public Sub Guardar(comision As EL.Comision)
        Dim e As New DAL.Comision()
        e.Guardar(comision)
    End Sub

    Public Sub Quitar(comision As EL.Comision)
        Dim e As New DAL.Comision()
        e.Quitar(comision)
    End Sub
End Class
