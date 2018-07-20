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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbbTipoEstadoViaje = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.cbbIdaYVuelta = New System.Windows.Forms.ComboBox()
        Me.cbbCliente = New System.Windows.Forms.ComboBox()
        Me.cbbChofer = New System.Windows.Forms.ComboBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNotificarArribo = New System.Windows.Forms.Button()
        Me.dgvViajes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbbTipoEstadoViaje)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSalida)
        Me.GroupBox1.Controls.Add(Me.cbbIdaYVuelta)
        Me.GroupBox1.Controls.Add(Me.cbbCliente)
        Me.GroupBox1.Controls.Add(Me.cbbChofer)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.txtOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Viaje"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado"
        '
        'cbbTipoEstadoViaje
        '
        Me.cbbTipoEstadoViaje.FormattingEnabled = True
        Me.cbbTipoEstadoViaje.Location = New System.Drawing.Point(121, 220)
        Me.cbbTipoEstadoViaje.Name = "cbbTipoEstadoViaje"
        Me.cbbTipoEstadoViaje.Size = New System.Drawing.Size(227, 21)
        Me.cbbTipoEstadoViaje.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Es Ida y Vuelta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Chofer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Origen"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(148, 279)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(27, 279)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Location = New System.Drawing.Point(121, 166)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(227, 20)
        Me.dtpFechaSalida.TabIndex = 5
        '
        'cbbIdaYVuelta
        '
        Me.cbbIdaYVuelta.FormattingEnabled = True
        Me.cbbIdaYVuelta.Items.AddRange(New Object() {"S", "N"})
        Me.cbbIdaYVuelta.Location = New System.Drawing.Point(121, 192)
        Me.cbbIdaYVuelta.Name = "cbbIdaYVuelta"
        Me.cbbIdaYVuelta.Size = New System.Drawing.Size(227, 21)
        Me.cbbIdaYVuelta.TabIndex = 4
        '
        'cbbCliente
        '
        Me.cbbCliente.FormattingEnabled = True
        Me.cbbCliente.Location = New System.Drawing.Point(121, 139)
        Me.cbbCliente.Name = "cbbCliente"
        Me.cbbCliente.Size = New System.Drawing.Size(227, 21)
        Me.cbbCliente.TabIndex = 3
        '
        'cbbChofer
        '
        Me.cbbChofer.FormattingEnabled = True
        Me.cbbChofer.Location = New System.Drawing.Point(121, 111)
        Me.cbbChofer.Name = "cbbChofer"
        Me.cbbChofer.Size = New System.Drawing.Size(227, 21)
        Me.cbbChofer.TabIndex = 2
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(121, 84)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(227, 20)
        Me.txtDestino.TabIndex = 1
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(121, 57)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(227, 20)
        Me.txtOrigen.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNotificarArribo)
        Me.GroupBox2.Controls.Add(Me.dgvViajes)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 318)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Viajes en Curso"
        '
        'BtnNotificarArribo
        '
        Me.BtnNotificarArribo.Location = New System.Drawing.Point(6, 279)
        Me.BtnNotificarArribo.Name = "BtnNotificarArribo"
        Me.BtnNotificarArribo.Size = New System.Drawing.Size(102, 23)
        Me.BtnNotificarArribo.TabIndex = 1
        Me.BtnNotificarArribo.Text = "Notificar Arribo"
        Me.BtnNotificarArribo.UseVisualStyleBackColor = True
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
        'FormViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 358)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents cbbIdaYVuelta As ComboBox
    Friend WithEvents cbbCliente As ComboBox
    Friend WithEvents cbbChofer As ComboBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvViajes As DataGridView
    Friend WithEvents BtnNotificarArribo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbbTipoEstadoViaje As ComboBox
End Class
