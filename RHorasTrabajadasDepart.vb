Public Class RHorasTrabajadasDepart
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Reportes()
        win.Show()
        Me.Dispose()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Public Sub Load()
        Dim fecha = 1
        Dim mes = 1
        Dim año = 2010
        While (fecha < 32)
            cbFecha.Items.Add(fecha)
            fecha += 1
        End While
        While (mes < 13)
            cbMes1.Items.Add(mes)
            cbMes2.Items.Add(mes)
            mes += 1
        End While
        While (año < 2050)
            cbAño1.Items.Add(año)
            cbAño2.Items.Add(año)
            año += 1
        End While
        cbMes2.Enabled = False
        cbAño2.Enabled = False
        cbSemana.Enabled = False


    End Sub

    Private Sub cbTiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiempo.SelectedIndexChanged
        If (cbTiempo.Text.Equals("Dia")) Then
            cbMes2.Enabled = False
            cbAño2.Enabled = False
            cbSemana.Enabled = False
            cbMes1.Enabled = True
            cbFecha.Enabled = True
            cbAño1.Enabled = True

        ElseIf (cbTiempo.Text.Equals("Mes")) Then
            cbMes1.Enabled = False
            cbFecha.Enabled = False
            cbAño1.Enabled = False
            cbSemana.Enabled = False
            cbMes2.Enabled = True
            cbAño2.Enabled = True

        ElseIf (cbTiempo.Text.Equals("Semana")) Then
            cbMes1.Enabled = False
            cbFecha.Enabled = False
            cbAño1.Enabled = False
            cbMes2.Enabled = False
            cbAño2.Enabled = False
            cbSemana.Enabled = True
        End If
    End Sub
End Class