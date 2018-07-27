Imports System.Data.SqlClient
Public Class Conexion
    Private con As SqlConnection
    Private cmd As SqlCommand
    Public rdr As SqlDataReader
    Public adp As SqlDataAdapter
    Private _sqlError As String

    Sub New()
        con = New SqlConnection()
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=remisapp;Integrated Security=True;MultipleActiveResultSets=true;"
    End Sub

    Public Property SqlError() As String
        Get
            Return _sqlError
        End Get
        Private Set(ByVal value As String)
            _sqlError = value
        End Set
    End Property

    Public Sub EjecutarStoredProcedure(pNombreStoredProcedure As String, pParametros As List(Of SqlClient.SqlParameter))
        Try
            con.Open()
            cmd = New SqlCommand(pNombreStoredProcedure, con)
            cmd.CommandType = CommandType.StoredProcedure
            For Each item As SqlClient.SqlParameter In pParametros
                cmd.Parameters.Add(item)
            Next
            rdr = cmd.ExecuteReader()
        Catch ex As Exception
            SqlError = ex.Message
            Throw ex
        Finally
            If Not (IsNothing(con)) Then
                con.Close()
            End If
            If Not (IsNothing(rdr)) Then
                rdr.Close()
            End If
        End Try
    End Sub

    Public Sub EjecutarConsulta(pConsulta As String)
        Try
            con.Open()
            adp = New SqlDataAdapter(pConsulta, con)

        Catch ex As Exception
            SqlError = ex.Message
            Throw ex
        Finally
            If Not (IsNothing(con)) Then
                con.Close()
            End If
        End Try
    End Sub
End Class
