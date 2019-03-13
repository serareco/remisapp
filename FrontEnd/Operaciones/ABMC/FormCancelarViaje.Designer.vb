<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCancelarViaje
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
        Me.TxtComentarios = New System.Windows.Forms.TextBox()
        Me.BtnConfirmarCancelar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtComentarios
        '
        Me.TxtComentarios.Location = New System.Drawing.Point(12, 64)
        Me.TxtComentarios.Multiline = True
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.Size = New System.Drawing.Size(313, 65)
        Me.TxtComentarios.TabIndex = 0
        '
        'BtnConfirmarCancelar
        '
        Me.BtnConfirmarCancelar.Location = New System.Drawing.Point(12, 152)
        Me.BtnConfirmarCancelar.Name = "BtnConfirmarCancelar"
        Me.BtnConfirmarCancelar.Size = New System.Drawing.Size(136, 23)
        Me.BtnConfirmarCancelar.TabIndex = 1
        Me.BtnConfirmarCancelar.Text = "Cancelar Viaje"
        Me.BtnConfirmarCancelar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(222, 152)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(103, 23)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Motivos de cancelamiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Recuerde que cancelar un viaje modifica los beneficios del socio."
        '
        'FormCancelarViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 191)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnConfirmarCancelar)
        Me.Controls.Add(Me.TxtComentarios)
        Me.Name = "FormCancelarViaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtComentarios As TextBox
    Friend WithEvents BtnConfirmarCancelar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
