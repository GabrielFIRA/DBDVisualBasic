Public Class RAsistencia2Indv
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Reportes()
        win.Show()
        Me.Dispose()
    End Sub
End Class