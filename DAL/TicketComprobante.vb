Public Class TicketComprobante
    Public Sub Guardar(pticketComprobante As EL.TicketComprobante)
        Dim con As New Conexion
        Dim pRespuesta As New SqlClient.SqlParameter("@id_ticket_comprobante", SqlDbType.Decimal)
        Dim parametros As New List(Of SqlClient.SqlParameter)
        parametros.Add(New SqlClient.SqlParameter("@id_viaje", pticketComprobante.Viaje.Id))
        parametros.Add(New SqlClient.SqlParameter("@fecha_emision", pticketComprobante.FechaEmision))
        pRespuesta.Direction = ParameterDirection.Output
        parametros.Add(pRespuesta)
        con.EjecutarStoredProcedure("dbo.GuardarTicketComprobante", parametros)
        pticketComprobante.Id = pRespuesta.Value
    End Sub
End Class
