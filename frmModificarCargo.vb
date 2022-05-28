Imports System.Data.SqlClient
Public Class frmModificarCargo

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.tbNuevoNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre actual del Cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()


            ElseIf Me.tbConfirmarNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir ambos nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarNombre.Focus()
                limpiarCampos()

            ElseIf Me.tbNuevoNombre.Text <> Me.tbConfirmarNombre.Text Then
                MessageBox.Show("Los Nombres no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()

            Else
                Dim tblCargo As New biomessDataSetTableAdapters.CargoTableAdapter
                tblCargo.UpdateQuery(ID_Departamento:=Me.cbNuevoDepar.SelectedValue,
                                     nombreCargo:=Me.tbNuevoNombre.Text,
                                     estado:=2,
                                     Original_ID_Departamento:=Me.cbNombreDepar.SelectedValue,
                                     Original_nombreCargo:=Me.tbNombreActual.Text)
                MessageBox.Show("El Cargo se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar al Modificar el Cargo: ", sqlex.Message())
            MsgBox("Error al registrar al Modificar el Cargo:: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar al Modificar el Cargo:: ", ex.Message())
            MsgBox("Error al registrar al Modificar el Cargo:: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Cargos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        limpiarCampos()
    End Sub



    Private Sub frmModificarCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.BiomessDataSet.Cargo)

    End Sub
    Private Sub limpiarCampos()
        Me.tbNuevoNombre.Text = ""
        Me.tbConfirmarNombre.Text = ""
        Me.cbNombreDepar.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub


End Class