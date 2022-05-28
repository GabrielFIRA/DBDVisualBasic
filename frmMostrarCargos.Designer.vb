<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMostrarCargos))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet = New Biomess_0._1.biomessDataSet()
        Me.CargoTableAdapter = New Biomess_0._1.biomessDataSetTableAdapters.CargoTableAdapter()
        Me.TableAdapterManager = New Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager()
        Me.CargoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Buscar = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter = New Biomess_0._1.biomessDataSetTableAdapters.DepartamentoTableAdapter()
        Me.BiomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.BiomessDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoTableAdapter1 = New Biomess_0._1.biomessDataSet2TableAdapters.CargoTableAdapter()
        Me.IDCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buscar.SuspendLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(12, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 54
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.BiomessDataSet
        '
        'BiomessDataSet
        '
        Me.BiomessDataSet.DataSetName = "biomessDataSet"
        Me.BiomessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AsistenciaTableAdapter = Nothing
        Me.TableAdapterManager.AtrasosTableAdapter = Nothing
        Me.TableAdapterManager.AusenciasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Me.CargoTableAdapter
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FaltasTableAdapter = Nothing
        Me.TableAdapterManager.HorariosTableAdapter = Nothing
        Me.TableAdapterManager.OpcionesTableAdapter = Nothing
        Me.TableAdapterManager.OrganizacionTableAdapter = Nothing
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.Rol_OpcionesTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'CargoDataGridView
        '
        Me.CargoDataGridView.AllowUserToAddRows = False
        Me.CargoDataGridView.AllowUserToDeleteRows = False
        Me.CargoDataGridView.AutoGenerateColumns = False
        Me.CargoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CargoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CargoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCargoDataGridViewTextBoxColumn, Me.IDDepartamentoDataGridViewTextBoxColumn, Me.NombreCargoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.CargoDataGridView.DataSource = Me.CargoBindingSource1
        Me.CargoDataGridView.Location = New System.Drawing.Point(42, 159)
        Me.CargoDataGridView.Name = "CargoDataGridView"
        Me.CargoDataGridView.ReadOnly = True
        Me.CargoDataGridView.Size = New System.Drawing.Size(724, 262)
        Me.CargoDataGridView.TabIndex = 54
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.Transparent
        Me.Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Buscar.Controls.Add(Me.TextBox1)
        Me.Buscar.Location = New System.Drawing.Point(42, 87)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(724, 50)
        Me.Buscar.TabIndex = 55
        Me.Buscar.Tag = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(716, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Buscar"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BiomessDataSet
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'BiomessDataSet2
        '
        Me.BiomessDataSet2.DataSetName = "biomessDataSet2"
        Me.BiomessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BiomessDataSet2BindingSource
        '
        Me.BiomessDataSet2BindingSource.DataSource = Me.BiomessDataSet2
        Me.BiomessDataSet2BindingSource.Position = 0
        '
        'CargoBindingSource1
        '
        Me.CargoBindingSource1.DataMember = "Cargo"
        Me.CargoBindingSource1.DataSource = Me.BiomessDataSet2BindingSource
        '
        'CargoTableAdapter1
        '
        Me.CargoTableAdapter1.ClearBeforeFill = True
        '
        'IDCargoDataGridViewTextBoxColumn
        '
        Me.IDCargoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDCargoDataGridViewTextBoxColumn.DataPropertyName = "ID_Cargo"
        Me.IDCargoDataGridViewTextBoxColumn.HeaderText = "ID_Cargo"
        Me.IDCargoDataGridViewTextBoxColumn.Name = "IDCargoDataGridViewTextBoxColumn"
        Me.IDCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCargoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDCargoDataGridViewTextBoxColumn.Visible = False
        '
        'IDDepartamentoDataGridViewTextBoxColumn
        '
        Me.IDDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn.HeaderText = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn.Name = "IDDepartamentoDataGridViewTextBoxColumn"
        Me.IDDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDepartamentoDataGridViewTextBoxColumn.Visible = False
        '
        'NombreCargoDataGridViewTextBoxColumn
        '
        Me.NombreCargoDataGridViewTextBoxColumn.DataPropertyName = "nombreCargo"
        Me.NombreCargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.NombreCargoDataGridViewTextBoxColumn.Name = "NombreCargoDataGridViewTextBoxColumn"
        Me.NombreCargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'frmMostrarCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.CargoDataGridView)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmMostrarCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mostrar Cargos"
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buscar.ResumeLayout(False)
        Me.Buscar.PerformLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents BiomessDataSet As biomessDataSet
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As biomessDataSetTableAdapters.CargoTableAdapter
    Friend WithEvents TableAdapterManager As biomessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CargoDataGridView As DataGridView
    Friend WithEvents Buscar As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As biomessDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents BiomessDataSet2BindingSource As BindingSource
    Friend WithEvents BiomessDataSet2 As biomessDataSet2
    Friend WithEvents CargoBindingSource1 As BindingSource
    Friend WithEvents CargoTableAdapter1 As biomessDataSet2TableAdapters.CargoTableAdapter
    Friend WithEvents IDCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
