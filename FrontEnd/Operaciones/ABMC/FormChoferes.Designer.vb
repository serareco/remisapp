<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChoferes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChoferes))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.dgvChoferes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabDatosChofer = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtNroDocumento = New System.Windows.Forms.TextBox()
        Me.TabTelefono = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtNumeroTel = New System.Windows.Forms.TextBox()
        Me.TxtCodArea = New System.Windows.Forms.TextBox()
        Me.TxtCodPais = New System.Windows.Forms.TextBox()
        Me.CbbTiposTelefono = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabDomicilio = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtPiso = New System.Windows.Forms.TextBox()
        Me.TxtDpto = New System.Windows.Forms.TextBox()
        Me.TabRegistro = New System.Windows.Forms.TabPage()
        Me.CbbTurnos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbCategorias = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaVencimientoRegistro = New System.Windows.Forms.DateTimePicker()
        Me.cbbAutos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabDatosChofer.SuspendLayout()
        Me.TabTelefono.SuspendLayout()
        Me.TabDomicilio.SuspendLayout()
        Me.TabRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.dgvChoferes)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 326)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Choferes"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(114, 297)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 23)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(6, 297)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 23)
        Me.BtnModificar.TabIndex = 13
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'dgvChoferes
        '
        Me.dgvChoferes.AllowUserToAddRows = False
        Me.dgvChoferes.AllowUserToDeleteRows = False
        Me.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChoferes.Location = New System.Drawing.Point(7, 19)
        Me.dgvChoferes.MultiSelect = False
        Me.dgvChoferes.Name = "dgvChoferes"
        Me.dgvChoferes.ReadOnly = True
        Me.dgvChoferes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChoferes.Size = New System.Drawing.Size(613, 270)
        Me.dgvChoferes.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 326)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Chofer"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabDatosChofer)
        Me.TabControl1.Controls.Add(Me.TabTelefono)
        Me.TabControl1.Controls.Add(Me.TabDomicilio)
        Me.TabControl1.Controls.Add(Me.TabRegistro)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 272)
        Me.TabControl1.TabIndex = 15
        '
        'TabDatosChofer
        '
        Me.TabDatosChofer.Controls.Add(Me.Label2)
        Me.TabDatosChofer.Controls.Add(Me.TxtNombre)
        Me.TabDatosChofer.Controls.Add(Me.TxtApellido)
        Me.TabDatosChofer.Controls.Add(Me.dtpFechaNacimiento)
        Me.TabDatosChofer.Controls.Add(Me.Label1)
        Me.TabDatosChofer.Controls.Add(Me.Label3)
        Me.TabDatosChofer.Controls.Add(Me.Label5)
        Me.TabDatosChofer.Controls.Add(Me.Label6)
        Me.TabDatosChofer.Controls.Add(Me.TxtEmail)
        Me.TabDatosChofer.Controls.Add(Me.TxtNroDocumento)
        Me.TabDatosChofer.Location = New System.Drawing.Point(4, 22)
        Me.TabDatosChofer.Name = "TabDatosChofer"
        Me.TabDatosChofer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatosChofer.Size = New System.Drawing.Size(334, 246)
        Me.TabDatosChofer.TabIndex = 0
        Me.TabDatosChofer.Text = "Datos Personales"
        Me.TabDatosChofer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(116, 38)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(196, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(116, 65)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(196, 20)
        Me.TxtApellido.TabIndex = 1
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(116, 146)
        Me.dtpFechaNacimiento.MaxDate = New Date(2018, 12, 18, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(196, 20)
        Me.dtpFechaNacimiento.TabIndex = 6
        Me.dtpFechaNacimiento.Value = New Date(2018, 7, 11, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nro. Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "E-Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha Nacimiento"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(116, 118)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(196, 20)
        Me.TxtEmail.TabIndex = 5
        '
        'TxtNroDocumento
        '
        Me.TxtNroDocumento.Location = New System.Drawing.Point(116, 91)
        Me.TxtNroDocumento.Name = "TxtNroDocumento"
        Me.TxtNroDocumento.Size = New System.Drawing.Size(196, 20)
        Me.TxtNroDocumento.TabIndex = 2
        '
        'TabTelefono
        '
        Me.TabTelefono.Controls.Add(Me.Label19)
        Me.TabTelefono.Controls.Add(Me.Label17)
        Me.TabTelefono.Controls.Add(Me.Label18)
        Me.TabTelefono.Controls.Add(Me.TxtNumeroTel)
        Me.TabTelefono.Controls.Add(Me.TxtCodArea)
        Me.TabTelefono.Controls.Add(Me.TxtCodPais)
        Me.TabTelefono.Controls.Add(Me.CbbTiposTelefono)
        Me.TabTelefono.Controls.Add(Me.Label20)
        Me.TabTelefono.Location = New System.Drawing.Point(4, 22)
        Me.TabTelefono.Name = "TabTelefono"
        Me.TabTelefono.Size = New System.Drawing.Size(334, 246)
        Me.TabTelefono.TabIndex = 3
        Me.TabTelefono.Text = "Telefono"
        Me.TabTelefono.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Número"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Cód. Área"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Cód. Pais"
        '
        'TxtNumeroTel
        '
        Me.TxtNumeroTel.Location = New System.Drawing.Point(113, 115)
        Me.TxtNumeroTel.Name = "TxtNumeroTel"
        Me.TxtNumeroTel.Size = New System.Drawing.Size(199, 20)
        Me.TxtNumeroTel.TabIndex = 12
        '
        'TxtCodArea
        '
        Me.TxtCodArea.Location = New System.Drawing.Point(113, 87)
        Me.TxtCodArea.Name = "TxtCodArea"
        Me.TxtCodArea.Size = New System.Drawing.Size(199, 20)
        Me.TxtCodArea.TabIndex = 11
        '
        'TxtCodPais
        '
        Me.TxtCodPais.Location = New System.Drawing.Point(113, 57)
        Me.TxtCodPais.Name = "TxtCodPais"
        Me.TxtCodPais.Size = New System.Drawing.Size(199, 20)
        Me.TxtCodPais.TabIndex = 10
        '
        'CbbTiposTelefono
        '
        Me.CbbTiposTelefono.FormattingEnabled = True
        Me.CbbTiposTelefono.Location = New System.Drawing.Point(113, 27)
        Me.CbbTiposTelefono.Name = "CbbTiposTelefono"
        Me.CbbTiposTelefono.Size = New System.Drawing.Size(199, 21)
        Me.CbbTiposTelefono.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Tipo Teléfono"
        '
        'TabDomicilio
        '
        Me.TabDomicilio.Controls.Add(Me.Label16)
        Me.TabDomicilio.Controls.Add(Me.TxtProvincia)
        Me.TabDomicilio.Controls.Add(Me.Label15)
        Me.TabDomicilio.Controls.Add(Me.TxtLocalidad)
        Me.TabDomicilio.Controls.Add(Me.Label9)
        Me.TabDomicilio.Controls.Add(Me.TxtCalle)
        Me.TabDomicilio.Controls.Add(Me.TxtNumero)
        Me.TabDomicilio.Controls.Add(Me.Label10)
        Me.TabDomicilio.Controls.Add(Me.Label12)
        Me.TabDomicilio.Controls.Add(Me.Label13)
        Me.TabDomicilio.Controls.Add(Me.Label14)
        Me.TabDomicilio.Controls.Add(Me.TxtCP)
        Me.TabDomicilio.Controls.Add(Me.TxtPiso)
        Me.TabDomicilio.Controls.Add(Me.TxtDpto)
        Me.TabDomicilio.Location = New System.Drawing.Point(4, 22)
        Me.TabDomicilio.Name = "TabDomicilio"
        Me.TabDomicilio.Size = New System.Drawing.Size(334, 246)
        Me.TabDomicilio.TabIndex = 2
        Me.TabDomicilio.Text = "Domicilio"
        Me.TabDomicilio.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 171)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Provincia"
        '
        'TxtProvincia
        '
        Me.TxtProvincia.Location = New System.Drawing.Point(116, 168)
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.Size = New System.Drawing.Size(196, 20)
        Me.TxtProvincia.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Localidad"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(116, 142)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(196, 20)
        Me.TxtLocalidad.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Número"
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(116, 36)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(196, 20)
        Me.TxtCalle.TabIndex = 13
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(116, 63)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(196, 20)
        Me.TxtNumero.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Calle"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Piso"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(197, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Dpto."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "C.P."
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(116, 116)
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(196, 20)
        Me.TxtCP.TabIndex = 17
        '
        'TxtPiso
        '
        Me.TxtPiso.Location = New System.Drawing.Point(116, 89)
        Me.TxtPiso.Name = "TxtPiso"
        Me.TxtPiso.Size = New System.Drawing.Size(75, 20)
        Me.TxtPiso.TabIndex = 15
        '
        'TxtDpto
        '
        Me.TxtDpto.Location = New System.Drawing.Point(229, 90)
        Me.TxtDpto.Name = "TxtDpto"
        Me.TxtDpto.Size = New System.Drawing.Size(83, 20)
        Me.TxtDpto.TabIndex = 16
        '
        'TabRegistro
        '
        Me.TabRegistro.Controls.Add(Me.CbbTurnos)
        Me.TabRegistro.Controls.Add(Me.Label4)
        Me.TabRegistro.Controls.Add(Me.cbbCategorias)
        Me.TabRegistro.Controls.Add(Me.Label7)
        Me.TabRegistro.Controls.Add(Me.Label11)
        Me.TabRegistro.Controls.Add(Me.dtpFechaVencimientoRegistro)
        Me.TabRegistro.Controls.Add(Me.cbbAutos)
        Me.TabRegistro.Controls.Add(Me.Label8)
        Me.TabRegistro.Location = New System.Drawing.Point(4, 22)
        Me.TabRegistro.Name = "TabRegistro"
        Me.TabRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegistro.Size = New System.Drawing.Size(334, 246)
        Me.TabRegistro.TabIndex = 1
        Me.TabRegistro.Text = "Licencia - Vehiculo"
        Me.TabRegistro.UseVisualStyleBackColor = True
        '
        'CbbTurnos
        '
        Me.CbbTurnos.FormattingEnabled = True
        Me.CbbTurnos.Location = New System.Drawing.Point(116, 129)
        Me.CbbTurnos.Name = "CbbTurnos"
        Me.CbbTurnos.Size = New System.Drawing.Size(196, 21)
        Me.CbbTurnos.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Turno"
        '
        'cbbCategorias
        '
        Me.cbbCategorias.FormattingEnabled = True
        Me.cbbCategorias.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbbCategorias.Location = New System.Drawing.Point(116, 66)
        Me.cbbCategorias.Name = "cbbCategorias"
        Me.cbbCategorias.Size = New System.Drawing.Size(196, 21)
        Me.cbbCategorias.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Vencimiento Registro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Categoria Registro"
        '
        'dtpFechaVencimientoRegistro
        '
        Me.dtpFechaVencimientoRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimientoRegistro.Location = New System.Drawing.Point(116, 36)
        Me.dtpFechaVencimientoRegistro.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaVencimientoRegistro.Name = "dtpFechaVencimientoRegistro"
        Me.dtpFechaVencimientoRegistro.Size = New System.Drawing.Size(196, 20)
        Me.dtpFechaVencimientoRegistro.TabIndex = 7
        Me.dtpFechaVencimientoRegistro.Value = New Date(2018, 7, 11, 0, 0, 0, 0)
        '
        'cbbAutos
        '
        Me.cbbAutos.FormattingEnabled = True
        Me.cbbAutos.Location = New System.Drawing.Point(116, 97)
        Me.cbbAutos.Name = "cbbAutos"
        Me.cbbAutos.Size = New System.Drawing.Size(196, 21)
        Me.cbbAutos.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Auto"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(247, 296)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 47
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(137, 297)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(20, 297)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 23)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FormChoferes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormChoferes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choferes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabDatosChofer.ResumeLayout(False)
        Me.TabDatosChofer.PerformLayout()
        Me.TabTelefono.ResumeLayout(False)
        Me.TabTelefono.PerformLayout()
        Me.TabDomicilio.ResumeLayout(False)
        Me.TabDomicilio.PerformLayout()
        Me.TabRegistro.ResumeLayout(False)
        Me.TabRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents dgvChoferes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbbAutos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaVencimientoRegistro As DateTimePicker
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtNroDocumento As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents cbbCategorias As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabDatosChofer As TabPage
    Friend WithEvents TabDomicilio As TabPage
    Friend WithEvents TabRegistro As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtProvincia As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCP As TextBox
    Friend WithEvents TxtPiso As TextBox
    Friend WithEvents TxtDpto As TextBox
    Friend WithEvents TabTelefono As TabPage
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtNumeroTel As TextBox
    Friend WithEvents TxtCodArea As TextBox
    Friend WithEvents TxtCodPais As TextBox
    Friend WithEvents CbbTiposTelefono As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CbbTurnos As ComboBox
    Friend WithEvents Label4 As Label
End Class
