Public Class frmPantallaEmpresa
    Private Sub frmPantallaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        Dim frmp As New frmEmpresaEmpresa
        Me.Close()

        frmp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        Dim frmp As New frmDepartamentos
        Me.Close()

        frmp.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        Dim frmp As New frmCargos

        Me.Close()
        frmp.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub
End Class