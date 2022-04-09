Public Class Reportes
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHorasTrabajadas.Click
        If (ComboBox1.Text.Equals("Individual")) Then
            Dim win = New RHorasTrabajadasIndv()
            win.Load()
            Me.Dispose()
            win.Show()
        ElseIf ComboBox1.Text.Equals("Departamento") Then
            Dim win = New RHorasTrabajadasDepart()
            win.Load()
            win.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim win = New Login()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        If (ComboBox1.Text.Equals("Individual")) Then
            Dim win = New RGeneralIndividual()
            win.Load()
            Me.Dispose()
            win.Show()
        ElseIf ComboBox1.Text.Equals("Departamento") Then
            Dim win = New RGeneralDepart()
            win.Show()
            Me.Dispose()

        End If
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim win = New Empleados()
        Me.Dispose()
        win.Show()
    End Sub

    Private Sub btnAsistencia1_Click(sender As Object, e As EventArgs) Handles btnAsistencia1.Click
        If (ComboBox1.Text.Equals("Individual")) Then
            Dim win = New RAsistencia1Indv()
            Me.Dispose()
            win.Show()
        ElseIf ComboBox1.Text.Equals("Departamento") Then
            Dim win = New RAsistencia1Depart()
            Me.Dispose()
            win.Show()
        End If
    End Sub

    Private Sub btnAsistencia2_Click(sender As Object, e As EventArgs) Handles btnAsistencia2.Click
        If (ComboBox1.Text.Equals("Individual")) Then
            Dim win = New RAsistencia2Indv()
            Me.Dispose()
            win.Show()
        ElseIf ComboBox1.Text.Equals("Departamento") Then
            Dim win = New RAsistencia2Depart()
            Me.Dispose()
            win.Show()
        End If
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class