Imports System.Data.SqlClient
Public Class frmCrearDepartamento
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmDepartamentos()
        win.Show()
        Me.Dispose()
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim _connection As Global.System.Data.SqlClient.SqlConnection
        Dim lector As SqlDataReader

        Try
            _connection = New Global.System.Data.SqlClient.SqlConnection
            _connection.ConnectionString = "Data Source=(local);Initial Catalog=biomess;Persist Security Info=True;User ID=sa;Password=Temporal2022+"
            _connection.Open()
            Dim sqlCommandSelect As SqlCommand = New SqlCommand("Select * from dbo.Organizacion", _connection)
            Dim ID_OrgTemp As Integer = 0
            lector = sqlCommandSelect.ExecuteReader()
            While (lector.Read())
                ID_OrgTemp = lector.GetInt32(0)
            End While
            'codigo de validacion de datos de entrada'
            If Me.tbNuevoNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()

            ElseIf Me.tbConfirmarNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarNombre.Focus()
                limpiarCampos()
            ElseIf Me.tbNuevoNombre.Text <> Me.tbConfirmarNombre.Text Then
                MessageBox.Show("Los Nombres no Coinciden no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.tbNuevoNombre.Focus()
                limpiarCampos()

                'Aqui esta el codigo que guarda'
            Else
                Dim tblDepartamento As New biomessDataSetTableAdapters.DepartamentoTableAdapter
                tblDepartamento.InsertQuery(ID_Organizacion:=ID_OrgTemp,
                                            nombreDepart:=Me.tbNuevoNombre.Text,
                                            estado:=1)
                MessageBox.Show("El registro se ha guardado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el Nuevo Departamento: ", sqlex.Message())
            MsgBox("Error al registrar el Nuevo Departamento: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el Nuevo Departamento: ", ex.Message())
            MsgBox("Error al registrar el Nuevo Departamento: ", ex.StackTrace())
        Finally
            _connection.Close()
            lector.Close()
        End Try
    End Sub

    Private Sub limpiarCampos()
        Me.tbNuevoNombre.Text = ""
        Me.tbConfirmarNombre.Text = ""
    End Sub

    Private Sub frmCrearDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BiomessDataSet.Departamento)
        limpiarCampos()
    End Sub

End Class