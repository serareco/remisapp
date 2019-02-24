Public Class Turno
    Public Function GetById(pId As Int16) As EL.Turno
        Dim con As New Conexion
        Dim turno As New EL.Turno()
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select * from dbo.Turno where id_turno = " & pId)
        con.adp.Fill(datatable)
        turno.Id = datatable.Rows(0).ItemArray(0).ToString()
        turno.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
        turno.HoraEntrada = datatable.Rows(0).ItemArray(2).ToString()
        turno.HoraSalida = datatable.Rows(0).ItemArray(3).ToString()
        Return turno
    End Function

    Public Function GetByChoferId(pId As Int16) As List(Of EL.Turno)
        Dim con As New Conexion
        Dim turno As New EL.Turno()
        Dim turnos As New List(Of EL.Turno)
        Dim datatable As New DataTable()
        con.EjecutarConsulta("select id_turno from dbo.Chofer_Turno where id_persona = " & pId)
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            turnos.Add(New Turno().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return turnos
    End Function

    Public Function Listar() As List(Of EL.Turno)
        Dim con As New Conexion
        Dim datatable As New DataTable
        Dim turnos As New List(Of EL.Turno)
        con.EjecutarConsulta("select id_turno From dbo.Turno")
        con.adp.Fill(datatable)
        For index = 0 To datatable.Rows.Count - 1
            turnos.Add(New Turno().GetById(datatable.Rows(index).ItemArray(0).ToString()))
        Next
        Return turnos
    End Function
End Class
