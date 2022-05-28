Imports System.Data.SqlClient
Public Class frmRol
    Private Sub frmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.Rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.BiomessDataSet2.Rol)
        limpiarCampos()

    End Sub

    Private Sub limpiarCampos()
        Me.txbIDR.Text = ""
        Me.txbRol.Text = ""
        Me.txbDescRol.Text = ""

    End Sub

    Private Sub btnNuevoR_Click(sender As Object, e As EventArgs) Handles btnNuevoR.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregarR_Click(sender As Object, e As EventArgs) Handles btnAgregarR.Click
        Try
            If Me.txbRol.Text.Equals("") Or Me.txbDescRol.Text.Equals("") Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblRol As New biomessDataSet2TableAdapters.RolTableAdapter
                tblRol.InsertQuery(Me.txbRol.Text, Me.txbDescRol.Text, 1)
                MessageBox.Show("El Registro se ha guardado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RolTableAdapter.Fill(Me.BiomessDataSet2.Rol)
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

    Private Sub btnEditarR_Click(sender As Object, e As EventArgs) Handles btnEditarR.Click
        Try
            If Me.txbRol.Text.Equals("") Or Me.txbDescRol.Text.Equals("") Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblRol As New biomessDataSet2TableAdapters.RolTableAdapter
                tblRol.UpdateQuery(Me.txbRol.Text, Me.txbDescRol.Text, 2, Me.txbIDR.Text)
                MessageBox.Show("El Registro se ha Actualizado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RolTableAdapter.Fill(Me.BiomessDataSet2.Rol)
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

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Usuario()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEliminarR_Click(sender As Object, e As EventArgs) Handles btnEliminarR.Click
        Try
            If Me.txbIDR.Text.Equals("") Then
                MessageBox.Show("Es necesario el ID del Usuario a eliminar. Señale el usuario en la tabla!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblRol As New biomessDataSet2TableAdapters.RolTableAdapter
                tblRol.DeleteQuery(Me.txbIDR.Text)
                MessageBox.Show("El registro se ha eliminado con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.RolTableAdapter.Fill(Me.BiomessDataSet2.Rol)
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

    Private Sub dgvRol_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRol.CellClick
        Me.txbIDR.Text = dgvRol.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txbRol.Text = dgvRol.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txbDescRol.Text = dgvRol.CurrentRow.Cells.Item(2).Value.ToString()

    End Sub

    Private Sub txbBuscarR_TextChanged(sender As Object, e As EventArgs) Handles txbBuscarR.TextChanged
        Me.dgvRol.DataSource = Me.RolTableAdapter.GetDataBy3(txbBuscarR.Text)
    End Sub
End Class