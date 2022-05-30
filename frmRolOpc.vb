Imports System.Data.SqlClient
Public Class frmRolOpc
    Private Sub frmRolOpc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet21.rolopcView' Puede moverla o quitarla según sea necesario.
        Me.RolopcViewTableAdapter.Fill(Me.BiomessDataSet21.rolopcView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.Opciones' Puede moverla o quitarla según sea necesario.
        Me.OpcionesTableAdapter.Fill(Me.BiomessDataSet2.Opciones)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.Rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.BiomessDataSet2.Rol)

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Usuario()
        win.Show()
        Me.Dispose()
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        Me.txbIDRO.Text = ""
        Me.cbxRol.SelectedIndex = -1
        Me.cbxOpc.SelectedIndex = -1
    End Sub

    Private Sub btnNuevoRO_Click(sender As Object, e As EventArgs) Handles btnNuevoRO.Click
        limpiarCampos()

    End Sub

    Private Sub btnAgregarRO_Click(sender As Object, e As EventArgs) Handles btnAgregarRO.Click
        Try
            If Me.cbxRol.SelectedValue < 0 Or Me.cbxRol.SelectedValue < 0 Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else
                Dim tblrolOpc As New biomessDataSet2TableAdapters.Rol_OpcionesTableAdapter
                tblrolOpc.InsertQuery(Me.cbxRol.SelectedValue, Me.cbxOpc.SelectedValue)
                MessageBox.Show("El Registro se ha guardado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RolopcViewTableAdapter.Fill(Me.BiomessDataSet21.rolopcView)
                limpiarCampos()

            End If
        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try
    End Sub

    Private Sub btnEditarRO_Click(sender As Object, e As EventArgs) Handles btnEditarRO.Click

        Try
            If Me.txbIDRO.Text.Equals("") Then
                MessageBox.Show("Es necesario el ID del Usuario a eliminar. Señale el usuario en la tabla!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else
                Dim tblrolOpc As New biomessDataSet2TableAdapters.Rol_OpcionesTableAdapter
                tblrolOpc.UpdateQuery(Me.cbxRol.SelectedValue, Me.cbxOpc.SelectedValue, txbIDRO.Text)
                MessageBox.Show("El Registro se ha actualizado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RolopcViewTableAdapter.Fill(Me.BiomessDataSet21.rolopcView)
                limpiarCampos()

            End If
        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try

    End Sub

    Private Sub btnEliminarRO_Click(sender As Object, e As EventArgs) Handles btnEliminarRO.Click
        Try
            If Me.cbxRol.SelectedValue < 0 Or Me.cbxRol.SelectedValue < 0 Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else
                Dim tblrolOpc As New biomessDataSet2TableAdapters.Rol_OpcionesTableAdapter
                tblrolOpc.DeleteQuery(txbIDRO.Text)
                MessageBox.Show("El Registro se ha eliminado con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RolopcViewTableAdapter.Fill(Me.BiomessDataSet21.rolopcView)
                limpiarCampos()

            End If
        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try

    End Sub

    Private Sub dgvRolOpc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRolOpc.CellClick
        Me.txbIDRO.Text = dgvRolOpc.CurrentRow.Cells.Item(0).Value.ToString()
        Me.cbxRol.SelectedValue = dgvRolOpc.CurrentRow.Cells.Item(1).Value.ToString()
        Me.cbxOpc.SelectedValue = dgvRolOpc.CurrentRow.Cells.Item(2).Value.ToString()
    End Sub

    Private Sub txbBuscarRO_TextChanged(sender As Object, e As EventArgs) Handles txbBuscarRO.TextChanged
        Me.dgvRolOpc.DataSource = Me.RolopcViewTableAdapter.GetDataBy(txbBuscarRO.Text, txbBuscarRO.Text)


    End Sub
End Class