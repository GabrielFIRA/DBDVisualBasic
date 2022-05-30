Imports System.Data.SqlClient
Public Class frmModificarDepartamentos
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmDepartamentos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.tbNombreActual.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre actual del departamento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbNombreActual.Focus()
                limpiarCampos()


            ElseIf Me.tbConfirmarNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir ambos nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarNombre.Focus()
                limpiarCampos()

            ElseIf Me.tbNuevoNombre.Text <> Me.tbConfirmarNombre.Text Then
                MessageBox.Show("Las nombres no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()

            ElseIf Me.tbNuevoNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()


            Else
                Dim rows() As DataRow = Me.OrganizacionTableAdapter.GetData.Select()
                Dim id_orgTemp As Integer = rows(0).Item("ID_Organizacion")

                Dim tblDepartamento As New biomessDataSetTableAdapters.DepartamentoTableAdapter
                tblDepartamento.UpdateQuery(ID_Organizacion:=id_orgTemp,
                                            nombreDepart:=Me.tbNuevoNombre.Text,
                                            estado:=2,
                                            Original_nombreDepart:=Me.tbNombreActual.Text)
                MessageBox.Show("El registro se ha guardado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al modificar el Departamento: ", sqlex.Message())
            MsgBox("Error al modificar el Departamento: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al modificar el Departamento: ", ex.Message())
            MsgBox("Error al modificar el Departamento: ", ex.StackTrace())
        End Try
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        Me.tbNuevoNombre.Text = ""
        Me.tbConfirmarNombre.Text = ""
        Me.tbNombreActual.Text = ""
    End Sub

    Private Sub frmModificarDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BiomessDataSet2.Organizacion' table. You can move, or remove it, as needed.
        Me.OrganizacionTableAdapter.Fill(Me.BiomessDataSet2.Organizacion)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        limpiarCampos()

    End Sub
End Class