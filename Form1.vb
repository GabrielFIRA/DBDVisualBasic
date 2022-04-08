Public Class BiomessES
    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Dim win = New EntradaSalida()
        win.Show()
        win.Start(True)
        Me.Hide()
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Dim win = New EntradaSalida()
        win.Show()
        win.Start(False)
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim win As New Login()
        win.Show()
        Me.Hide()

    End Sub
End Class
