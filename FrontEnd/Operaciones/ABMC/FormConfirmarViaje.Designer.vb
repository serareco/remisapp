<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmarViaje
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfirmarViaje))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDestino = New System.Windows.Forms.TextBox()
        Me.TxtOrigen = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TxtHoraSalida = New System.Windows.Forms.TextBox()
        Me.TxtKilometrosRecorrer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbChofer = New System.Windows.Forms.ComboBox()
        Me.LblAvisoDemora = New System.Windows.Forms.Label()
        Me.LblBeneficios = New System.Windows.Forms.Label()
        Me.TxtDuracionEstimada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblException = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Fecha Hora Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Origen"
        '
        'TxtDestino
        '
        Me.TxtDestino.Enabled = False
        Me.TxtDestino.Location = New System.Drawing.Point(137, 53)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.Size = New System.Drawing.Size(210, 20)
        Me.TxtDestino.TabIndex = 20
        '
        'TxtOrigen
        '
        Me.TxtOrigen.Enabled = False
        Me.TxtOrigen.Location = New System.Drawing.Point(137, 26)
        Me.TxtOrigen.Name = "TxtOrigen"
        Me.TxtOrigen.Size = New System.Drawing.Size(210, 20)
        Me.TxtOrigen.TabIndex = 19
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(43, 259)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(123, 23)
        Me.BtnGuardar.TabIndex = 31
        Me.BtnGuardar.Text = "Confirmar Viaje"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(235, 259)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(112, 23)
        Me.BtnCerrar.TabIndex = 32
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'TxtHoraSalida
        '
        Me.TxtHoraSalida.Enabled = False
        Me.TxtHoraSalida.Location = New System.Drawing.Point(137, 80)
        Me.TxtHoraSalida.Name = "TxtHoraSalida"
        Me.TxtHoraSalida.Size = New System.Drawing.Size(210, 20)
        Me.TxtHoraSalida.TabIndex = 33
        '
        'TxtKilometrosRecorrer
        '
        Me.TxtKilometrosRecorrer.Enabled = False
        Me.TxtKilometrosRecorrer.Location = New System.Drawing.Point(137, 106)
        Me.TxtKilometrosRecorrer.Name = "TxtKilometrosRecorrer"
        Me.TxtKilometrosRecorrer.Size = New System.Drawing.Size(210, 20)
        Me.TxtKilometrosRecorrer.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Kilometros"
        '
        'TxtValor
        '
        Me.TxtValor.Enabled = False
        Me.TxtValor.Location = New System.Drawing.Point(137, 130)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(210, 20)
        Me.TxtValor.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Chofer"
        '
        'cbbChofer
        '
        Me.cbbChofer.FormattingEnabled = True
        Me.cbbChofer.Location = New System.Drawing.Point(137, 190)
        Me.cbbChofer.Name = "cbbChofer"
        Me.cbbChofer.Size = New System.Drawing.Size(210, 21)
        Me.cbbChofer.TabIndex = 50
        '
        'LblAvisoDemora
        '
        Me.LblAvisoDemora.AutoSize = True
        Me.LblAvisoDemora.Location = New System.Drawing.Point(40, 215)
        Me.LblAvisoDemora.Name = "LblAvisoDemora"
        Me.LblAvisoDemora.Size = New System.Drawing.Size(0, 13)
        Me.LblAvisoDemora.TabIndex = 43
        '
        'LblBeneficios
        '
        Me.LblBeneficios.AutoSize = True
        Me.LblBeneficios.Location = New System.Drawing.Point(40, 241)
        Me.LblBeneficios.Name = "LblBeneficios"
        Me.LblBeneficios.Size = New System.Drawing.Size(0, 13)
        Me.LblBeneficios.TabIndex = 44
        '
        'TxtDuracionEstimada
        '
        Me.TxtDuracionEstimada.Enabled = False
        Me.TxtDuracionEstimada.Location = New System.Drawing.Point(137, 160)
        Me.TxtDuracionEstimada.Name = "TxtDuracionEstimada"
        Me.TxtDuracionEstimada.Size = New System.Drawing.Size(210, 20)
        Me.TxtDuracionEstimada.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Duracion Estimada"
        '
        'LblException
        '
        Me.LblException.AutoSize = True
        Me.LblException.ForeColor = System.Drawing.Color.DarkRed
        Me.LblException.Location = New System.Drawing.Point(40, 7)
        Me.LblException.Name = "LblException"
        Me.LblException.Size = New System.Drawing.Size(0, 13)
        Me.LblException.TabIndex = 47
        '
        'FormConfirmarViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(405, 299)
        Me.Controls.Add(Me.LblException)
        Me.Controls.Add(Me.TxtDuracionEstimada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblBeneficios)
        Me.Controls.Add(Me.LblAvisoDemora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbChofer)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtKilometrosRecorrer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtHoraSalida)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDestino)
        Me.Controls.Add(Me.TxtOrigen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConfirmarViaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDestino As TextBox
    Friend WithEvents TxtOrigen As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TxtHoraSalida As TextBox
    Friend WithEvents TxtKilometrosRecorrer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbChofer As ComboBox
    Friend WithEvents LblAvisoDemora As Label
    Friend WithEvents LblBeneficios As Label
    Friend WithEvents TxtDuracionEstimada As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LblException As Label
End Class
