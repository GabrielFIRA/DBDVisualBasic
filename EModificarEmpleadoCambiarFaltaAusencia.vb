Public Class EModificarEmpleadoCambiarFaltaAusencia
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New EModificarEmpleadoFaltas()
        Me.Dispose()
        win.Show()
    End Sub
End Class