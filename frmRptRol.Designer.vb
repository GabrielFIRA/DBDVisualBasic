<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptRol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.biomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.RolTableAdapter()
        CType(Me.biomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DsRol"
        ReportDataSource1.Value = Me.RolBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Biomess_0._1.rptRol.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1353, 1037)
        Me.ReportViewer1.TabIndex = 0
        '
        'biomessDataSet2
        '
        Me.biomessDataSet2.DataSetName = "biomessDataSet2"
        Me.biomessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "Rol"
        Me.RolBindingSource.DataSource = Me.biomessDataSet2
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'frmRptRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1602, 1188)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRptRol"
        Me.Text = "frmRptRol"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.biomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents biomessDataSet2 As biomessDataSet2
    Friend WithEvents RolTableAdapter As biomessDataSet2TableAdapters.RolTableAdapter
End Class
