Public Class Cliente
    Inherits Persona
    Private _id As Int16
    Public Property Id() As Int16
        Get
            Return _id
        End Get
        Set(ByVal value As Int16)
            _id = value
        End Set
    End Property
    Private _nroCliente As String
    Public Property NroCliente() As String
        Get
            Return _nroCliente
        End Get
        Set(ByVal value As String)
            _nroCliente = value
        End Set
    End Property

    Public Sub GetById(pId As Int16)
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("select id_cliente, nro_cliente, p.nombre, p.apellido,p.domicilio,p.email,p.telefono from clientes c inner join Personas p on c.id_persona = p.id_persona where id_cliente = " & pId)
        con.adp.Fill(datatable)
        If (datatable.Rows.Count > 0) Then
            Me.Id = datatable.Rows(0).ItemArray(0).ToString()
            Me.NroCliente = datatable.Rows(0).ItemArray(1).ToString()
            Me.Nombre = datatable.Rows(0).ItemArray(2).ToString()
            Me.Apellido = datatable.Rows(0).ItemArray(3).ToString()
            Me.Domicilio = datatable.Rows(0).ItemArray(4).ToString()
            Me.Email = datatable.Rows(0).ItemArray(5).ToString()
            Me.Telefono = datatable.Rows(0).ItemArray(6).ToString()
        End If
    End Sub

    Public Function Mostrar()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("
        Select 0 id_cliente,'Seleccione una opción' descripcion union         
        select id_cliente, p.apellido + ' ' + p.nombre + ' ('+ convert(varchar(18),c.nro_cliente)+')'from Clientes c inner join Personas p on c.id_persona = p.id_persona")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Function MostrarLista()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("     
        select id_cliente, p.apellido, p.nombre, c.nro_cliente, p.telefono, p.domicilio
        from Clientes c inner join Personas p on c.id_persona = p.id_persona
        where c.estado = 'A' ")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", Me.Id))
        parametros.Add(New SqlClient.SqlParameter("@nombre", Me.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", Me.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", Me.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", Me.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", Me.Email))
        con.EjecutarStoredProcedure("dbo.GuardarCliente", parametros)
    End Sub

    Public Sub Quitar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_cliente", Me.Id))
        con.EjecutarStoredProcedure("dbo.QuitarCliente", parametros)
    End Sub

End Class
