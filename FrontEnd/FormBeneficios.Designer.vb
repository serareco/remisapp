<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeneficios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBeneficios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.dgvPromociones = New System.Windows.Forms.DataGridView()
        Me.gbxComisiones = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtViajesSemanal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotalSemanal = New System.Windows.Forms.TextBox()
        Me.dtpVigenciaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpVigenciaDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxComisiones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.dgvPromociones)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 318)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Beneficios"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(115, 275)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 23)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(7, 275)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 23)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'dgvPromociones
        '
        Me.dgvPromociones.AllowUserToAddRows = False
        Me.dgvPromociones.AllowUserToDeleteRows = False
        Me.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromociones.Location = New System.Drawing.Point(7, 19)
        Me.dgvPromociones.MultiSelect = False
        Me.dgvPromociones.Name = "dgvPromociones"
        Me.dgvPromociones.ReadOnly = True
        Me.dgvPromociones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPromociones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPromociones.Size = New System.Drawing.Size(613, 249)
        Me.dgvPromociones.TabIndex = 9
        '
        'gbxComisiones
        '
        Me.gbxComisiones.Controls.Add(Me.GroupBox1)
        Me.gbxComisiones.Controls.Add(Me.dtpVigenciaHasta)
        Me.gbxComisiones.Controls.Add(Me.dtpVigenciaDesde)
        Me.gbxComisiones.Controls.Add(Me.BtnLimpiar)
        Me.gbxComisiones.Controls.Add(Me.Label4)
        Me.gbxComisiones.Controls.Add(Me.Label3)
        Me.gbxComisiones.Controls.Add(Me.Label2)
        Me.gbxComisiones.Controls.Add(Me.Label1)
        Me.gbxComisiones.Controls.Add(Me.BtnCancelar)
        Me.gbxComisiones.Controls.Add(Me.BtnGuardar)
        Me.gbxComisiones.Controls.Add(Me.txtDescripcion)
        Me.gbxComisiones.Controls.Add(Me.txtDescuento)
        Me.gbxComisiones.Location = New System.Drawing.Point(12, 20)
        Me.gbxComisiones.Name = "gbxComisiones"
        Me.gbxComisiones.Size = New System.Drawing.Size(354, 318)
        Me.gbxComisiones.TabIndex = 11
        Me.gbxComisiones.TabStop = False
        Me.gbxComisiones.Text = "Nuevo Beneficio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtViajesSemanal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtTotalSemanal)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 104)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Viajes Semanales"
        '
        'TxtViajesSemanal
        '
        Me.TxtViajesSemanal.Location = New System.Drawing.Point(136, 59)
        Me.TxtViajesSemanal.Name = "TxtViajesSemanal"
        Me.TxtViajesSemanal.Size = New System.Drawing.Size(153, 20)
        Me.TxtViajesSemanal.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Acumulado"
        '
        'TxtTotalSemanal
        '
        Me.TxtTotalSemanal.Location = New System.Drawing.Point(136, 33)
        Me.TxtTotalSemanal.Name = "TxtTotalSemanal"
        Me.TxtTotalSemanal.Size = New System.Drawing.Size(153, 20)
        Me.TxtTotalSemanal.TabIndex = 20
        '
        'dtpVigenciaHasta
        '
        Me.dtpVigenciaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVigenciaHasta.Location = New System.Drawing.Point(116, 106)
        Me.dtpVigenciaHasta.Name = "dtpVigenciaHasta"
        Me.dtpVigenciaHasta.Size = New System.Drawing.Size(217, 20)
        Me.dtpVigenciaHasta.TabIndex = 18
        '
        'dtpVigenciaDesde
        '
        Me.dtpVigenciaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVigenciaDesde.Location = New System.Drawing.Point(116, 79)
        Me.dtpVigenciaDesde.Name = "dtpVigenciaDesde"
        Me.dtpVigenciaDesde.Size = New System.Drawing.Size(217, 20)
        Me.dtpVigenciaDesde.TabIndex = 17
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(258, 275)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descuento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fin Vigencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inicio Vigencia"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(143, 275)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(22, 275)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 52)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(217, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(116, 24)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(217, 20)
        Me.txtDescuento.TabIndex = 2
        '
        'FormBeneficios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxComisiones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBeneficios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beneficios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxComisiones.ResumeLayout(False)
        Me.gbxComisiones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents dgvPromociones As DataGridView
    Friend WithEvents gbxComisiones As GroupBox
    Friend WithEvents dtpVigenciaHasta As DateTimePicker
    Friend WithEvents dtpVigenciaDesde As DateTimePicker
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtViajesSemanal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotalSemanal As TextBox
End Class
