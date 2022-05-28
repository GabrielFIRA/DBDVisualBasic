Imports System.Data.SqlClient
Public Class frmModificarCargo

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim _connection As Global.System.Data.SqlClient.SqlConnection
        Dim lector As SqlDataReader
        Try
            _connection = New Global.System.Data.SqlClient.SqlConnection
            _connection.ConnectionString = "Data Source=(local);Initial Catalog=biomess;Persist Security Info=True;User ID=sa;Password=Temporal2022+"
            _connection.Open()

            'Departamento actual'
            Dim sqlCommandSelect As SqlCommand = New SqlCommand("Select * from dbo.Departamento where nombreDepart = " + "'" + Me.cbNombreDepar.Text + "'", _connection)
            Dim ID_DepartActual As Integer = 0
            lector = sqlCommandSelect.ExecuteReader()

            While (lector.Read())
                ID_DepartActual = lector.GetInt32(0)
            End While

            lector.Close()
            'Departamento Nuevo'
            sqlCommandSelect = New SqlCommand("Select * from dbo.Departamento where nombreDepart = " + "'" + Me.cbNuevoDepar.Text + "'", _connection)
            Dim ID_DepartNuevo As Integer = 0
            lector = sqlCommandSelect.ExecuteReader()



            While (lector.Read())
                ID_DepartNuevo = lector.GetInt32(0)
            End While

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
                tblCargo.UpdateQuery(ID_Departamento:=ID_DepartNuevo,    ' Nuevo ID_Departamento
                                     nombreCargo:=Me.tbNuevoNombre.Text,                ' Nuevo Nombre de Cargo
                                     estado:=2,                                         ' Estado
                                     Original_ID_Departamento:=ID_DepartActual, 'ID_Original_Departamento
                                     Original_nombreCargo:=Me.tbNombreActual.Text)      ' Nombre Original del Cargo
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
        Finally
            _connection.Close()
            lector.Close()
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