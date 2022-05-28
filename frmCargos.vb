Public Class Cargos
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmPantallaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCrearCargo_Click(sender As Object, e As EventArgs) Handles btnCrearCargo.Click
        Dim win = New frmCrearCargos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnModificarCargo_Click(sender As Object, e As EventArgs) Handles btnModificarCargo.Click
        Dim win = New frmModificarCargo()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEliminarCargos_Click(sender As Object, e As EventArgs) Handles btnEliminarCargos.Click
        Dim win = New frmEliminarCargo()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnMostrarCargos_Click(sender As Object, e As EventArgs) Handles BtnMostrarCargos.Click
        Dim win = New frmMostrarCargos()
        win.Show()
        Me.Dispose()
    End Sub
End Class