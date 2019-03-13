<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArribo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormArribo))
        Me.TxtKilometrosRecorridos = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEspera = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxViajes = New System.Windows.Forms.GroupBox()
        Me.dtpFechaArribo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbTipoEstadoViaje = New System.Windows.Forms.ComboBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.gbxViajes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtKilometrosRecorridos
        '
        Me.TxtKilometrosRecorridos.Location = New System.Drawing.Point(152, 37)
        Me.TxtKilometrosRecorridos.Name = "TxtKilometrosRecorridos"
        Me.TxtKilometrosRecorridos.Size = New System.Drawing.Size(188, 20)
        Me.TxtKilometrosRecorridos.TabIndex = 0
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(152, 62)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(188, 20)
        Me.TxtPrecio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kilometros Recorridos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIempo Espera"
        '
        'TxtEspera
        '
        Me.TxtEspera.Location = New System.Drawing.Point(152, 88)
        Me.TxtEspera.Name = "TxtEspera"
        Me.TxtEspera.Size = New System.Drawing.Size(188, 20)
        Me.TxtEspera.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Arribo"
        '
        'gbxViajes
        '
        Me.gbxViajes.Controls.Add(Me.Label4)
        Me.gbxViajes.Controls.Add(Me.Label2)
        Me.gbxViajes.Controls.Add(Me.Label3)
        Me.gbxViajes.Controls.Add(Me.dtpFechaArribo)
        Me.gbxViajes.Controls.Add(Me.Label5)
        Me.gbxViajes.Controls.Add(Me.cbbTipoEstadoViaje)
        Me.gbxViajes.Controls.Add(Me.BtnCerrar)
        Me.gbxViajes.Controls.Add(Me.BtnGuardar)
        Me.gbxViajes.Location = New System.Drawing.Point(12, 12)
        Me.gbxViajes.Name = "gbxViajes"
        Me.gbxViajes.Size = New System.Drawing.Size(358, 216)
        Me.gbxViajes.TabIndex = 8
        Me.gbxViajes.TabStop = False
        Me.gbxViajes.Text = "Registro Arribo"
        '
        'dtpFechaArribo
        '
        Me.dtpFechaArribo.Enabled = False
        Me.dtpFechaArribo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFechaArribo.Location = New System.Drawing.Point(140, 101)
        Me.dtpFechaArribo.Name = "dtpFechaArribo"
        Me.dtpFechaArribo.Size = New System.Drawing.Size(188, 20)
        Me.dtpFechaArribo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Estado Final"
        '
        'cbbTipoEstadoViaje
        '
        Me.cbbTipoEstadoViaje.FormattingEnabled = True
        Me.cbbTipoEstadoViaje.Location = New System.Drawing.Point(140, 128)
        Me.cbbTipoEstadoViaje.Name = "cbbTipoEstadoViaje"
        Me.cbbTipoEstadoViaje.Size = New System.Drawing.Size(188, 21)
        Me.cbbTipoEstadoViaje.TabIndex = 2
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(193, 187)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(88, 187)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FormArribo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 244)
        Me.Controls.Add(Me.TxtEspera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtKilometrosRecorridos)
        Me.Controls.Add(Me.gbxViajes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormArribo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informar Arribo"
        Me.gbxViajes.ResumeLayout(False)
        Me.gbxViajes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKilometrosRecorridos As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEspera As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbxViajes As GroupBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbTipoEstadoViaje As ComboBox
    Friend WithEvents dtpFechaArribo As DateTimePicker
End Class
