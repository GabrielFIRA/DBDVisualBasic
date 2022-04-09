Public Class frmDepartamentos
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMostrarDepartamentos.Click
        Dim win = New frmMostrarDepartamentos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmPantallaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnEliminarDepartamentos_Click(sender As Object, e As EventArgs) Handles btnEliminarDepartamentos.Click
        Dim win = New frmEliminarDepartamento()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCrearDepartamento_Click(sender As Object, e As EventArgs) Handles btnCrearDepartamento.Click
        Dim win = New frmCrearDepartamento()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnModificarDepartamento_Click(sender As Object, e As EventArgs) Handles btnModificarDepartamento.Click
        Dim win = New frmModificarDepartamentos()
        win.Show()
        Me.Dispose()
    End Sub
End Class