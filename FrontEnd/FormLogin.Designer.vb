<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblMsjValidacion = New System.Windows.Forms.Label()
        Me.ChkChangePss = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Constraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingresá al sistema usando tu Usuario y Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(123, 52)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(123, 81)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(54, 159)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(169, 23)
        Me.BtnIngresar.TabIndex = 5
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'LblMsjValidacion
        '
        Me.LblMsjValidacion.AutoSize = True
        Me.LblMsjValidacion.ForeColor = System.Drawing.Color.IndianRed
        Me.LblMsjValidacion.Location = New System.Drawing.Point(51, 137)
        Me.LblMsjValidacion.Name = "LblMsjValidacion"
        Me.LblMsjValidacion.Size = New System.Drawing.Size(0, 13)
        Me.LblMsjValidacion.TabIndex = 6
        '
        'ChkChangePss
        '
        Me.ChkChangePss.AutoSize = True
        Me.ChkChangePss.Location = New System.Drawing.Point(54, 114)
        Me.ChkChangePss.Name = "ChkChangePss"
        Me.ChkChangePss.Size = New System.Drawing.Size(120, 17)
        Me.ChkChangePss.TabIndex = 7
        Me.ChkChangePss.Text = "Cambiar contraseña"
        Me.ChkChangePss.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(288, 196)
        Me.Controls.Add(Me.ChkChangePss)
        Me.Controls.Add(Me.LblMsjValidacion)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remisapp - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblMsjValidacion As Label

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Friend WithEvents ChkChangePss As CheckBox
End Class
