Imports System.Data.SqlClient
Public Class EPermisos
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub EPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.permisosView' Puede moverla o quitarla según sea necesario.
        Me.PermisosViewTableAdapter.Fill(Me.BiomessDataSet1.permisosView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Permisos' Puede moverla o quitarla según sea necesario.
        Me.PermisosTableAdapter.Fill(Me.BiomessDataSet1.Permisos)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.permisosView' Puede moverla o quitarla según sea necesario.
        Me.PermisosViewTableAdapter.Fill(Me.BiomessDataSet1.permisosView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)

    End Sub

    Private Sub limpiarCampos()
        Me.txbID.Text = ""
        Me.cbEmpleado.SelectedIndex = -1
        Me.txbTipo.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.txbTipo.Text.Equals("") Then
                MessageBox.Show("Debe escribir el tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblPermisos As New biomessDataSet1TableAdapters.PermisosTableAdapter
                tblPermisos.InsertQuery(Me.cbEmpleado.SelectedValue, Me.dpFechaInicio.Value.Date, Me.dpFechaFinal.Value.Date, Me.txbTipo.Text, 1)
                MessageBox.Show("El registro se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.PermisosViewTableAdapter.Fill(Me.BiomessDataSet1.permisosView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el permiso: ", sqlex.Message())
            MsgBox("Error al registrar el permiso: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el permiso: ", ex.Message())
            MsgBox("Error al registrar el permiso: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbPermisos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbPermisos.CellContentClick
        Me.txbID.Text = dgbPermisos.CurrentRow.Cells.Item(0).Value.ToString()
        Me.dpFechaInicio.Value = dgbPermisos.CurrentRow.Cells.Item(2).Value.ToString()
        Me.dpFechaFinal.Value = dgbPermisos.CurrentRow.Cells.Item(3).Value.ToString()
        Me.txbTipo.Text = dgbPermisos.CurrentRow.Cells.Item(4).Value.ToString()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.dgbPermisos.DataSource = Me.PermisosViewTableAdapter.GetDataBy(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar las vacaciones a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Me.txbTipo.Text.Equals("") Then
                    MessageBox.Show("Debe escribir el tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim tblPermisos As New biomessDataSet1TableAdapters.PermisosTableAdapter
                    tblPermisos.UpdateQuery(Me.dpFechaInicio.Value.Date, Me.dpFechaFinal.Value.Date, 2, Me.txbID.Text)
                    MessageBox.Show("El registro se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.PermisosViewTableAdapter.Fill(Me.BiomessDataSet1.permisosView)
                    limpiarCampos()
                End If
            End If
        Catch sqlex As SqlException
            MsgBox("Error al modificar el permiso: ", sqlex.Message())
            MsgBox("Error al modificar el permiso: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar el permiso: ", ex.Message())
            MsgBox("Error al modificar el permiso: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar las vacaciones a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblPermisos As New biomessDataSet1TableAdapters.PermisosTableAdapter
                tblPermisos.DeleteByEstado(3, Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.PermisosViewTableAdapter.Fill(Me.BiomessDataSet1.permisosView)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al eliminar el permiso: ", sqlex.Message())
            MsgBox("Error al eliminar el permiso: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar el permiso: ", ex.Message())
            MsgBox("Error al eliminar el permiso: ", ex.StackTrace())
        End Try
    End Sub
End Class