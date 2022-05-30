Imports System.Data.SqlClient
Public Class EAtrasos
    Private Sub EAtrasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.atrasosView' Puede moverla o quitarla según sea necesario.
        Me.AtrasosViewTableAdapter.Fill(Me.BiomessDataSet1.atrasosView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Atrasos' Puede moverla o quitarla según sea necesario.
        Me.AtrasosTableAdapter.Fill(Me.BiomessDataSet1.Atrasos)
    End Sub

    Private Sub limpiarCampos()

        Me.cbEmpleado.SelectedIndex = -1
        Me.txbJustificacion.Text = ""
    End Sub

    Private Sub Tiempo()
        Dim Tiempo As Integer
        Dim tblTiempo As New biomessDataSet1TableAdapters.AtrasosTableAdapter
        'tblTiempo.FillBy(Me.cbEmpleado.)
        'Tiempo = DateDiff("h", Me., Me.tpHora.Value)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblAtrasos As New biomessDataSet1TableAdapters.AtrasosTableAdapter
                'tblAtrasos.InsertQuery(Me.cbEmpleado.SelectedValue, )
                Me.AtrasosTableAdapter.Fill(Me.BiomessDataSet1.Atrasos)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el atraso: ", sqlex.Message())
            MsgBox("Error al registrar el atraso: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el atraso: ", ex.Message())
            MsgBox("Error al registrar el atraso: ", ex.StackTrace())
        End Try
    End Sub
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub
End Class