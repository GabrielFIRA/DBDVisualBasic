Imports System.Data.SqlClient
Public Class EAtrasos
    Private Sub EAtrasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Horarios' Puede moverla o quitarla según sea necesario.
        Me.HorariosTableAdapter.Fill(Me.BiomessDataSet1.Horarios)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.atrasosView' Puede moverla o quitarla según sea necesario.
        Me.AtrasosViewTableAdapter.Fill(Me.BiomessDataSet1.atrasosView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Atrasos' Puede moverla o quitarla según sea necesario.
        Me.AtrasosTableAdapter.Fill(Me.BiomessDataSet1.Atrasos)
    End Sub

    Private Sub limpiarCampos()
        Me.txbID.Text = ""
        Me.cbEmpleado.SelectedItem = -1
        Me.txbJustificacion.Text = ""
    End Sub

    Public Function Tiempo(id As Integer, Hora As TimeSpan) As Integer
        Dim tblHorario As New biomessDataSet1TableAdapters.HorariosTableAdapter
        Dim horaHorario As TimeSpan = Convert.ToDateTime(tblHorario.GetHorario(1).Rows(0).Item(2).ToString).TimeOfDay
        Dim Atraso As TimeSpan = Hora.Subtract(horaHorario)
        Tiempo = Convert.ToInt32(Atraso.TotalMinutes)
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAtrasos As New biomessDataSet1TableAdapters.AtrasosTableAdapter
                tblAtrasos.InsertQuery(Me.cbEmpleado.SelectedValue, Tiempo(Me.cbEmpleado.SelectedValue, Me.tpHora.Value.TimeOfDay), Me.txbJustificacion.Text, Me.dpFecha.Value.Date, 1)
                MessageBox.Show("El registro se ha guardado correctamete", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AtrasosViewTableAdapter.Fill(Me.BiomessDataSet1.atrasosView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el atraso: ", sqlex.Message())
            MsgBox("Error al registrar el atraso: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el atraso: ", ex.Message())
            MsgBox("Error al registrar el atraso: ", ex.StackTrace())
        End Try
    End Sub
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub dgbAusencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbAtrasos.CellContentClick
        Me.txbID.Text = dgbAtrasos.CurrentRow.Cells.Item(0).Value.ToString()
        Me.dpFecha.Value = dgbAtrasos.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txbJustificacion.Text = dgbAtrasos.CurrentRow.Cells.Item(4).Value.ToString()
    End Sub

    Private Sub txbBuscar_TextChanged(sender As Object, e As EventArgs) Handles txbBuscar.TextChanged
        Me.dgbAtrasos.DataSource = Me.AtrasosViewTableAdapter.GetDataBy(txbBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar el atraso a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAtraso As New biomessDataSet1TableAdapters.AtrasosTableAdapter
                tblAtraso.UpdateQuery(Tiempo(Me.cbEmpleado.SelectedValue, Me.tpHora.Value.TimeOfDay), txbJustificacion.Text, dpFecha.Value.Date, 2, Me.txbID.Text)
                MessageBox.Show("El registro se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AtrasosViewTableAdapter.Fill(Me.BiomessDataSet1.atrasosView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al modificar la ausencia: ", sqlex.Message())
            MsgBox("Error al modificar la ausencia: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar la ausencia: ", ex.Message())
            MsgBox("Error al modificar la ausencia: ", ex.StackTrace())
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar el atraso a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAtrasos As New biomessDataSet1TableAdapters.AtrasosTableAdapter
                tblAtrasos.DeleteByEstado(3, Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AtrasosViewTableAdapter.Fill(Me.BiomessDataSet1.atrasosView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al eliminar la ausencia: ", sqlex.Message())
            MsgBox("Error al eliminar la ausencia: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar la ausencia: ", ex.Message())
            MsgBox("Error al eliminar la ausencia: ", ex.StackTrace())
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
End Class