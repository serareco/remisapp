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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.ClbRoles = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRepetirPassword = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
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
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 264)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtUsuario)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TxtPassword)
        Me.TabPage2.Controls.Add(Me.ClbRoles)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtRepetirPassword)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(334, 238)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Usuario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(116, 20)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(204, 20)
        Me.TxtUsuario.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Contraseña"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(116, 46)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(204, 20)
        Me.TxtPassword.TabIndex = 7
        '
        'ClbRoles
        '
        Me.ClbRoles.FormattingEnabled = True
        Me.ClbRoles.Location = New System.Drawing.Point(116, 96)
        Me.ClbRoles.Name = "ClbRoles"
        Me.ClbRoles.Size = New System.Drawing.Size(204, 124)
        Me.ClbRoles.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Roles"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Repetir Contraseña"
        '
        'TxtRepetirPassword
        '
        Me.TxtRepetirPassword.Location = New System.Drawing.Point(116, 70)
        Me.TxtRepetirPassword.Name = "TxtRepetirPassword"
        Me.TxtRepetirPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtRepetirPassword.Size = New System.Drawing.Size(204, 20)
        Me.TxtRepetirPassword.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtNroDocumento)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.dtpFechaNacimiento)
        Me.TabPage1.Controls.Add(Me.TxtTelefono)
        Me.TabPage1.Controls.Add(Me.TxtNombre)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtApellido)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(334, 238)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.TxtProvincia)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.TxtLocalidad)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TxtCalle)
        Me.TabPage3.Controls.Add(Me.TxtNumero)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.TxtCP)
        Me.TabPage3.Controls.Add(Me.TxtPiso)
        Me.TabPage3.Controls.Add(Me.TxtDpto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(334, 238)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Domicilio"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 358)
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ClbRoles As CheckedListBox
    Friend WithEvents TxtRepetirPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label6 As Label
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
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
End Class
