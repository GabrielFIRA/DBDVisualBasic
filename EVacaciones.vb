Imports System.Data.SqlClient
Public Class Vacaciones
    Dim tipo As Boolean
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub EVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.vacacionesView' Puede moverla o quitarla según sea necesario.
        Me.VacacionesViewTableAdapter.Fill(Me.BiomessDataSet1.vacacionesView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Vacaciones' Puede moverla o quitarla según sea necesario.
        Me.VacacionesTableAdapter.Fill(Me.BiomessDataSet1.Vacaciones)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.vacacionesView' Puede moverla o quitarla según sea necesario.
        Me.VacacionesViewTableAdapter.Fill(Me.BiomessDataSet1.vacacionesView)

    End Sub

    Private Sub limpiarCampos()
        Me.cbEmpleado.SelectedIndex = -1
        Me.cbTipo.SelectedIndex = -1
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub tipoV()
        If Me.cbTipo.Text.Equals("Feriado") Then
            tipo = 0
        ElseIf Me.cbTipo.Text.Equals("Vacaciones") Then
            tipo = 1
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.cbTipo.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar el tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tipoV()
                Dim tblVacaciones As New biomessDataSet1TableAdapters.VacacionesTableAdapter
                tblVacaciones.InsertQuery(Me.cbEmpleado.SelectedValue, dpFechaInicio.Value.Date, dpFechaFinal.Value.Date, tipo, 1)
                MessageBox.Show("El registro se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.VacacionesViewTableAdapter.Fill(Me.BiomessDataSet1.vacacionesView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar las vacaciones: ", sqlex.Message())
            MsgBox("Error al registrar las vacaciones: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar las vacaciones ", ex.Message())
            MsgBox("Error al registrar las vacaciones ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbVacaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbVacaciones.CellContentClick
        Me.txbID.Text = dgbVacaciones.CurrentRow.Cells.Item(0).Value.ToString()
        Me.dpFechaInicio.Value = dgbVacaciones.CurrentRow.Cells.Item(2).Value.ToString()
        Me.dpFechaFinal.Value = dgbVacaciones.CurrentRow.Cells.Item(3).Value.ToString()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.dgbVacaciones.DataSource = Me.VacacionesViewTableAdapter.GetDataBy(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar las vacaciones a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tipoV()
                Dim tblVacaciones As New biomessDataSet1TableAdapters.VacacionesTableAdapter
                tblVacaciones.UpdateQuery(dpFechaInicio.Value.Date, dpFechaFinal.Value.Date, 2, Me.txbID.Text)
                MessageBox.Show("El registro se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.VacacionesViewTableAdapter.Fill(Me.BiomessDataSet1.vacacionesView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al modificar las vacaciones: ", sqlex.Message())
            MsgBox("Error al modificar las vacaciones: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar las vacaciones ", ex.Message())
            MsgBox("Error al modificar las vacaciones ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar las vacaciones a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tipoV()
                Dim tblVacaciones As New biomessDataSet1TableAdapters.VacacionesTableAdapter
                tblVacaciones.DeleteByEstado(3, Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.VacacionesViewTableAdapter.Fill(Me.BiomessDataSet1.vacacionesView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al eliminar las vacaciones: ", sqlex.Message())
            MsgBox("Error al eliminar las vacaciones: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar las vacaciones ", ex.Message())
            MsgBox("Error al eliminar las vacaciones ", ex.StackTrace())
        End Try
    End Sub
End Class