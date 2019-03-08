Public Class TicketComprobante
    Public Sub Guardar(ByRef pticketComprobante As EL.TicketComprobante)
        Dim con As New Conexion
        Dim pRespuesta As New SqlClient.SqlParameter("@Respuesta", SqlDbType.Int)
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@fecha_emision", pticketComprobante.FechaEmision))
        parametros.Add(New SqlClient.SqlParameter("@id_viaje", pticketComprobante.Viaje.Id))
        parametros.Add(pRespuesta)
        con.EjecutarStoredProcedure("dbo.GuardarTicketComprobante", parametros)
        pticketComprobante.Id = pRespuesta.Value
    End Sub
End Class
