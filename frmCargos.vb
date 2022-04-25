Public Class frmCargos
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmPantallaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCrearCargo_Click(sender As Object, e As EventArgs) Handles btnCrearCargo.Click

    End Sub
End Class