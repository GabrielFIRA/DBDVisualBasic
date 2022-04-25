Public Class EModificarEmpleadoFaltas
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New EModificarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim win = New EModificarEmpleadoCambiarFaltaAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim win = New EModificarEmpleadoCambiarFaltaAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim win = New EModificarEmpleadoMostrarFaltas()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim win = New EModificarEmpleadoMostrarFaltas()
        Me.Dispose()
        win.Show()
    End Sub
End Class