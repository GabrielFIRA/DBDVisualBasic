<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMostrarEmpresa))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.OrganizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet = New Biomess_0._1.biomessDataSet()
        Me.OrganizacionTableAdapter = New Biomess_0._1.biomessDataSetTableAdapters.OrganizacionTableAdapter()
        Me.OrganizacionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager()
        Me.OrganizacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OrganizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganizacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganizacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(12, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'OrganizacionBindingSource
        '
        Me.OrganizacionBindingSource.DataMember = "Organizacion"
        Me.OrganizacionBindingSource.DataSource = Me.BiomessDataSetBindingSource
        '
        'BiomessDataSetBindingSource
        '
        Me.BiomessDataSetBindingSource.DataSource = Me.BiomessDataSet
        Me.BiomessDataSetBindingSource.Position = 0
        '
        'BiomessDataSet
        '
        Me.BiomessDataSet.DataSetName = "biomessDataSet"
        Me.BiomessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrganizacionTableAdapter
        '
        Me.OrganizacionTableAdapter.ClearBeforeFill = True
        '
        'OrganizacionBindingSource1
        '
        Me.OrganizacionBindingSource1.DataMember = "Organizacion"
        Me.OrganizacionBindingSource1.DataSource = Me.BiomessDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AsistenciaTableAdapter = Nothing
        Me.TableAdapterManager.AtrasosTableAdapter = Nothing
        Me.TableAdapterManager.AusenciasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FaltasTableAdapter = Nothing
        Me.TableAdapterManager.HorariosTableAdapter = Nothing
        Me.TableAdapterManager.OpcionesTableAdapter = Nothing
        Me.TableAdapterManager.OrganizacionTableAdapter = Me.OrganizacionTableAdapter
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.Rol_OpcionesTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'OrganizacionDataGridView
        '
        Me.OrganizacionDataGridView.AllowUserToAddRows = False
        Me.OrganizacionDataGridView.AllowUserToDeleteRows = False
        Me.OrganizacionDataGridView.AutoGenerateColumns = False
        Me.OrganizacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrganizacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.OrganizacionDataGridView.DataSource = Me.OrganizacionBindingSource1
        Me.OrganizacionDataGridView.Location = New System.Drawing.Point(132, 125)
        Me.OrganizacionDataGridView.Name = "OrganizacionDataGridView"
        Me.OrganizacionDataGridView.ReadOnly = True
        Me.OrganizacionDataGridView.Size = New System.Drawing.Size(534, 258)
        Me.OrganizacionDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Organizacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Organizacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreOrg"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Empresa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'frmMostrarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.OrganizacionDataGridView)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmMostrarEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mostrar Empresa"
        CType(Me.OrganizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganizacionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganizacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents BiomessDataSetBindingSource As BindingSource
    Friend WithEvents BiomessDataSet As biomessDataSet
    Friend WithEvents OrganizacionBindingSource As BindingSource
    Friend WithEvents OrganizacionTableAdapter As biomessDataSetTableAdapters.OrganizacionTableAdapter
    Friend WithEvents OrganizacionBindingSource1 As BindingSource
    Friend WithEvents TableAdapterManager As biomessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrganizacionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
