Public Class frmEmpresaEmpresa
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMostrarDatosEmpresa.Click
        Dim frmp As New frmMostrarEmpresa
        frmp.Show()
        Me.Dispose()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmPantallaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnModificarDatos_Click(sender As Object, e As EventArgs) Handles btnModificarDatos.Click
        Dim frmp As New frmModificarEmpresa
        frmp.Show()
        Me.Dispose()

    End Sub
End Class