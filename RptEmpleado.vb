Public Class RptEmpleado
    Private Sub RptEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'biomessDataSet1.empleadoView' Puede moverla o quitarla según sea necesario.
        Me.empleadoViewTableAdapter.Fill(Me.biomessDataSet1.empleadoView)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim win = New EEmpleados()
        win.Show()
        Me.Dispose()
    End Sub
End Class