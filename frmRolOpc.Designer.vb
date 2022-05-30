<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRolOpc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRolOpc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxOpc = New System.Windows.Forms.ComboBox()
        Me.OpcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.cbxRol = New System.Windows.Forms.ComboBox()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvRolOpc = New System.Windows.Forms.DataGridView()
        Me.IDRolOpcionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolopcViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet21 = New Biomess_0._1.biomessDataSet2()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txbBuscarRO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEliminarRO = New System.Windows.Forms.Button()
        Me.btnEditarRO = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNuevoRO = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregarRO = New System.Windows.Forms.Button()
        Me.txbIDRO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RolTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.RolTableAdapter()
        Me.OpcionesTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.OpcionesTableAdapter()
        Me.RolopcViewTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.rolopcViewTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRolOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolopcViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cbxOpc)
        Me.GroupBox1.Controls.Add(Me.cbxRol)
        Me.GroupBox1.Controls.Add(Me.dgvRolOpc)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txbBuscarRO)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnEliminarRO)
        Me.GroupBox1.Controls.Add(Me.btnEditarRO)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnNuevoRO)
        Me.GroupBox1.Controls.Add(Me.btnAtras)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAgregarRO)
        Me.GroupBox1.Controls.Add(Me.txbIDRO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(97, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1835, 1069)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rol"
        '
        'cbxOpc
        '
        Me.cbxOpc.DataSource = Me.OpcionesBindingSource
        Me.cbxOpc.DisplayMember = "nombreOpcion"
        Me.cbxOpc.FormattingEnabled = True
        Me.cbxOpc.Location = New System.Drawing.Point(1128, 88)
        Me.cbxOpc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxOpc.Name = "cbxOpc"
        Me.cbxOpc.Size = New System.Drawing.Size(587, 45)
        Me.cbxOpc.TabIndex = 44
        Me.cbxOpc.ValueMember = "ID_Opcion"
        '
        'OpcionesBindingSource
        '
        Me.OpcionesBindingSource.DataMember = "Opciones"
        Me.OpcionesBindingSource.DataSource = Me.BiomessDataSet2
        '
        'BiomessDataSet2
        '
        Me.BiomessDataSet2.DataSetName = "biomessDataSet2"
        Me.BiomessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxRol
        '
        Me.cbxRol.DataSource = Me.RolBindingSource
        Me.cbxRol.DisplayMember = "nombreRol"
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Location = New System.Drawing.Point(180, 179)
        Me.cbxRol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(608, 45)
        Me.cbxRol.TabIndex = 43
        Me.cbxRol.ValueMember = "ID_Rol"
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "Rol"
        Me.RolBindingSource.DataSource = Me.BiomessDataSet2
        '
        'dgvRolOpc
        '
        Me.dgvRolOpc.AutoGenerateColumns = False
        Me.dgvRolOpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRolOpc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRolOpcionesDataGridViewTextBoxColumn, Me.IDRolDataGridViewTextBoxColumn, Me.IDOpcionDataGridViewTextBoxColumn, Me.NombreRolDataGridViewTextBoxColumn, Me.NombreOpcionDataGridViewTextBoxColumn})
        Me.dgvRolOpc.DataSource = Me.RolopcViewBindingSource
        Me.dgvRolOpc.Location = New System.Drawing.Point(222, 670)
        Me.dgvRolOpc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvRolOpc.Name = "dgvRolOpc"
        Me.dgvRolOpc.RowHeadersWidth = 62
        Me.dgvRolOpc.RowTemplate.Height = 24
        Me.dgvRolOpc.Size = New System.Drawing.Size(1390, 332)
        Me.dgvRolOpc.TabIndex = 42
        '
        'IDRolOpcionesDataGridViewTextBoxColumn
        '
        Me.IDRolOpcionesDataGridViewTextBoxColumn.DataPropertyName = "ID_RolOpciones"
        Me.IDRolOpcionesDataGridViewTextBoxColumn.HeaderText = "ID_RolOpciones"
        Me.IDRolOpcionesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDRolOpcionesDataGridViewTextBoxColumn.Name = "IDRolOpcionesDataGridViewTextBoxColumn"
        Me.IDRolOpcionesDataGridViewTextBoxColumn.Width = 150
        '
        'IDRolDataGridViewTextBoxColumn
        '
        Me.IDRolDataGridViewTextBoxColumn.DataPropertyName = "ID_Rol"
        Me.IDRolDataGridViewTextBoxColumn.HeaderText = "ID_Rol"
        Me.IDRolDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDRolDataGridViewTextBoxColumn.Name = "IDRolDataGridViewTextBoxColumn"
        Me.IDRolDataGridViewTextBoxColumn.Visible = False
        Me.IDRolDataGridViewTextBoxColumn.Width = 150
        '
        'IDOpcionDataGridViewTextBoxColumn
        '
        Me.IDOpcionDataGridViewTextBoxColumn.DataPropertyName = "ID_Opcion"
        Me.IDOpcionDataGridViewTextBoxColumn.HeaderText = "ID_Opcion"
        Me.IDOpcionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDOpcionDataGridViewTextBoxColumn.Name = "IDOpcionDataGridViewTextBoxColumn"
        Me.IDOpcionDataGridViewTextBoxColumn.Visible = False
        Me.IDOpcionDataGridViewTextBoxColumn.Width = 150
        '
        'NombreRolDataGridViewTextBoxColumn
        '
        Me.NombreRolDataGridViewTextBoxColumn.DataPropertyName = "nombreRol"
        Me.NombreRolDataGridViewTextBoxColumn.HeaderText = "nombreRol"
        Me.NombreRolDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreRolDataGridViewTextBoxColumn.Name = "NombreRolDataGridViewTextBoxColumn"
        Me.NombreRolDataGridViewTextBoxColumn.Width = 150
        '
        'NombreOpcionDataGridViewTextBoxColumn
        '
        Me.NombreOpcionDataGridViewTextBoxColumn.DataPropertyName = "nombreOpcion"
        Me.NombreOpcionDataGridViewTextBoxColumn.HeaderText = "nombreOpcion"
        Me.NombreOpcionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreOpcionDataGridViewTextBoxColumn.Name = "NombreOpcionDataGridViewTextBoxColumn"
        Me.NombreOpcionDataGridViewTextBoxColumn.Width = 150
        '
        'RolopcViewBindingSource
        '
        Me.RolopcViewBindingSource.DataMember = "rolopcView"
        Me.RolopcViewBindingSource.DataSource = Me.BiomessDataSet21
        '
        'BiomessDataSet21
        '
        Me.BiomessDataSet21.DataSetName = "biomessDataSet2"
        Me.BiomessDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(361, 602)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 38)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Buscar"
        '
        'txbBuscarRO
        '
        Me.txbBuscarRO.Location = New System.Drawing.Point(507, 595)
        Me.txbBuscarRO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbBuscarRO.Name = "txbBuscarRO"
        Me.txbBuscarRO.Size = New System.Drawing.Size(972, 44)
        Me.txbBuscarRO.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1304, 426)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 64)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Eliminar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1036, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 64)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        '
        'btnEliminarRO
        '
        Me.btnEliminarRO.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarRO.BackgroundImage = CType(resources.GetObject("btnEliminarRO.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarRO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarRO.FlatAppearance.BorderSize = 4
        Me.btnEliminarRO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEliminarRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarRO.Location = New System.Drawing.Point(1310, 342)
        Me.btnEliminarRO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarRO.Name = "btnEliminarRO"
        Me.btnEliminarRO.Size = New System.Drawing.Size(111, 79)
        Me.btnEliminarRO.TabIndex = 37
        Me.btnEliminarRO.UseVisualStyleBackColor = False
        '
        'btnEditarRO
        '
        Me.btnEditarRO.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarRO.BackgroundImage = CType(resources.GetObject("btnEditarRO.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarRO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditarRO.FlatAppearance.BorderSize = 4
        Me.btnEditarRO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditarRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarRO.Location = New System.Drawing.Point(1023, 342)
        Me.btnEditarRO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditarRO.Name = "btnEditarRO"
        Me.btnEditarRO.Size = New System.Drawing.Size(111, 79)
        Me.btnEditarRO.TabIndex = 36
        Me.btnEditarRO.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(408, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 38)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nuevo"
        '
        'btnNuevoRO
        '
        Me.btnNuevoRO.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoRO.BackgroundImage = CType(resources.GetObject("btnNuevoRO.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevoRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoRO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevoRO.FlatAppearance.BorderSize = 4
        Me.btnNuevoRO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNuevoRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoRO.Location = New System.Drawing.Point(408, 342)
        Me.btnNuevoRO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevoRO.Name = "btnNuevoRO"
        Me.btnNuevoRO.Size = New System.Drawing.Size(111, 79)
        Me.btnNuevoRO.TabIndex = 19
        Me.btnNuevoRO.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAtras.FlatAppearance.BorderSize = 4
        Me.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(33, 940)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(84, 92)
        Me.btnAtras.TabIndex = 18
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(688, 426)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 64)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & "Rol"
        '
        'btnAgregarRO
        '
        Me.btnAgregarRO.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarRO.BackgroundImage = CType(resources.GetObject("btnAgregarRO.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarRO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarRO.FlatAppearance.BorderSize = 4
        Me.btnAgregarRO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRO.Location = New System.Drawing.Point(694, 342)
        Me.btnAgregarRO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarRO.Name = "btnAgregarRO"
        Me.btnAgregarRO.Size = New System.Drawing.Size(111, 79)
        Me.btnAgregarRO.TabIndex = 14
        Me.btnAgregarRO.UseVisualStyleBackColor = False
        '
        'txbIDRO
        '
        Me.txbIDRO.Location = New System.Drawing.Point(180, 99)
        Me.txbIDRO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbIDRO.Name = "txbIDRO"
        Me.txbIDRO.ReadOnly = True
        Me.txbIDRO.Size = New System.Drawing.Size(608, 44)
        Me.txbIDRO.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(989, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Opcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'OpcionesTableAdapter
        '
        Me.OpcionesTableAdapter.ClearBeforeFill = True
        '
        'RolopcViewTableAdapter
        '
        Me.RolopcViewTableAdapter.ClearBeforeFill = True
        '
        'frmRolOpc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(2439, 1266)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRolOpc"
        Me.Text = "frmRolOpc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRolOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolopcViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txbBuscarRO As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEliminarRO As Button
    Friend WithEvents btnEditarRO As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnNuevoRO As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregarRO As Button
    Friend WithEvents txbIDRO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxOpc As ComboBox
    Friend WithEvents cbxRol As ComboBox
    Friend WithEvents dgvRolOpc As DataGridView
    Friend WithEvents BiomessDataSet2 As biomessDataSet2
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As biomessDataSet2TableAdapters.RolTableAdapter
    Friend WithEvents OpcionesBindingSource As BindingSource
    Friend WithEvents OpcionesTableAdapter As biomessDataSet2TableAdapters.OpcionesTableAdapter
    Friend WithEvents BiomessDataSet21 As biomessDataSet2
    Friend WithEvents RolopcViewBindingSource As BindingSource
    Friend WithEvents RolopcViewTableAdapter As biomessDataSet2TableAdapters.rolopcViewTableAdapter
    Friend WithEvents IDRolOpcionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDOpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreOpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
