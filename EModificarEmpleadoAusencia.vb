Public Class EModificarEmpleadoAusencia
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim win = New EModificarEmpleadoModificarAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim win = New EModificarEmpleadoModificarAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim win = New EModificarEmpleadoEliminarAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim win = New EModificarEmpleadoEliminarAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim win = New EModificarEmpleadoMostrarAusencias()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim win = New EModificarEmpleadoMostrarAusencias()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New EModificarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub
End Class