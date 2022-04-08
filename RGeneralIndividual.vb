Public Class RGeneralIndividual
    Public Sub Load()
        Label17.Text = "Permisos:"
        Label9.Text = "Vacaciones:"
        Label10.Text = "Maternidad:"
        Label11.Text = "Paternidad:"
        Label12.Text = "Enfermedad:"
        Label13.Text = "Atrasos:"
        Label14.Text = "Ausencias:"
        Label15.Text = "Faltas:"
        Label18.Text = "Horas trabajadas:"
        Label20.Text = "Horas no trabajadas:"
        Label21.Text = "Horas extra:"
        Label19.Text = "Horas suplementarias:"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Label17.Location = New Point(10, 45 - VScrollBar1.Value)
        Label9.Location = New Point(10, (45 * 2) - (VScrollBar1.Value + 10))
        Label10.Location = New Point(10, (45 * 3) - (VScrollBar1.Value + 10))
        Label11.Location = New Point(10, (45 * 4) - (VScrollBar1.Value + 10))
        Label12.Location = New Point(10, (45 * 5) - (VScrollBar1.Value + 10))
        Label13.Location = New Point(10, (45 * 6) - (VScrollBar1.Value + 10))
        Label14.Location = New Point(10, (45 * 7) - (VScrollBar1.Value + 10))
        Label15.Location = New Point(10, (45 * 8) - (VScrollBar1.Value + 10))
        Label18.Location = New Point(10, (45 * 9) - (VScrollBar1.Value + 10))
        Label20.Location = New Point(10, (45 * 10) - (VScrollBar1.Value + 10))
        Label21.Location = New Point(10, (45 * 11) - (VScrollBar1.Value + 10))
        Label19.Location = New Point(10, (45 * 12) - (VScrollBar1.Value + 10))

        HideLabels(Label17)
        HideLabels(Label9)
        HideLabels(Label10)
        HideLabels(Label11)
        HideLabels(Label12)
        HideLabels(Label13)
        HideLabels(Label14)
        HideLabels(Label15)
        HideLabels(Label18)
        HideLabels(Label20)
        HideLabels(Label21)
        HideLabels(Label19)
    End Sub

    Private Sub HideLabels(lbObj As Label)
        If lbObj.Location.Y < 0 Then
            lbObj.Hide()
        Else
            lbObj.Show()
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Reportes()
        win.Show()
        Me.Dispose()
    End Sub
End Class