Imports System.Net
Imports System.Net.Mail

Module GestorCorreo

    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarTicketComprobante(pTicketComprobante As EL.TicketComprobante)
        enviarCorreo(pTicketComprobante.Viaje.Socio.Email, "Gracias por viajar con nosotros!", "Recibo de Remisapp", "pdf/ComprobanteNro" + pTicketComprobante.Id.ToString + ".pdf")
    End Sub

    Sub enviarCorreo(ByVal pDestinatario As String, mensaje As String, asunto As String, pAttachmentFile As String)
        Dim emisor As String = "remisapp.uai@gmail.com"
        Dim password As String = "remisapp2019"
        correos.To.Clear()
        correos.Body = ""
        correos.Subject = ""
        correos.Body = mensaje
        correos.Subject = asunto
        correos.IsBodyHtml = True
        correos.To.Add(Trim(pDestinatario))
        correos.Attachments.Add(New Attachment(pAttachmentFile))
        correos.From = New MailAddress(emisor)

        envios.Credentials = New NetworkCredential(emisor, password)

        envios.Host = "smtp.gmail.com"
        envios.Port = 587
        envios.EnableSsl = True
        envios.Send(correos)

    End Sub

End Module