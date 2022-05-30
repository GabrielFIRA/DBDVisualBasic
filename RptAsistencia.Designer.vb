<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RptAsistencia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptAsistencia))
        Me.AsistenciasViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.biomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Atras = New System.Windows.Forms.Button()
        Me.asistenciasViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.asistenciasViewTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.asistenciasViewTableAdapter()
        CType(Me.AsistenciasViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asistenciasViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AsistenciasViewBindingSource1
        '
        Me.AsistenciasViewBindingSource1.DataMember = "asistenciasView"
        Me.AsistenciasViewBindingSource1.DataSource = Me.biomessDataSet2
        '
        'biomessDataSet2
        '
        Me.biomessDataSet2.DataSetName = "biomessDataSet2"
        Me.biomessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.AsistenciasViewBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Biomess_0._1.RptAsistencia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(275, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(848, 724)
        Me.ReportViewer1.TabIndex = 0
        '
        'Atras
        '
        Me.Atras.BackColor = System.Drawing.Color.Transparent
        Me.Atras.BackgroundImage = CType(resources.GetObject("Atras.BackgroundImage"), System.Drawing.Image)
        Me.Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Atras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Atras.Location = New System.Drawing.Point(10, 4)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(108, 41)
        Me.Atras.TabIndex = 69
        Me.Atras.UseVisualStyleBackColor = False
        '
        'asistenciasViewBindingSource
        '
        Me.asistenciasViewBindingSource.DataMember = "asistenciasView"
        Me.asistenciasViewBindingSource.DataSource = Me.biomessDataSet2
        '
        'asistenciasViewTableAdapter
        '
        Me.asistenciasViewTableAdapter.ClearBeforeFill = True
        '
        'RptAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Atras)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "RptAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RptAsistencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AsistenciasViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asistenciasViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents asistenciasViewBindingSource As BindingSource
    Friend WithEvents biomessDataSet2 As biomessDataSet2
    Friend WithEvents asistenciasViewTableAdapter As biomessDataSet2TableAdapters.asistenciasViewTableAdapter
    Friend WithEvents Atras As Button
    Friend WithEvents AsistenciasViewBindingSource1 As BindingSource
End Class
