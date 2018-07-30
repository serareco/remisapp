Public Class Chofer
    Public Function Mostrar() As DataTable
        Return New DAL.Chofer().Mostrar()
    End Function

    Public Function MostrarDisponibles() As DataTable
        Return New DAL.Chofer().MostrarDisponibles()
    End Function

    Public Function GetById(pId As Int16) As EL.Chofer
        Dim chofer As New EL.Chofer()
        Dim datatable As DataTable = New DAL.Chofer().GetById(pId)
        chofer.Id = datatable.Rows(0).ItemArray(0).ToString()
        chofer.Apellido = datatable.Rows(0).ItemArray(1).ToString()
        chofer.Nombre = datatable.Rows(0).ItemArray(2).ToString()
        chofer.Domicilio = datatable.Rows(0).ItemArray(3).ToString()
        chofer.Email = datatable.Rows(0).ItemArray(4).ToString()
        chofer.Telefono = datatable.Rows(0).ItemArray(5).ToString()
        chofer.Comision = New Comision().GetById(datatable.Rows(0).ItemArray(6).ToString())
        chofer.Auto = New Auto().GetById(datatable.Rows(0).ItemArray(7).ToString())
        chofer.FechaVencimiento = datatable.Rows(0).ItemArray(8).ToString()
        chofer.FechaNacimiento = datatable.Rows(0).ItemArray(9).ToString()
        chofer.NroDocumento = datatable.Rows(0).ItemArray(10).ToString()
        Return chofer
    End Function

    Public Sub Guardar(chofer As EL.Chofer)
        Dim e As New DAL.Chofer()
        e.Guardar(chofer)
    End Sub

    Public Sub Quitar(chofer As EL.Chofer)
        Dim e As New DAL.Chofer()
        e.Quitar(chofer)
    End Sub

End Class
