Public Class EModificarEmpleadoVacaciones
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New EModificarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim win = New EModificarEmpleadoCrearVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim win = New EModificarEmpleadoCrearVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim win = New EModificarEmpleadoModificarVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim win = New EModificarEmpleadoModificarVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim win = New EModificarEmpleadoEliminarVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim win = New EModificarEmpleadoEliminarVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim win = New EModificarEmpleadoMostrarVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim win = New EModificarEmpleadoMostrarVacaciones()
        Me.Dispose()
        win.Show()
    End Sub
End Class