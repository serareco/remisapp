Public Class FormTurnos
    Dim turno As EL.Turno
    Dim turnoService As New BLL.Turno()

    Public Sub ActualizarLista()
        TxtHorarioFin.Text() = ""
        TxtHorarioInicio.Text() = ""
        TxtTurno.Text() = ""


        dgvTurnos.DataSource = Nothing
        dgvTurnos.DataSource = New BindingSource With {
            .DataSource = turnoService.Listar()
        }
        turno = Nothing
    End Sub

    Private Sub FormTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarLista()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If turno Is Nothing Then
            turno = New EL.Turno()
        End If
        Dim erroresValidaciones As Boolean = False
        Dim msjValidaciones As String = ""
        If (BLL.Validacion.DatoObligatorioVacio(TxtTurno.Text, "")) Then
            msjValidaciones += "Se tiene que indicar el turno que se desea modificar" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(TxtHorarioInicio.Text, "")) Then
            msjValidaciones += "La hora de inicio es obligatorio" + vbLf
            erroresValidaciones = True
        End If
        If (BLL.Validacion.DatoObligatorioVacio(TxtHorarioFin.Text, "")) Then
            msjValidaciones += "La hora de fin es obligatoria" + vbLf
            erroresValidaciones = True
        End If
        If Not (BLL.Validacion.FormatoNumeros(TxtHorarioInicio.Text)) Then
            msjValidaciones += "La hora de inicio solo puede ser numérica" + vbLf
            erroresValidaciones = True
        End If
        If Not (BLL.Validacion.FormatoNumeros(TxtHorarioFin.Text)) Then
            msjValidaciones += "La hora de fin solo puede ser numérica" + vbLf
            erroresValidaciones = True
        End If
        If erroresValidaciones Then
            MessageBox.Show(msjValidaciones)
        Else
            turno.Descripcion = TxtTurno.Text
            turno.HoraEntrada = TxtHorarioInicio.Text
            turno.HoraSalida = TxtHorarioFin.Text
            turnoService.Guardar(turno)
            ActualizarLista()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If turno IsNot Nothing Then
            TxtTurno.Text() = turno.Descripcion
            TxtHorarioInicio.Text() = turno.HoraEntrada
            TxtHorarioFin.Text() = turno.HoraSalida
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If turno IsNot Nothing Then
            Dim result As Integer = MessageBox.Show("Estas seguro que deseas eliminar este turno?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                turnoService.Quitar(turno)
                ActualizarLista()
            End If
        End If
    End Sub

    Private Sub dgvTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurnos.CellClick
        turno = Nothing
        turno = New EL.Turno With {
            .Id = dgvTurnos.Rows(e.RowIndex).Cells(0).Value
        }
        turno = turnoService.GetById(turno.Id)
    End Sub
End Class