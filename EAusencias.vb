Imports System.Data.SqlClient
Public Class EAusencias
    Private Sub EAusencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet13.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet13.empleadoView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.ausenciasView' Puede moverla o quitarla según sea necesario.
        Me.AusenciasViewTableAdapter.Fill(Me.BiomessDataSet11.ausenciasView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Ausencias' Puede moverla o quitarla según sea necesario.
        Me.AusenciasTableAdapter.Fill(Me.BiomessDataSet1.Ausencias)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)

    End Sub

    Private Sub limpiarCampos()

        Dim fechaActual As Date = Date.Now
        Me.txbID.Text = ""
        Me.txbJustificacion.Text = ""
        Me.cbEmpleado.SelectedIndex = -1
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAusencias As New biomessDataSet1TableAdapters.AusenciasTableAdapter
                tblAusencias.InsertQuery(Me.cbEmpleado.SelectedValue, dpFecha.Value.Date, txbJustificacion.Text, 1)
                MessageBox.Show("El registro se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AusenciasViewTableAdapter.Fill(Me.BiomessDataSet11.ausenciasView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar la ausencia: ", sqlex.Message())
            MsgBox("Error al registrar la ausencia: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar la ausencia: ", ex.Message())
            MsgBox("Error al registrar la ausencia: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbAusencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbAusencias.CellContentClick
        Me.txbID.Text = dgbAusencias.CurrentRow.Cells.Item(0).Value.ToString
        Me.dpFecha.Value = dgbAusencias.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txbJustificacion.Text = dgbAusencias.CurrentRow.Cells.Item(3).Value.ToString()
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        Me.Dispose()
        win.Show()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.dgbAusencias.DataSource = Me.AusenciasViewTableAdapter.GetDataBy(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar la ausencia a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAusencias As New biomessDataSet1TableAdapters.AusenciasTableAdapter
                tblAusencias.UpdateQuery(dpFecha.Value.Date, txbJustificacion.Text, 2, Me.txbID.Text)
                MessageBox.Show("El registro se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AusenciasViewTableAdapter.Fill(Me.BiomessDataSet11.ausenciasView)
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
                MessageBox.Show("Debe seleccionar la ausencia a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAusencias As New biomessDataSet1TableAdapters.AusenciasTableAdapter
                tblAusencias.DeleteByEstado(3, Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.AusenciasViewTableAdapter.Fill(Me.BiomessDataSet11.ausenciasView)
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class