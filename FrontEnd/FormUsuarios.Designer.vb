<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPermisos = New System.Windows.Forms.TabPage()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ClbRoles = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabDatosPersonales = New System.Windows.Forms.TabPage()
        Me.TxtNroDocumento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabDomicilio = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtPiso = New System.Windows.Forms.TextBox()
        Me.TxtDpto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnBlanqueoPss = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPermisos.SuspendLayout()
        Me.TabDatosPersonales.SuspendLayout()
        Me.TabDomicilio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.dgvUsuarios)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 334)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado dbo.Usuario"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(115, 298)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(7, 298)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 23)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(7, 19)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(613, 264)
        Me.dgvUsuarios.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabDatosPersonales)
        Me.TabControl1.Controls.Add(Me.TabDomicilio)
        Me.TabControl1.Controls.Add(Me.TabPermisos)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 273)
        Me.TabControl1.TabIndex = 5
        '
        'TabPermisos
        '
        Me.TabPermisos.Controls.Add(Me.Label6)
        Me.TabPermisos.Controls.Add(Me.BtnBlanqueoPss)
        Me.TabPermisos.Controls.Add(Me.TxtUsuario)
        Me.TabPermisos.Controls.Add(Me.Label7)
        Me.TabPermisos.Controls.Add(Me.ClbRoles)
        Me.TabPermisos.Controls.Add(Me.Label8)
        Me.TabPermisos.Location = New System.Drawing.Point(4, 22)
        Me.TabPermisos.Name = "TabPermisos"
        Me.TabPermisos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPermisos.Size = New System.Drawing.Size(334, 247)
        Me.TabPermisos.TabIndex = 1
        Me.TabPermisos.Text = "Permisos"
        Me.TabPermisos.UseVisualStyleBackColor = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Enabled = False
        Me.TxtUsuario.Location = New System.Drawing.Point(116, 12)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(204, 20)
        Me.TxtUsuario.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Usuario"
        '
        'ClbRoles
        '
        Me.ClbRoles.FormattingEnabled = True
        Me.ClbRoles.Location = New System.Drawing.Point(116, 38)
        Me.ClbRoles.Name = "ClbRoles"
        Me.ClbRoles.Size = New System.Drawing.Size(204, 124)
        Me.ClbRoles.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Roles"
        '
        'TabDatosPersonales
        '
        Me.TabDatosPersonales.Controls.Add(Me.TxtNroDocumento)
        Me.TabDatosPersonales.Controls.Add(Me.Label1)
        Me.TabDatosPersonales.Controls.Add(Me.Label11)
        Me.TabDatosPersonales.Controls.Add(Me.TxtEmail)
        Me.TabDatosPersonales.Controls.Add(Me.dtpFechaNacimiento)
        Me.TabDatosPersonales.Controls.Add(Me.TxtTelefono)
        Me.TabDatosPersonales.Controls.Add(Me.TxtNombre)
        Me.TabDatosPersonales.Controls.Add(Me.Label5)
        Me.TabDatosPersonales.Controls.Add(Me.Label4)
        Me.TabDatosPersonales.Controls.Add(Me.TxtApellido)
        Me.TabDatosPersonales.Controls.Add(Me.Label3)
        Me.TabDatosPersonales.Controls.Add(Me.Label2)
        Me.TabDatosPersonales.Location = New System.Drawing.Point(4, 22)
        Me.TabDatosPersonales.Name = "TabDatosPersonales"
        Me.TabDatosPersonales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatosPersonales.Size = New System.Drawing.Size(334, 247)
        Me.TabDatosPersonales.TabIndex = 0
        Me.TabDatosPersonales.Text = "Datos Personales"
        Me.TabDatosPersonales.UseVisualStyleBackColor = True
        '
        'TxtNroDocumento
        '
        Me.TxtNroDocumento.Location = New System.Drawing.Point(121, 84)
        Me.TxtNroDocumento.Name = "TxtNroDocumento"
        Me.TxtNroDocumento.Size = New System.Drawing.Size(199, 20)
        Me.TxtNroDocumento.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Fecha Nacimiento"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(121, 139)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(199, 20)
        Me.TxtEmail.TabIndex = 5
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(121, 165)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(199, 20)
        Me.dtpFechaNacimiento.TabIndex = 9
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(121, 112)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(199, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(121, 33)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(199, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "E-Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Teléfono"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(121, 58)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(199, 20)
        Me.TxtApellido.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nro. Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Apellido"
        '
        'TabDomicilio
        '
        Me.TabDomicilio.Controls.Add(Me.Label16)
        Me.TabDomicilio.Controls.Add(Me.TxtProvincia)
        Me.TabDomicilio.Controls.Add(Me.Label15)
        Me.TabDomicilio.Controls.Add(Me.TxtLocalidad)
        Me.TabDomicilio.Controls.Add(Me.Label12)
        Me.TabDomicilio.Controls.Add(Me.TxtCalle)
        Me.TabDomicilio.Controls.Add(Me.TxtNumero)
        Me.TabDomicilio.Controls.Add(Me.Label13)
        Me.TabDomicilio.Controls.Add(Me.Label14)
        Me.TabDomicilio.Controls.Add(Me.Label17)
        Me.TabDomicilio.Controls.Add(Me.Label18)
        Me.TabDomicilio.Controls.Add(Me.TxtCP)
        Me.TabDomicilio.Controls.Add(Me.TxtPiso)
        Me.TabDomicilio.Controls.Add(Me.TxtDpto)
        Me.TabDomicilio.Location = New System.Drawing.Point(4, 22)
        Me.TabDomicilio.Name = "TabDomicilio"
        Me.TabDomicilio.Size = New System.Drawing.Size(334, 247)
        Me.TabDomicilio.TabIndex = 2
        Me.TabDomicilio.Text = "Domicilio"
        Me.TabDomicilio.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Provincia"
        '
        'TxtProvincia
        '
        Me.TxtProvincia.Location = New System.Drawing.Point(124, 169)
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.Size = New System.Drawing.Size(196, 20)
        Me.TxtProvincia.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Localidad"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(124, 143)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(196, 20)
        Me.TxtLocalidad.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Número"
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(124, 37)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(196, 20)
        Me.TxtCalle.TabIndex = 27
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(124, 64)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(196, 20)
        Me.TxtNumero.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Calle"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Piso"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(205, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Dpto."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "C.P."
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(124, 117)
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(196, 20)
        Me.TxtCP.TabIndex = 31
        '
        'TxtPiso
        '
        Me.TxtPiso.Location = New System.Drawing.Point(124, 90)
        Me.TxtPiso.Name = "TxtPiso"
        Me.TxtPiso.Size = New System.Drawing.Size(75, 20)
        Me.TxtPiso.TabIndex = 29
        '
        'TxtDpto
        '
        Me.TxtDpto.Location = New System.Drawing.Point(237, 91)
        Me.TxtDpto.Name = "TxtDpto"
        Me.TxtDpto.Size = New System.Drawing.Size(83, 20)
        Me.TxtDpto.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 334)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Usuario"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(255, 298)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 48
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(145, 298)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(33, 298)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnBlanqueoPss
        '
        Me.BtnBlanqueoPss.Location = New System.Drawing.Point(13, 168)
        Me.BtnBlanqueoPss.Name = "BtnBlanqueoPss"
        Me.BtnBlanqueoPss.Size = New System.Drawing.Size(307, 23)
        Me.BtnBlanqueoPss.TabIndex = 38
        Me.BtnBlanqueoPss.Text = "Blanquear Contraseña"
        Me.BtnBlanqueoPss.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 36)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Nota: El blanqueo de contraseña implica que se establezca el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "número de document" &
    "o como contraseña, y que en el proximo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingreso deberá modificarla."
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPermisos.ResumeLayout(False)
        Me.TabPermisos.PerformLayout()
        Me.TabDatosPersonales.ResumeLayout(False)
        Me.TabDatosPersonales.PerformLayout()
        Me.TabDomicilio.ResumeLayout(False)
        Me.TabDomicilio.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ClbRoles As CheckedListBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtNroDocumento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabDatosPersonales As TabPage
    Friend WithEvents TabPermisos As TabPage
    Friend WithEvents TabDomicilio As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtProvincia As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtCP As TextBox
    Friend WithEvents TxtPiso As TextBox
    Friend WithEvents TxtDpto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBlanqueoPss As Button
End Class
