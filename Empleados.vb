Public Class Empleados

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub AtrasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim win = New Reportes()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim win = New EAgregarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim win = New EModificarEmpleado()
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim win = New EAgregarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim win = New EModificarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim win = New EEliminarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim win = New EEliminarEmpleado()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim win = New EMostrarEmpleados()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim win = New EMostrarEmpleados()
        win.Show()
        Me.Dispose()
    End Sub
End Class