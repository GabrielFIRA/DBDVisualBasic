Imports System.Data.SqlClient
Public Class EFaltas
    Private Sub EFaltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.faltasView' Puede moverla o quitarla según sea necesario.
        Me.FaltasViewTableAdapter.Fill(Me.BiomessDataSet1.faltasView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Faltas' Puede moverla o quitarla según sea necesario.
        Me.FaltasTableAdapter.Fill(Me.BiomessDataSet1.Faltas)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)

    End Sub
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub limpiarCampos()
        Me.txbID.Text = ""
        Me.cbEmpleado.SelectedIndex = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblFaltas As New biomessDataSet1TableAdapters.FaltasTableAdapter
                tblFaltas.InsertQuery(Me.cbEmpleado.SelectedValue, dpFecha.Value.Date, 1)
                MessageBox.Show("El registro se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.FaltasViewTableAdapter.Fill(Me.BiomessDataSet1.faltasView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar la falta: ", sqlex.Message())
            MsgBox("Error al registrar la falta: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar la falta: ", ex.Message())
            MsgBox("Error al registrar la falta: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbFaltas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbFaltas.CellContentClick
        Me.txbID.Text = dgbFaltas.CurrentRow.Cells.Item(0).Value.ToString()
        Me.dpFecha.Value = dgbFaltas.CurrentRow.Cells.Item(2).Value.ToString()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.dgbFaltas.DataSource = Me.FaltasViewTableAdapter.GetDataBy(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar la falta a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblFaltas As New biomessDataSet1TableAdapters.FaltasTableAdapter
                tblFaltas.UpdateQuery(dpFecha.Value.Date, 2, Me.txbID.Text)
                MessageBox.Show("El registro se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.FaltasViewTableAdapter.Fill(Me.BiomessDataSet1.faltasView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al modificar la falta: ", sqlex.Message())
            MsgBox("Error al modificar la falta: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar la falta: ", ex.Message())
            MsgBox("Error al modificar la falta: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar la falta a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblFaltas As New biomessDataSet1TableAdapters.FaltasTableAdapter
                tblFaltas.DeleteByEstado(3, Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.FaltasViewTableAdapter.Fill(Me.BiomessDataSet1.faltasView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al eliminar la falta: ", sqlex.Message())
            MsgBox("Error al eliminar la falta: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar la falta: ", ex.Message())
            MsgBox("Error al eliminar la falta: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub
End Class