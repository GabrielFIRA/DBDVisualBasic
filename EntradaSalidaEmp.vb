Public Class EntradaSalida
    Dim Entrada = True

    Public Sub Start(EoS As Boolean)
        Entrada = EoS
        If Entrada Then
            lbEoS.Text = "Entrada"
        Else
            lbEoS.Text = "Salida"
        End If


    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
        BiomessES.Show()
    End Sub
End Class