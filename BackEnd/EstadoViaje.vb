Public Class EstadoViaje
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Function MostrarAlta()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_estado,'Seleccione una opción' descripcion union         
        select id_estado,descripcion from Tipos_Estado_Viaje where grupo = 'Alta'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarFin()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_estado,'Seleccione una opción' descripcion union         
        select id_estado,descripcion from Tipos_Estado_Viaje where grupo = 'Fin'")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub GetById(pId As Int16)
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from tipos_estado_viaje where id_estado = " & pId)
        con.adp.Fill(datatable)
        Me.Id = datatable.Rows(0).ItemArray(0).ToString()
        Me.Descripcion = datatable.Rows(0).ItemArray(1).ToString()
    End Sub

End Class
