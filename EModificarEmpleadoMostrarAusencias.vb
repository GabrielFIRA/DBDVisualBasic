Public Class EModificarEmpleadoMostrarAusencias
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New EModificarEmpleadoAusencia()
        Me.Dispose()
        win.Show()
    End Sub
End Class