Imports Microsoft.Reporting.WinForms

Public Class RptAsistencia
    Dim nombreEmpleado As String
    Sub New(ByVal nombreEmp As String)
        nombreEmpleado = nombreEmp

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub RptAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'biomessDataSet2.asistenciasView' table. You can move, or remove it, as needed.
        'Me.asistenciasViewTableAdapter.Fill(Me.biomessDataSet2.asistenciasView)
        Dim asiTA As New biomessDataSet2TableAdapters.asistenciasViewTableAdapter
        Dim asiDT As New biomessDataSet2.asistenciasViewDataTable
        asiTA.FillByNombre(asiDT, nombreEmpleado)

        Console.WriteLine(asiDT.Rows(0).Item(1).ToString)

        Dim reportDS As ReportDataSource = New ReportDataSource()
        reportDS.Name = "DataSet2"
        reportDS.Value = asiDT
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(reportDS)
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Biomess_0._1.RptAsistencia.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        Dim frm = New EAsistencias()
        frm.Show()
        Me.Dispose()
    End Sub
End Class