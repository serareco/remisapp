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
        Me.SuspendLayout()
        '
        'TxtComentarios
        '
        Me.TxtComentarios.Location = New System.Drawing.Point(20, 57)
        Me.TxtComentarios.Multiline = True
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.Size = New System.Drawing.Size(298, 65)
        Me.TxtComentarios.TabIndex = 0
        '
        'BtnConfirmarCancelar
        '
        Me.BtnConfirmarCancelar.Location = New System.Drawing.Point(20, 152)
        Me.BtnConfirmarCancelar.Name = "BtnConfirmarCancelar"
        Me.BtnConfirmarCancelar.Size = New System.Drawing.Size(136, 23)
        Me.BtnConfirmarCancelar.TabIndex = 1
        Me.BtnConfirmarCancelar.Text = "Cancelar Viaje"
        Me.BtnConfirmarCancelar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(215, 152)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(103, 23)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Motivos de cancelamiento"
        '
        'FormCancelarViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 212)
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
End Class
