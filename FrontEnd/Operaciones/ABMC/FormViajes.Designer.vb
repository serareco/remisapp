<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViajes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChbSalidaInmediata = New System.Windows.Forms.CheckBox()
        Me.ChbIdayVuelta = New System.Windows.Forms.CheckBox()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.cbbCliente = New System.Windows.Forms.ComboBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelarViaje = New System.Windows.Forms.Button()
        Me.dgvViajes = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.ChbSalidaInmediata)
        Me.GroupBox1.Controls.Add(Me.ChbIdayVuelta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSalida)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.cbbCliente)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.txtOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Viaje"
        '
        'ChbSalidaInmediata
        '
        Me.ChbSalidaInmediata.AutoSize = True
        Me.ChbSalidaInmediata.Location = New System.Drawing.Point(121, 125)
        Me.ChbSalidaInmediata.Name = "ChbSalidaInmediata"
        Me.ChbSalidaInmediata.Size = New System.Drawing.Size(104, 17)
        Me.ChbSalidaInmediata.TabIndex = 18
        Me.ChbSalidaInmediata.Text = "Salida Inmediata"
        Me.ChbSalidaInmediata.UseVisualStyleBackColor = True
        '
        'ChbIdayVuelta
        '
        Me.ChbIdayVuelta.AutoSize = True
        Me.ChbIdayVuelta.Location = New System.Drawing.Point(121, 185)
        Me.ChbIdayVuelta.Name = "ChbIdayVuelta"
        Me.ChbIdayVuelta.Size = New System.Drawing.Size(82, 17)
        Me.ChbIdayVuelta.TabIndex = 17
        Me.ChbIdayVuelta.Text = "Ida y Vuelta"
        Me.ChbIdayVuelta.UseVisualStyleBackColor = True
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFechaSalida.Location = New System.Drawing.Point(121, 152)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaSalida.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Origen"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(142, 284)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(27, 284)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Consultar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'cbbCliente
        '
        Me.cbbCliente.FormattingEnabled = True
        Me.cbbCliente.Location = New System.Drawing.Point(121, 99)
        Me.cbbCliente.Name = "cbbCliente"
        Me.cbbCliente.Size = New System.Drawing.Size(210, 21)
        Me.cbbCliente.TabIndex = 3
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(121, 71)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(210, 20)
        Me.txtDestino.TabIndex = 1
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(121, 44)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(210, 20)
        Me.txtOrigen.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCancelarViaje)
        Me.GroupBox2.Controls.Add(Me.dgvViajes)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 318)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Viajes en Curso"
        '
        'BtnCancelarViaje
        '
        Me.BtnCancelarViaje.Location = New System.Drawing.Point(6, 284)
        Me.BtnCancelarViaje.Name = "BtnCancelarViaje"
        Me.BtnCancelarViaje.Size = New System.Drawing.Size(131, 23)
        Me.BtnCancelarViaje.TabIndex = 2
        Me.BtnCancelarViaje.Text = "Cancelar Viaje"
        Me.BtnCancelarViaje.UseVisualStyleBackColor = True
        '
        'dgvViajes
        '
        Me.dgvViajes.AllowUserToAddRows = False
        Me.dgvViajes.AllowUserToDeleteRows = False
        Me.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViajes.Location = New System.Drawing.Point(6, 19)
        Me.dgvViajes.MultiSelect = False
        Me.dgvViajes.Name = "dgvViajes"
        Me.dgvViajes.ReadOnly = True
        Me.dgvViajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViajes.Size = New System.Drawing.Size(614, 254)
        Me.dgvViajes.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(256, 284)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 41
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FormViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormViajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viajes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents cbbCliente As ComboBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvViajes As DataGridView
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents BtnCancelarViaje As Button
    Friend WithEvents ChbSalidaInmediata As CheckBox
    Friend WithEvents ChbIdayVuelta As CheckBox
    Friend WithEvents BtnLimpiar As Button
End Class
