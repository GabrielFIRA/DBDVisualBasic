Imports System.Data.SqlClient
Public Class frmOpcion
    Private Sub frmOpcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.Opciones' Puede moverla o quitarla según sea necesario.
        Me.OpcionesTableAdapter.Fill(Me.BiomessDataSet2.Opciones)
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        Me.txbIDO.Text = ""
        Me.txbOpcion.Text = ""
        Me.txbDescOpc.Text = ""

    End Sub

    Private Sub btnNuevoO_Click(sender As Object, e As EventArgs) Handles btnNuevoO.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregarO_Click(sender As Object, e As EventArgs) Handles btnAgregarO.Click
        Try
            If Me.txbOpcion.Text.Equals("") Or Me.txbDescOpc.Text.Equals("") Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblOpc As New biomessDataSet2TableAdapters.OpcionesTableAdapter
                tblOpc.InsertQuery(Me.txbOpcion.Text, Me.txbDescOpc.Text, 1)
                MessageBox.Show("El Registro se ha guardado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.OpcionesTableAdapter.Fill(Me.BiomessDataSet2.Opciones)
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

    Private Sub btnEditarO_Click(sender As Object, e As EventArgs) Handles btnEditarO.Click
        Try
            If Me.txbOpcion.Text.Equals("") Or Me.txbDescOpc.Text.Equals("") Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblOpc As New biomessDataSet2TableAdapters.OpcionesTableAdapter
                tblOpc.UpdateQuery(Me.txbOpcion.Text, Me.txbDescOpc.Text, 1, Me.txbIDO.Text)
                MessageBox.Show("El Registro se ha Actualizado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.OpcionesTableAdapter.Fill(Me.BiomessDataSet2.Opciones)
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

    Private Sub btnEliminarO_Click(sender As Object, e As EventArgs) Handles btnEliminarO.Click
        Try
            If Me.txbIDO.Text.Equals("") Then
                MessageBox.Show("Es necesario el ID del Usuario a eliminar. Señale el usuario en la tabla!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblOpc As New biomessDataSet2TableAdapters.OpcionesTableAdapter
                tblOpc.DeleteQuery(Me.txbIDO.Text)
                MessageBox.Show("El registro se ha eliminado con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.OpcionesTableAdapter.Fill(Me.BiomessDataSet2.Opciones)
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
        Me.txbIDO.Text = dgvRol.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txbOpcion.Text = dgvRol.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txbDescOpc.Text = dgvRol.CurrentRow.Cells.Item(2).Value.ToString()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Usuario()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub txbBuscarO_TextChanged(sender As Object, e As EventArgs) Handles txbBuscarO.TextChanged
        Me.dgvRol.DataSource = Me.OpcionesTableAdapter.GetDataBy3(txbBuscarO.Text)
    End Sub
End Class