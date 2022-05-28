Imports System.Data.SqlClient
Public Class frmCrearCargos
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Cargos()
        win.Show()
        Me.Dispose()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim _connection As Global.System.Data.SqlClient.SqlConnection
        Dim lector As SqlDataReader
        Try
            _connection = New Global.System.Data.SqlClient.SqlConnection
            _connection.ConnectionString = "Data Source=(local);Initial Catalog=biomess;Persist Security Info=True;User ID=sa;Password=Temporal2022+"
            _connection.Open()
            Dim sqlCommandSelect As SqlCommand = New SqlCommand("Select * from dbo.Departamento where nombreDepart = " + "'" + Me.cbNombreDepar.Text + "'", _connection)
            Dim ID_DepartTemp As Integer = 0
            lector = sqlCommandSelect.ExecuteReader()

            While (lector.Read())
                ID_DepartTemp = lector.GetInt32(0)
            End While
            If Me.tbNuevoNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre del Cargo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()


            ElseIf Me.tbConfirmarNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir ambos nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarNombre.Focus()
                limpiarCampos()

            ElseIf Me.tbNuevoNombre.Text <> Me.tbConfirmarNombre.Text Then
                MessageBox.Show("Los nombres no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()

            Else
                Dim tblCargo As New biomessDataSetTableAdapters.CargoTableAdapter
                tblCargo.InsertQuery(ID_Departamento:=ID_DepartTemp, nombreCargo:=Me.tbNuevoNombre.Text, estado:=1)
                MessageBox.Show("El Cargo se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar al agregar el Cargo: ", sqlex.Message())
            MsgBox("Error al registrar al agregar el Cargo:: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar al agregar el Cargo:: ", ex.Message())
            MsgBox("Error al registrar al agregar el Cargo:: ", ex.StackTrace())
        Finally
            _connection.Close()
            lector.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        limpiarCampos()
    End Sub


    Private Sub frmCrearCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        limpiarCampos()

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