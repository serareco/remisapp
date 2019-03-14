Imports System.Drawing
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics

Module GestorPDF
    Dim parametroService As New Parametro()
    Public Sub ImprimirTicketComprobante(pTicketComprobante As EL.TicketComprobante)
        Dim document As New PdfDocument()
        Dim page As PdfPage = document.Pages.Add()
        Dim graphics As PdfGraphics = page.Graphics
        Dim path As String = My.Application.Info.DirectoryPath
        graphics.DrawImage(PdfImage.FromFile("Images\Car-icon_XL.png"), 25, 25)
        Console.Write(path)
        graphics.DrawString("Powered by Remisapp", New PdfStandardFont(PdfFontFamily.Helvetica, 8), PdfBrushes.Black, New PointF(35, 130))
        graphics.DrawRectangle(New PdfPen(PdfBrushes.Black), New RectangleF(247.5, 0, 35, 35))
        graphics.DrawString(parametroService.GetValueByKey("TIPO_FACTURA"), New PdfStandardFont(PdfFontFamily.Helvetica, 35), PdfBrushes.Black, New PointF(253.5, -1.5))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 0), New PointF(515, 0))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 150), New PointF(515, 150))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 175), New PointF(515, 175))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 200), New PointF(515, 200))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 400), New PointF(515, 400))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 425), New PointF(515, 425))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(265, 35), New PointF(265, 150))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(0, 0), New PointF(0, 425))
        graphics.DrawLine(New PdfPen(PdfBrushes.Black), New PointF(515, 0), New PointF(515, 425))
        graphics.DrawRectangle(New PdfPen(PdfBrushes.Black), New RectangleF(415, 400, 100, 25))

        graphics.DrawString("Agencia: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(130, 45))
        graphics.DrawString("Dirección: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(130, 60))
        graphics.DrawString("C.P.: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(130, 75))
        graphics.DrawString("Prov.: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(130, 90))
        graphics.DrawString("Tel:", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(130, 105))

        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_NOMBRE"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(176, 45))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_CALLE") + " " + parametroService.GetValueByKey("AGENCIA_NRO"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(176, 60))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_CP"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(176, 75))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_PROV"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(176, 90))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_TEL"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(176, 105))

        graphics.DrawString("Nro. Comp.: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(300, 45))
        graphics.DrawString("Fecha: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(300, 60))
        graphics.DrawString("CUIT: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(300, 75))
        graphics.DrawString("IIBB: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(300, 90))
        graphics.DrawString("Ini. Act.: ", New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(300, 105))

        graphics.DrawString(pTicketComprobante.Id, New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(370, 45))
        graphics.DrawString(Now.ToShortDateString + " " + Now.ToShortTimeString, New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(370, 60))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_CUIT"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(370, 75))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_IIBB"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(370, 90))
        graphics.DrawString(parametroService.GetValueByKey("AGENCIA_INI_ACT"), New PdfStandardFont(PdfFontFamily.Helvetica, 10), PdfBrushes.Black, New PointF(370, 105))

        graphics.DrawString("Apellido, Nombre", New PdfStandardFont(PdfFontFamily.Helvetica, 8), PdfBrushes.Black, New PointF(5, 151))
        graphics.DrawString("Domicilio", New PdfStandardFont(PdfFontFamily.Helvetica, 8), PdfBrushes.Black, New PointF(5, 176))
        graphics.DrawString("Detalle del viaje: ", New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 205))
        graphics.DrawString("  >> Origen: " + pTicketComprobante.Viaje.Origen, New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 225))
        graphics.DrawString("  >> Destino: " + pTicketComprobante.Viaje.Destino, New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 245))
        graphics.DrawString("  >> Duración: " + pTicketComprobante.Viaje.Duracion.ToString(), New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 265))

        If Not (pTicketComprobante.Viaje.Beneficios Is Nothing) Then
            Dim descuentosTotales As Decimal
            For Each beneficio As EL.Beneficio In pTicketComprobante.Viaje.Beneficios
                descuentosTotales += beneficio.Descuento
            Next
            graphics.DrawString("  >> Descuentos Obtenidos: %" + descuentosTotales.ToString() + " ($-" + pTicketComprobante.Viaje.Ahorro.ToString() + ")", New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 285))
        End If

        graphics.DrawString("  >> Chofer: " + pTicketComprobante.Viaje.Chofer.ToString(), New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 305))
        graphics.DrawString("Total $ ", New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(365, 405))

        'datos del viaje
        graphics.DrawString(pTicketComprobante.Viaje.Socio.ToString(), New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 160))
        graphics.DrawString(pTicketComprobante.Viaje.Socio.Domicilio.ToString(), New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(5, 185))
        graphics.DrawString(pTicketComprobante.Viaje.Precio.ToString(), New PdfStandardFont(PdfFontFamily.Helvetica, 12), PdfBrushes.Black, New PointF(430, 405))
        'Save the document
        document.Save("pdf/ComprobanteNro" + pTicketComprobante.Id.ToString() + ".pdf")
        'Close the document
        document.Close(True)
    End Sub

    Public Sub EliminarTicketComprobante(pId As Int16)
        My.Computer.FileSystem.DeleteFile("pdf/ComprobanteNro" + pId.ToString() + ".pdf")
    End Sub

End Module