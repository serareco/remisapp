Public Class Auto
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _marca As String
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property
    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property
    Private _anioFabricacion As Int16
    Public Property AnioFabricacion() As Int16
        Get
            Return _anioFabricacion
        End Get
        Set(ByVal value As Int16)
            _anioFabricacion = value
        End Set
    End Property
    Private _patente As String
    Public Property Patente() As String
        Get
            Return _patente
        End Get
        Set(ByVal value As String)
            _patente = value
        End Set
    End Property
    Private _chasis As String
    Public Property Chasis() As String
        Get
            Return _chasis
        End Get
        Set(ByVal value As String)
            _chasis = value
        End Set
    End Property
    Private _motor As String
    Public Property Motor() As String
        Get
            Return _motor
        End Get
        Set(ByVal value As String)
            _motor = value
        End Set
    End Property
    Public Function Mostrar()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select a.id_auto, am.descripcion Marca,amo.descripcion Modelo,a.Patente,a.Anio_Fabricacion,a.Chasis,a.Motor
         From dbo.Autos a inner join Autos_Modelos amo 
         on a.id_Modelo = amo.id_modelo 
         Inner Join Autos_Marcas am on 
         amo.id_Marca = am.id_marca and amo.id_marca = am.id_marca
        Where a.estado = 'A'")

        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarDisponibles()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
Select 0 id_auto,'Seleccione una opción' descripcion union
select a.id_auto, a.Patente +' - '+ am.descripcion + ' ' + amo.descripcion descripcion
 From dbo.Autos a inner join Autos_Modelos amo 
 on a.id_Modelo = amo.id_modelo 
 Inner Join Autos_Marcas am on 
 amo.id_Marca = am.id_marca and amo.id_marca = am.id_marca 
Where a.estado = 'A' ")

        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarMarcas()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("Select 0 id_marca,'Seleccione una opción' descripcion union Select * From dbo.Autos_Marcas")
        con.adp.Fill(datatable)
        Return datatable
    End Function
    Public Function MostrarModelos(pIdMarca As Int16)
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("Select 0 id_marca, 0 id_modelo, 'Seleccione una opción' descripcion union Select * From dbo.Autos_Modelos where id_marca = " & pIdMarca.ToString())
        con.adp.Fill(datatable)
        Return datatable
    End Function
    Public Sub GetById(pId As Int16)
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select * from Autos where id_auto = " & pId)
        con.adp.Fill(datatable)
        Me.Id = datatable.Rows(0).ItemArray(0).ToString()
        Me.Marca = datatable.Rows(0).ItemArray(1).ToString()
        Me.Modelo = datatable.Rows(0).ItemArray(2).ToString()
        Me.AnioFabricacion = datatable.Rows(0).ItemArray(3).ToString()
        Me.Patente = datatable.Rows(0).ItemArray(4).ToString()
        Me.Motor = datatable.Rows(0).ItemArray(5).ToString()
        Me.Chasis = datatable.Rows(0).ItemArray(6).ToString()
    End Sub
    Public Sub Guardar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@Id_Auto", Me.Id))
        parametros.Add(New SqlClient.SqlParameter("@Id_Marca", Me.Marca))
        parametros.Add(New SqlClient.SqlParameter("@Id_Modelo", Me.Modelo))
        parametros.Add(New SqlClient.SqlParameter("@Anio_Fabricacion", Me.AnioFabricacion))
        parametros.Add(New SqlClient.SqlParameter("@Patente", Me.Patente))
        parametros.Add(New SqlClient.SqlParameter("@Chasis", Me.Chasis))
        parametros.Add(New SqlClient.SqlParameter("@Motor", Me.Motor))

        con.EjecutarStoredProcedure("dbo.GuardarAuto", parametros)
    End Sub

    Public Sub Quitar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_auto", Me.Id))
        con.EjecutarStoredProcedure("dbo.QuitarAuto", parametros)
        'TODO: TIENE CHOFER ASOCIADO!
    End Sub
End Class
