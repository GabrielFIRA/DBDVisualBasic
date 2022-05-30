Public Class Usuario
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Dim win = New Reportes()
        win.Show()
        Me.Dispose()

    End Sub
    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim win = New frmPantallaEmpresa()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim win = New Empleados()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim win = New Login()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim win = New frmAgregarUsuario()
        win.Show()
        Me.Dispose()
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        'Dim win = New Buscar()
        'win.Show()
        'Me.Dispose()
    End Sub



    Private Sub btnRol_Click(sender As Object, e As EventArgs) Handles btnRol.Click
        Dim win = New frmRol()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnOpc_Click(sender As Object, e As EventArgs) Handles btnOpc.Click
        Dim win = New frmOpcion()
        win.Show()
        Me.Dispose()
    End Sub
End Class