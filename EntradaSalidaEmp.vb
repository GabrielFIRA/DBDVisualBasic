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
        'TODO: This line of code loads data into the 'BiomessDataSet2.Asistencia' table. You can move, or remove it, as needed.
        Me.AsistenciaTableAdapter.Fill(Me.BiomessDataSet2.Asistencia)
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

        Console.WriteLine("" + Me.AsistenciaTableAdapter.existeEntrada(row(0)).ToString)
        Dim existe As Boolean
        If Me.AsistenciaTableAdapter.existeEntrada(row(0)).ToString.Equals("") Then
            existe = False
        Else
            existe = Me.AsistenciaTableAdapter.existeEntrada(row(0))  'Verificar si existe un registro de asistencia cuyo valor EoS sea = 1 para prevenir nuevos registros de entrada'

        End If

        Try
            Console.WriteLine("" + Entrada.ToString)
            If tbPIN.Text.Equals(itemName) Then
                If Entrada = True And existe = False Then
                    Dim tblAsistencia As New biomessDataSet2TableAdapters.AsistenciaTableAdapter
                    tblAsistencia.nuevaAsistencia(row(0), HoraEntrada, Nothing, True, fechaActual, 1, 1)
                    MessageBox.Show("Rergistro de Entrada guardado exitosamente", "Biomess", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Entrada = True Then
                    MessageBox.Show("Aun no a marcado salida en otro registro de asistencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If Entrada = False And existe = True Then
                    'commandUpdate
                    Dim tblAsistencia As New biomessDataSet2TableAdapters.AsistenciaTableAdapter
                    tblAsistencia.guardarSalida(HoraEntrada, False, True, row(0))
                    MessageBox.Show("Rergistro de Salida guardado exitosamente", "Biomess", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf Entrada = False Then
                    MessageBox.Show("No existe ningun registro de entrada a guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        End Try

    End Sub
End Class