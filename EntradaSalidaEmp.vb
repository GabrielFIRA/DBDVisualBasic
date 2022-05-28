Imports System.Data.SqlClient
Public Class EntradaSalida
    Dim Entrada = True

    Public Sub Start(EoS As Boolean)
        Entrada = EoS
        If Entrada Then
            lbEoS.Text = "Entrada"
        Else
            lbEoS.Text = "Salida"
        End If


    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
        BiomessES.Show()
    End Sub

    Private Sub EntradaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BiomessDataSet2.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BiomessDataSet2.Empleado)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim row_v As DataRowView = cbNombreEmp.SelectedItem
        Dim row As DataRow = row_v.Row
        Dim itemName As String = row(9).ToString()
        Dim EoS As Integer = If((Entrada = True), 1, 0)

        Dim HoraEntrada As String = DateTime.Now.ToString
        Dim fechaActual As String = "" + HoraEntrada.Chars(6) + HoraEntrada.Chars(7) + HoraEntrada.Chars(8) + HoraEntrada.Chars(9) + "-" + HoraEntrada.Chars(3) + HoraEntrada.Chars(4) + "-" + HoraEntrada.Chars(0) + HoraEntrada.Chars(1)
        HoraEntrada = "" + HoraEntrada.Chars(11) + HoraEntrada.Chars(12) + HoraEntrada.Chars(13) + HoraEntrada.Chars(14) + HoraEntrada.Chars(15) + HoraEntrada.Chars(16) + HoraEntrada.Chars(17) + HoraEntrada.Chars(18)

        Console.WriteLine(fechaActual)

        Dim _connection As Global.System.Data.SqlClient.SqlConnection
        _connection = New Global.System.Data.SqlClient.SqlConnection
        Dim commandInsert As SqlCommand
        Dim commandUpdate As SqlCommand
        Dim commandSelect As SqlCommand
        Dim reader As SqlDataReader
        Dim existe As Boolean   'Verificar si existe un registro de asistencia cuyo valor EoS sea = 1 para prevenir nuevos registros de entrada'

        Try
            _connection.ConnectionString = "Data Source=(local);Initial Catalog=biomess;Persist Security Info=True;User ID=sa;Password=Temporal2022+"
            _connection.Open()
            commandSelect = New SqlCommand("select * from Asistencia", _connection)
            reader = commandSelect.ExecuteReader()

            While (reader.Read())
                Dim temp As Integer
                Console.WriteLine("" + reader.GetBoolean(4).ToString)

                temp = reader.GetInt32(4)
                If temp = 1 Then
                    existe = True
                    Exit While
                End If

            End While

            Console.WriteLine("" + existe)

            If tbPIN.Text.Equals(itemName) Then
                If Entrada = True And existe = False Then
                    commandInsert = New SqlCommand("Insert into Asistencia(ID_Empleado, horaEntrada, EoS, estado, fecha, semana) Values(" + row(0).ToString + ", '" + HoraEntrada + "', " + 1 + ", '" + fechaActual + "', " + 1 + ")", _connection)
                Else
                    MessageBox.Show("Aun no a marcado salida en otro registro de asistencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If Entrada = False & existe = True Then
                    'commandUpdate
                End If
            Else
                MessageBox.Show("CONTRASEÑA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar el horario: ", sqlex.Message())
            MsgBox("Error al registrar el horario: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar el horario: ", ex.Message())
            MsgBox("Error al registrar el horario: ", ex.StackTrace())
        Finally
            _connection.Close()
        End Try

    End Sub
End Class