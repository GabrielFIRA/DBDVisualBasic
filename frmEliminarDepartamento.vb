Imports System.Data.SqlClient
Public Class frmEliminarDepartamento
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmDepartamentos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.tbDepartamentoAEliminar.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre actual del departamento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbDepartamentoAEliminar.Focus()
                limpiarCampos()


            ElseIf Me.tbConfirmarDepartamento.Text.Equals("") Then
                MessageBox.Show("Debe escribir ambos nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarDepartamento.Focus()
                limpiarCampos()

            ElseIf Me.tbDepartamentoAEliminar.Text <> Me.tbConfirmarDepartamento.Text Then
                MessageBox.Show("Los nombres no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.tbDepartamentoAEliminar.Focus()
                limpiarCampos()

            Else
                Dim tblDepartamento As New biomessDataSetTableAdapters.DepartamentoTableAdapter
                tblDepartamento.DeleteQuery(Original_nombreDepart:=Me.tbDepartamentoAEliminar.Text)
                MessageBox.Show("El Departamento se ha eliminado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al eliminar el Departamento: ", sqlex.Message())
            MsgBox("Error al eliminar el Departamento: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar el Departamento: ", ex.Message())
            MsgBox("Error al eliminar el Departamento: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub frmEliminarDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        Me.tbDepartamentoAEliminar.Text = ""
        Me.tbConfirmarDepartamento.Text = ""

    End Sub
End Class