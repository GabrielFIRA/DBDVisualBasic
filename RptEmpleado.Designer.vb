<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptEmpleado))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.biomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.empleadoViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empleadoViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.empleadoViewTableAdapter()
        Me.Atras = New System.Windows.Forms.Button()
        CType(Me.biomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empleadoViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ds1InforEmpleado"
        ReportDataSource1.Value = Me.empleadoViewBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Biomess_0._1.RptEmpleado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(190, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1151, 705)
        Me.ReportViewer1.TabIndex = 0
        '
        'biomessDataSet1
        '
        Me.biomessDataSet1.DataSetName = "biomessDataSet1"
        Me.biomessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'empleadoViewBindingSource
        '
        Me.empleadoViewBindingSource.DataMember = "empleadoView"
        Me.empleadoViewBindingSource.DataSource = Me.biomessDataSet1
        '
        'empleadoViewTableAdapter
        '
        Me.empleadoViewTableAdapter.ClearBeforeFill = True
        '
        'Atras
        '
        Me.Atras.BackColor = System.Drawing.Color.Transparent
        Me.Atras.BackgroundImage = CType(resources.GetObject("Atras.BackgroundImage"), System.Drawing.Image)
        Me.Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Atras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Atras.Location = New System.Drawing.Point(12, 12)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(108, 41)
        Me.Atras.TabIndex = 63
        Me.Atras.UseVisualStyleBackColor = False
        '
        'RptEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1353, 729)
        Me.Controls.Add(Me.Atras)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RptEmpleado"
        Me.Text = "RptEmpleado"
        CType(Me.biomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empleadoViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents empleadoViewBindingSource As BindingSource
    Friend WithEvents biomessDataSet1 As biomessDataSet1
    Friend WithEvents empleadoViewTableAdapter As biomessDataSet1TableAdapters.empleadoViewTableAdapter
    Friend WithEvents Atras As Button
End Class
