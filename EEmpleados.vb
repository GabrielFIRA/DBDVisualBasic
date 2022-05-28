Imports System.Data.SqlClient
Public Class EEmpleados



    Private Sub EEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.BiomessDataSet1.Cargo)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet1.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)
        limpiarCampos()

    End Sub

    Private Sub limpiarCampos()
        Me.txbID.Text = ""
        Me.txbNombre.Text = ""
        Me.txbPIN.Text = ""
        Me.txbCedula.Text = ""
        Me.txbINSS.Text = ""
        Me.txbCelular.Text = ""
        Me.txbCorreo.Text = ""
        Me.cbCargo.SelectedIndex = -1
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.txbNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txbNombre.Focus()

            ElseIf Me.txbCedula.Text.Equals("") Then
                MessageBox.Show("Debe escribir la cedula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txbCedula.Focus()

            ElseIf Me.txbINSS.Text.Equals("") Then
                MessageBox.Show("Debe escribir el INSS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txbINSS.Focus()

            ElseIf Me.txbPIN.Text.Equals("") Then
                MessageBox.Show("Debe escribir el PIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txbINSS.Focus()

            ElseIf Me.cbCargo.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim tblEmpleado As New biomessDataSet1TableAdapters.EmpleadoTableAdapter
                tblEmpleado.InsertQuery(Me.cbCargo.SelectedValue, Me.txbCedula.Text, Me.txbINSS.Text, Me.txbNombre.Text, Me.txbCorreo.Text, Me.txbCelular.Text, Date.Now, Me.dpFecha.Value.Date, Me.txbPIN.Text, 1)
                MessageBox.Show("El registro se ha guardado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
                limpiarCampos()

            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el empleado: ", sqlex.Message())
            MsgBox("Error al registrar el empleado: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el empleado: ", ex.Message())
            MsgBox("Error al registrar el empleado: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbEmpleados.CellContentClick
        Me.txbID.Text = dgbEmpleados.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txbNombre.Text = dgbEmpleados.CurrentRow.Cells.Item(1).Value.ToString()
        Me.dpFecha.Value = dgbEmpleados.CurrentRow.Cells.Item(2).Value.ToString
        Me.txbCedula.Text = dgbEmpleados.CurrentRow.Cells.Item(3).Value.ToString()
        Me.txbINSS.Text = dgbEmpleados.CurrentRow.Cells.Item(4).Value.ToString()
        Me.txbCorreo.Text = dgbEmpleados.CurrentRow.Cells.Item(5).Value.ToString()
        Me.txbCelular.Text = dgbEmpleados.CurrentRow.Cells.Item(6).Value.ToString()
        Me.txbPIN.Text = dgbEmpleados.CurrentRow.Cells.Item(10).Value.ToString()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New Empleados()
        Me.Dispose()
        win.Show()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.dgbEmpleados.DataSource = Me.EmpleadoViewTableAdapter.GetDataBy(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar el usuario a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Me.txbNombre.Text.Equals("") Then
                    MessageBox.Show("Debe escribir el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txbNombre.Focus()

                ElseIf Me.txbPIN.Text.Equals("") Then
                    MessageBox.Show("Debe escribir el PIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txbINSS.Focus()

                ElseIf Me.cbCargo.SelectedIndex < 0 Then
                    MessageBox.Show("Debe seleccionar un cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    Dim tblEmpleado As New biomessDataSet1TableAdapters.EmpleadoTableAdapter
                    tblEmpleado.UpdateQuery(Me.cbCargo.SelectedValue, Me.txbNombre.Text, Me.txbCorreo.Text, Me.txbCelular.Text, Me.txbPIN.Text, 2, Me.txbID.Text)
                    MessageBox.Show("El registro se ha modificado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
                    limpiarCampos()

                End If
            End If

        Catch sqlex As SqlException
            MsgBox("Error al modificar el empleado: ", sqlex.Message())
            MsgBox("Error al modificar el empleado: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar el empleado: ", ex.Message())
            MsgBox("Error al modificar el empleado: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Or String.IsNullOrEmpty(Me.txbID.Text) Then
                MessageBox.Show("Debe seleccionar el usuario a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblEmpleado As New biomessDataSet1TableAdapters.EmpleadoTableAdapter
                tblEmpleado.DeleteByEstado(3, Convert.ToInt32(Me.txbID.Text))
                MessageBox.Show("El registro se ha eliminado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.EmpleadoViewTableAdapter.Fill(Me.BiomessDataSet1.empleadoView)
                limpiarCampos()
            End If

        Catch sqlex As SqlException
            MsgBox("Error al eliminar el empleado: ", sqlex.Message())
            MsgBox("Error al eliminar el empleado: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar el empleado: ", ex.Message())
            MsgBox("Error al eliminar el empleado: ", ex.StackTrace())
        End Try
    End Sub
End Class