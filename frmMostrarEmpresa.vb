Public Class frmMostrarEmpresa
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmEmpresaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub
End Class