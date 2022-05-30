Public Class frmRptRol
    Private Sub frmRptRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'biomessDataSet2.Rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.biomessDataSet2.Rol)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class