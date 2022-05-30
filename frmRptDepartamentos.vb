Public Class frmRptDepartamentos
    Private Sub frmRptDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'biomessDataSet2.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.biomessDataSet2.Departamento)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim win = New frmPantallaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub
End Class