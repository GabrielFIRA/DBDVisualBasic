Imports System.Data.SqlClient
Public Class frmEliminarCargo
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Cargos()
        win.Show()
        Me.Dispose()
    End Sub



    Private Sub frmEliminarCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.BiomessDataSet.Cargo)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        limpiarCampos()
    End Sub
    Private Sub limpiarCampos()
        Me.tbCargoAEliminar.Text = ""
        Me.tbConfirmarCargo.Text = ""
        Me.cbNombreDepar.SelectedIndex = -1
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.tbCargoAEliminar.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre actual del Cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbCargoAEliminar.Focus()
                limpiarCampos()


            ElseIf Me.tbConfirmarCargo.Text.Equals("") Then
                MessageBox.Show("Debe escribir ambos nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarCargo.Focus()
                limpiarCampos()

            ElseIf Me.tbCargoAEliminar.Text <> Me.tbConfirmarCargo.Text Then
                MessageBox.Show("Las Nombres no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.tbCargoAEliminar.Focus()
                limpiarCampos()

            Else
                Dim tblCargo As New biomessDataSetTableAdapters.CargoTableAdapter
                tblCargo.DeleteQuery(Original_ID_Departamento:=Me.cbNombreDepar.SelectedValue,
                                     Original_nombreCargo:=Me.tbCargoAEliminar.Text)
                MessageBox.Show("El Cargo se Elimino con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar al Eliminar el Cargo: ", sqlex.Message())
            MsgBox("Error al registrar al Eliminar el Cargo:: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar al Eliminar el Cargo:: ", ex.Message())
            MsgBox("Error al registrar al Eliminar el Cargo:: ", ex.StackTrace())
        End Try
    End Sub
End Class