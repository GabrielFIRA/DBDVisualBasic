Public Class agregarUsuario
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Usuario()
        win.Show()
        Me.Dispose()
    End Sub
End Class