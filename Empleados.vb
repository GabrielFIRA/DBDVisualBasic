Public Class Empleados
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AtrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtrasToolStripMenuItem.Click

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
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
End Class