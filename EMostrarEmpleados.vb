Public Class EMostrarEmpleados
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub
End Class