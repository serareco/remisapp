Public Class TicketComprobante
    Dim ticketComprobanteDAL As New DAL.TicketComprobante()
    Public Sub Guardar(ByRef pticketComprobante As EL.TicketComprobante)
        ticketComprobanteDAL.Guardar(pticketComprobante)
    End Sub
End Class
