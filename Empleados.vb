Public Class Empleados

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim win = New Reportes()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Dim frm = New Reportes()
        Me.Dispose()
        frm.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim win = New Usuario()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim win = New Login()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim win = New frmPantallaEmpresa()
        Me.Dispose()
        win.Show()
    End Sub
    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim win = New EEmpleados()
        Me.Dispose()
        win.Show()
    End Sub
    Private Sub lklEmpleados_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklEmpleados.LinkClicked
        Dim win = New EEmpleados()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub btnAusencias_Click(sender As Object, e As EventArgs) Handles btnAusencias.Click
        Dim win = New EAusencias()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub lklAusencias_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAusencias.LinkClicked
        Dim win = New EAusencias()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim win = New EAtrasos()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim win = New EAtrasos()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim win = New EFaltas()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim win = New EFaltas()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim win = New EHorarios()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim win = New EHorarios()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim win = New Vacaciones()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Dim win = New Vacaciones()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim win = New EAsistencias()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim win = New EAsistencias()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim win = New EPermisos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Dim win = New EPermisos()
        win.Show()
        Me.Dispose()
    End Sub
End Class