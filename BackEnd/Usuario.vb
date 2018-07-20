Imports BackEnd
Public Class Usuario
    Inherits Persona : Implements IEmpleado
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _password As String
    Public Property Password() As String
        Private Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _fechaNacimiento As String
    Public Property FechaNacimiento As String Implements IEmpleado.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nroDocumento As String
    Public Property NroDocumento As String Implements IEmpleado.NroDocumento
        Get
            Return _nroDocumento
        End Get
        Set(ByVal value As String)
            _nroDocumento = value
        End Set
    End Property

    Public Function MostrarLista()
        Dim con As New Conexion
        Dim datatable As New DataTable
        con.EjecutarConsulta("     
        select u.id_usuario, p.apellido, p.nombre, u.nro_documento, p.telefono, p.domicilio
        from Usuarios u inner join Personas p on u.id_persona = p.id_persona")
        con.adp.Fill(datatable)
        Return datatable
    End Function

    Public Sub Guardar()
        Dim con As New Conexion
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@usuario", Me.Usuario))
        parametros.Add(New SqlClient.SqlParameter("@password", Me.Password))
        parametros.Add(New SqlClient.SqlParameter("@fecha_nacimiento", Me.FechaNacimiento))
        parametros.Add(New SqlClient.SqlParameter("@nro_documento", Me.NroDocumento))
        parametros.Add(New SqlClient.SqlParameter("@nombre", Me.Nombre))
        parametros.Add(New SqlClient.SqlParameter("@apellido", Me.Apellido))
        parametros.Add(New SqlClient.SqlParameter("@domicilio", Me.Domicilio))
        parametros.Add(New SqlClient.SqlParameter("@telefono", Me.Telefono))
        parametros.Add(New SqlClient.SqlParameter("@email", Me.Email))
        con.EjecutarStoredProcedure("dbo.GuardarUsuario", parametros)
    End Sub
End Class
