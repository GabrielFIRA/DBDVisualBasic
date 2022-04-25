Public Class EModificarEmpleadoCrearVacaciones
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim win = New EModificarEmpleadoVacaciones()
        Me.Dispose()
        win.Show()
    End Sub
End Class