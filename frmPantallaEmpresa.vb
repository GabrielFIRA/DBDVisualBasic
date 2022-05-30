Public Class frmPantallaEmpresa
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub frmPantallaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        Dim frmp As New frmEmpresaEmpresa
        Me.Dispose()

        frmp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        Dim frmp As New frmDepartamentos
        Me.Dispose()


        frmp.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        Dim frmp As New Cargos

        Me.Dispose()
        frmp.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Dim win = New Login()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim win = New Login()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Dim win = New Reportes()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim win = New Empleados()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim win = New Usuario()
        Me.Dispose()
        win.Show()
    End Sub


    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim win = New frmRptDepartamentos()
        Me.Dispose()
        win.Show()
    End Sub
End Class