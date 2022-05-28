Imports System.Data.SqlClient
Public Class EAsistencias
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub EAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet11.empleadoView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet11.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.asistenciasView' Puede moverla o quitarla según sea necesario.
        Me.AsistenciasViewTableAdapter.Fill(Me.BiomessDataSet11.asistenciasView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.asistenciasView' Puede moverla o quitarla según sea necesario.
        Me.AsistenciasViewTableAdapter.Fill(Me.BiomessDataSet11.asistenciasView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.ausenciasView' Puede moverla o quitarla según sea necesario.
        Me.AusenciasViewTableAdapter.Fill(Me.BiomessDataSet11.ausenciasView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Asistencia' Puede moverla o quitarla según sea necesario.
        Me.AsistenciaTableAdapter.Fill(Me.BiomessDataSet1.Asistencia)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.asistenciasView' Puede moverla o quitarla según sea necesario.
        Me.AsistenciasViewTableAdapter.Fill(Me.BiomessDataSet1.asistenciasView)

    End Sub

    Private Sub limpiarCampos()
        Me.cbEmpleado.SelectedIndex = -1
        Me.cbTipo.SelectedIndex = -1
    End Sub
    Function NumeroSemana(pFecha As Date) As Integer
        Dim sFecha As String
        sFecha = "01/" & Month(pFecha) & "/" & Year(pFecha)
        NumeroSemana = DatePart("ww", pFecha) - DatePart("ww", DateValue(sFecha)) + 1
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.cbTipo.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar el tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAsistencia As New biomessDataSet1TableAdapters.AsistenciaTableAdapter
                If Me.cbTipo.Text.Equals("Entrada") Then
                    tblAsistencia.InsertQueryEntrada(Me.cbEmpleado.SelectedValue, Me.tpHoraSalida.Value.ToShortTimeString, Me.dpFecha.Value.Date, 1, 1)
                    MessageBox.Show("El registro se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.AsistenciaTableAdapter.Fill(Me.BiomessDataSet1.Asistencia)
                    limpiarCampos()
                ElseIf Me.cbTipo.Text.Equals("Salida") Then
                    tblAsistencia.InsertQuerySalida(tpHoraSalida.Value.ToString("HH:mm:ss"), Me.txbID.Text)
                    MessageBox.Show("El registro se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.AsistenciasViewTableAdapter.Fill(Me.BiomessDataSet1.asistenciasView)
                End If
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar la asistencia: ", sqlex.Message())
            MsgBox("Error al registrar la asistencia: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar la asistencia: ", ex.Message())
            MsgBox("Error al registrar la asistencia: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbAsistencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbAsistencias.CellContentClick
        Me.txbID.Text = dgbAsistencias.CurrentRow.Cells.Item(0).Value.ToString()
        Me.dpFecha.Value = dgbAsistencias.CurrentRow.Cells.Item(2).Value.ToString()
        Me.tpHoraSalida.Value = dgbAsistencias.CurrentRow.Cells.Item(3).Value.ToString()
        Me.tpHoraSalida.Value = dgbAsistencias.CurrentRow.Cells.Item(4).Value.ToString()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.dgbAsistencias.DataSource = Me.AsistenciasViewTableAdapter.GetDataBy(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar la asistencia a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAsistencia As New biomessDataSet1TableAdapters.AsistenciaTableAdapter
                tblAsistencia.UpdateQuery(tpHoraEntrada.Value.ToString("HH:mm:ss"), tpHoraSalida.Value.ToString("HH:mm:ss"), Me.dpFecha.Value.Date, 1, 1, Me.txbID.Text)
                MessageBox.Show("El registro se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AsistenciasViewTableAdapter.Fill(Me.BiomessDataSet1.asistenciasView)
            End If
        Catch sqlex As SqlException
            MsgBox("Error al modificar la asistencia: ", sqlex.Message())
            MsgBox("Error al modificar la asistencia: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar la asistencia: ", ex.Message())
            MsgBox("Error al modificar la asistencia: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnEdicion_Click(sender As Object, e As EventArgs) Handles btnEdicion.Click
        Me.txtSalida.Visible = True
        Me.txtEntrada.Text = "Hora entrada:"
        Me.tpHoraSalida.Visible = True
        Me.txtTipo.Visible = False
        Me.cbTipo.Visible = False
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        Me.txtSalida.Visible = False
        Me.txtEntrada.Text = "Hora:"
        Me.tpHoraSalida.Visible = False
        Me.txtTipo.Visible = True
        Me.cbTipo.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar la asistencia a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAsistencia As New biomessDataSet1TableAdapters.AsistenciaTableAdapter
                tblAsistencia.DeleteByEstado(3, Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AsistenciasViewTableAdapter.Fill(Me.BiomessDataSet1.asistenciasView)
            End If
        Catch sqlex As SqlException
            MsgBox("Error al eliminar la asistencia: ", sqlex.Message())
            MsgBox("Error al eliminar la asistencia: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar la asistencia: ", ex.Message())
            MsgBox("Error al eliminar la asistencia: ", ex.StackTrace())
        End Try
    End Sub
End Class