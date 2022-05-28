<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRol = New System.Windows.Forms.DataGridView()
        Me.IDOpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescOpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txbBuscarO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEliminarO = New System.Windows.Forms.Button()
        Me.btnEditarO = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNuevoO = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregarO = New System.Windows.Forms.Button()
        Me.txbDescOpc = New System.Windows.Forms.TextBox()
        Me.txbOpcion = New System.Windows.Forms.TextBox()
        Me.txbIDO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpcionesTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.OpcionesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.dgvRol)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txbBuscarO)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnEliminarO)
        Me.GroupBox1.Controls.Add(Me.btnEditarO)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnNuevoO)
        Me.GroupBox1.Controls.Add(Me.btnAtras)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAgregarO)
        Me.GroupBox1.Controls.Add(Me.txbDescOpc)
        Me.GroupBox1.Controls.Add(Me.txbOpcion)
        Me.GroupBox1.Controls.Add(Me.txbIDO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(85, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1631, 855)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rol"
        '
        'dgvRol
        '
        Me.dgvRol.AutoGenerateColumns = False
        Me.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDOpcionDataGridViewTextBoxColumn, Me.NombreOpcionDataGridViewTextBoxColumn, Me.DescOpcionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvRol.DataSource = Me.OpcionesBindingSource
        Me.dgvRol.Location = New System.Drawing.Point(306, 550)
        Me.dgvRol.Name = "dgvRol"
        Me.dgvRol.RowHeadersWidth = 51
        Me.dgvRol.RowTemplate.Height = 24
        Me.dgvRol.Size = New System.Drawing.Size(1053, 276)
        Me.dgvRol.TabIndex = 42
        '
        'IDOpcionDataGridViewTextBoxColumn
        '
        Me.IDOpcionDataGridViewTextBoxColumn.DataPropertyName = "ID_Opcion"
        Me.IDOpcionDataGridViewTextBoxColumn.HeaderText = "ID_Opcion"
        Me.IDOpcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDOpcionDataGridViewTextBoxColumn.Name = "IDOpcionDataGridViewTextBoxColumn"
        Me.IDOpcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDOpcionDataGridViewTextBoxColumn.Width = 125
        '
        'NombreOpcionDataGridViewTextBoxColumn
        '
        Me.NombreOpcionDataGridViewTextBoxColumn.DataPropertyName = "nombreOpcion"
        Me.NombreOpcionDataGridViewTextBoxColumn.HeaderText = "nombreOpcion"
        Me.NombreOpcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreOpcionDataGridViewTextBoxColumn.Name = "NombreOpcionDataGridViewTextBoxColumn"
        Me.NombreOpcionDataGridViewTextBoxColumn.Width = 125
        '
        'DescOpcionDataGridViewTextBoxColumn
        '
        Me.DescOpcionDataGridViewTextBoxColumn.DataPropertyName = "descOpcion"
        Me.DescOpcionDataGridViewTextBoxColumn.HeaderText = "descOpcion"
        Me.DescOpcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescOpcionDataGridViewTextBoxColumn.Name = "DescOpcionDataGridViewTextBoxColumn"
        Me.DescOpcionDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(321, 482)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 32)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Buscar"
        '
        'txbBuscarO
        '
        Me.txbBuscarO.Location = New System.Drawing.Point(450, 476)
        Me.txbBuscarO.Name = "txbBuscarO"
        Me.txbBuscarO.Size = New System.Drawing.Size(864, 38)
        Me.txbBuscarO.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1159, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 58)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Eliminar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(921, 341)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 58)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        '
        'btnEliminarO
        '
        Me.btnEliminarO.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarO.BackgroundImage = CType(resources.GetObject("btnEliminarO.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarO.FlatAppearance.BorderSize = 4
        Me.btnEliminarO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEliminarO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarO.Location = New System.Drawing.Point(1164, 274)
        Me.btnEliminarO.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarO.Name = "btnEliminarO"
        Me.btnEliminarO.Size = New System.Drawing.Size(98, 63)
        Me.btnEliminarO.TabIndex = 37
        Me.btnEliminarO.UseVisualStyleBackColor = False
        '
        'btnEditarO
        '
        Me.btnEditarO.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarO.BackgroundImage = CType(resources.GetObject("btnEditarO.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditarO.FlatAppearance.BorderSize = 4
        Me.btnEditarO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditarO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarO.Location = New System.Drawing.Point(910, 274)
        Me.btnEditarO.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarO.Name = "btnEditarO"
        Me.btnEditarO.Size = New System.Drawing.Size(98, 63)
        Me.btnEditarO.TabIndex = 36
        Me.btnEditarO.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(363, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 32)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nuevo"
        '
        'btnNuevoO
        '
        Me.btnNuevoO.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoO.BackgroundImage = CType(resources.GetObject("btnNuevoO.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevoO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevoO.FlatAppearance.BorderSize = 4
        Me.btnNuevoO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNuevoO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoO.Location = New System.Drawing.Point(362, 274)
        Me.btnNuevoO.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoO.Name = "btnNuevoO"
        Me.btnNuevoO.Size = New System.Drawing.Size(98, 63)
        Me.btnNuevoO.TabIndex = 19
        Me.btnNuevoO.UseVisualStyleBackColor = False
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
        Me.btnAtras.Location = New System.Drawing.Point(29, 752)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 74)
        Me.btnAtras.TabIndex = 18
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(612, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 58)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & "Rol"
        '
        'btnAgregarO
        '
        Me.btnAgregarO.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarO.BackgroundImage = CType(resources.GetObject("btnAgregarO.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarO.FlatAppearance.BorderSize = 4
        Me.btnAgregarO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarO.Location = New System.Drawing.Point(617, 274)
        Me.btnAgregarO.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarO.Name = "btnAgregarO"
        Me.btnAgregarO.Size = New System.Drawing.Size(98, 63)
        Me.btnAgregarO.TabIndex = 14
        Me.btnAgregarO.UseVisualStyleBackColor = False
        '
        'txbDescOpc
        '
        Me.txbDescOpc.Location = New System.Drawing.Point(1026, 73)
        Me.txbDescOpc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbDescOpc.Name = "txbDescOpc"
        Me.txbDescOpc.Size = New System.Drawing.Size(541, 38)
        Me.txbDescOpc.TabIndex = 11
        '
        'txbOpcion
        '
        Me.txbOpcion.Location = New System.Drawing.Point(160, 137)
        Me.txbOpcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbOpcion.Name = "txbOpcion"
        Me.txbOpcion.Size = New System.Drawing.Size(541, 38)
        Me.txbOpcion.TabIndex = 8
        '
        'txbIDO
        '
        Me.txbIDO.Location = New System.Drawing.Point(160, 79)
        Me.txbIDO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbIDO.Name = "txbIDO"
        Me.txbIDO.ReadOnly = True
        Me.txbIDO.Size = New System.Drawing.Size(541, 38)
        Me.txbIDO.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(879, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Opcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'OpcionesTableAdapter
        '
        Me.OpcionesTableAdapter.ClearBeforeFill = True
        '
        'frmOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOpcion"
        Me.Text = "frmOpcion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRol As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents txbBuscarO As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEliminarO As Button
    Friend WithEvents btnEditarO As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnNuevoO As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregarO As Button
    Friend WithEvents txbDescOpc As TextBox
    Friend WithEvents txbOpcion As TextBox
    Friend WithEvents txbIDO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BiomessDataSet2 As biomessDataSet2
    Friend WithEvents OpcionesBindingSource As BindingSource
    Friend WithEvents OpcionesTableAdapter As biomessDataSet2TableAdapters.OpcionesTableAdapter
    Friend WithEvents IDOpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreOpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescOpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
