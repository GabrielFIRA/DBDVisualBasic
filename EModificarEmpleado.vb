Public Class EModificarEmpleado
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim win = New Empleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim win = New EModificarEmpleadoAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim win = New EModificarEmpleadoAusencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim win = New EModificarEmpleadoMostrarAtrasos()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim win = New EModificarEmpleadoMostrarAtrasos()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim win = New EModificarEmpleadoFaltas()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim win = New EModificarEmpleadoFaltas()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim win = New EModificarEmpleadoVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Dim win = New EModificarEmpleadoVacaciones()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim win = New EModificarEmpleadoMostrarAsistencia()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim win = New EModificarEmpleadoMostrarAsistencia()
        Me.Dispose()
        win.Show()
    End Sub
End Class