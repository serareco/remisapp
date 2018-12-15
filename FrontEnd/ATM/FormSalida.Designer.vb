<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalida))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtKilometrosRecorridos = New System.Windows.Forms.TextBox()
        Me.gbxViajes = New System.Windows.Forms.GroupBox()
        Me.dtpFechaArribo = New System.Windows.Forms.DateTimePicker()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.gbxViajes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio Estimado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Kms Estimados"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(125, 76)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(209, 20)
        Me.TxtPrecio.TabIndex = 10
        '
        'TxtKilometrosRecorridos
        '
        Me.TxtKilometrosRecorridos.Location = New System.Drawing.Point(125, 51)
        Me.TxtKilometrosRecorridos.Name = "TxtKilometrosRecorridos"
        Me.TxtKilometrosRecorridos.Size = New System.Drawing.Size(209, 20)
        Me.TxtKilometrosRecorridos.TabIndex = 9
        '
        'gbxViajes
        '
        Me.gbxViajes.Controls.Add(Me.Label2)
        Me.gbxViajes.Controls.Add(Me.Label4)
        Me.gbxViajes.Controls.Add(Me.Label1)
        Me.gbxViajes.Controls.Add(Me.dtpFechaArribo)
        Me.gbxViajes.Controls.Add(Me.TxtPrecio)
        Me.gbxViajes.Controls.Add(Me.BtnCerrar)
        Me.gbxViajes.Controls.Add(Me.TxtKilometrosRecorridos)
        Me.gbxViajes.Controls.Add(Me.BtnGuardar)
        Me.gbxViajes.Location = New System.Drawing.Point(12, 12)
        Me.gbxViajes.Name = "gbxViajes"
        Me.gbxViajes.Size = New System.Drawing.Size(358, 216)
        Me.gbxViajes.TabIndex = 16
        Me.gbxViajes.TabStop = False
        Me.gbxViajes.Text = "Registro Salida"
        '
        'dtpFechaArribo
        '
        Me.dtpFechaArribo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFechaArribo.Location = New System.Drawing.Point(125, 101)
        Me.dtpFechaArribo.Name = "dtpFechaArribo"
        Me.dtpFechaArribo.Size = New System.Drawing.Size(209, 20)
        Me.dtpFechaArribo.TabIndex = 10
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
        'FormSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 244)
        Me.Controls.Add(Me.gbxViajes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalida"
        Me.Text = "FormSalida"
        Me.gbxViajes.ResumeLayout(False)
        Me.gbxViajes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtKilometrosRecorridos As TextBox
    Friend WithEvents gbxViajes As GroupBox
    Friend WithEvents dtpFechaArribo As DateTimePicker
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnGuardar As Button
End Class
