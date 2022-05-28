Imports System.Data.SqlClient
Public Class EHorarios
    Dim hora As Integer
    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub EHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet11.horariosView' Puede moverla o quitarla según sea necesario.
        Me.HorariosViewTableAdapter.Fill(Me.BiomessDataSet11.horariosView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet1.Horarios' Puede moverla o quitarla según sea necesario.
        Me.HorariosTableAdapter.Fill(Me.BiomessDataSet1.Horarios)

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub limpiarCampos()
        Me.cbEmpleado.SelectedIndex = -1
        Me.cbTipoHora.SelectedIndex = -1
    End Sub

    Private Sub horas()
        If Me.cbTipoHora.Text.Equals("Normal") Then
            hora = 0
        ElseIf Me.cbTipoHora.Text.Equals("Extra") Then
            hora = 1
        ElseIf Me.cbTipoHora.Text.Equals("Almuerzo") Then
            hora = 2
        ElseIf Me.cbTipoHora.Text.Equals("Suplementaria") Then
            hora = 3
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            horas()
            If Me.cbEmpleado.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.cbTipoHora.SelectedValue < 0 Then
                MessageBox.Show("Debe seleccionar un tipo de hora", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblHorarios As New biomessDataSet1TableAdapters.HorariosTableAdapter
                tblHorarios.InsertQuery(Me.cbEmpleado.SelectedValue, Me.tpInicio.Value.ToShortTimeString, Me.tpFinal.Value.ToShortTimeString, hora, 1)
                MessageBox.Show("El registro se ha guardado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.HorariosTableAdapter.Fill(Me.BiomessDataSet1.Horarios)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el horario: ", sqlex.Message())
            MsgBox("Error al registrar el horario: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el horario: ", ex.Message())
            MsgBox("Error al registrar el horario: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dgbHorarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbHorarios.CellContentClick
        Dim tempDate As Date = #8/13/2000 12:00 AM#
        Me.tpInicio.Value = tempDate + dgbHorarios.CurrentRow.Cells.Item(2).Value()
        Me.tpFinal.Value = tempDate + dgbHorarios.CurrentRow.Cells.Item(3).Value()



        Dim counter As Integer = 0
        Me.cbEmpleado.SelectedIndex = counter

        Dim row_v As DataRowView = cbEmpleado.SelectedItem
        Dim row As DataRow = row_v.Row
        Dim itemName As String = row(4).ToString()

        Console.WriteLine(itemName)

        While (True)
            If (itemName.Equals(dgbHorarios.CurrentRow.Cells.Item(1).Value.ToString())) Then
                Exit While
            ElseIf (cbEmpleado.Items.Count - 1 <> counter) Then
                counter += 1
                Me.cbEmpleado.SelectedIndex = counter
            Else
                Exit While
            End If
        End While

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim _connection As Global.System.Data.SqlClient.SqlConnection
        _connection = New Global.System.Data.SqlClient.SqlConnection
        Try
            _connection.ConnectionString = "Data Source=(local);Initial Catalog=biomess;Persist Security Info=True;User ID=sa;Password=Temporal2022+"
            _connection.Open()
            Dim ID_Hora As Integer = Convert.ToInt32(dgbHorarios.CurrentRow.Cells.Item(0).Value)

            If Me.cbEmpleado.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar el usuario a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim sqlCommandDelete As SqlCommand = New SqlCommand("Delete from Horarios where ID_Horarios = " + ID_Hora.ToString + "", _connection)
                sqlCommandDelete.ExecuteNonQuery()
                MessageBox.Show("El registro se ha eliminado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.HorariosTableAdapter.Fill(Me.BiomessDataSet1.Horarios)
                limpiarCampos()
            End If

        Catch sqlex As SqlException
            MsgBox("Error al eliminar el empleado: ", sqlex.Message())
            MsgBox("Error al eliminar el empleado: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar el empleado: ", ex.Message())
            MsgBox("Error al eliminar el empleado: ", ex.StackTrace())
        Finally
            _connection.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim _connection As Global.System.Data.SqlClient.SqlConnection
        _connection = New Global.System.Data.SqlClient.SqlConnection

        horas()
        Dim ID_Hora As Integer = dgbHorarios.CurrentRow.Cells.Item(0).Value

        Try
            _connection.ConnectionString = "Data Source=(local);Initial Catalog=biomess;Persist Security Info=True;User ID=sa;Password=Temporal2022+"
            _connection.Open()
            If Me.cbEmpleado.SelectedIndex = -1 Or Me.cbTipoHora.SelectedIndex = -1 Then
                MessageBox.Show("Tiene que selecionar para cada combobox", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim sqlCommandUpdate As SqlCommand = New SqlCommand("Update Horarios set horaEntrada = '" + Me.tpInicio.Value.ToShortTimeString + "', horaSalida = '" + Me.tpFinal.Value.ToShortTimeString + "', tipoHora = " + Me.hora.ToString + ", estado = 1 where ID_Horarios = " + ID_Hora.ToString, _connection)

                sqlCommandUpdate.ExecuteNonQuery()
                MessageBox.Show("El registro se ha Editado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.HorariosTableAdapter.Fill(Me.BiomessDataSet1.Horarios)
                limpiarCampos()
            End If


        Catch sqlex As SqlException
            MsgBox("Error al eliminar el empleado: ", sqlex.Message())
            MsgBox("Error al eliminar el empleado: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar el empleado: ", ex.Message())
            MsgBox("Error al eliminar el empleado: ", ex.StackTrace())
        Finally
            _connection.Close()
        End Try



    End Sub
End Class