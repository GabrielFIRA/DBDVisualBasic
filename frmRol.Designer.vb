<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRol))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRol = New System.Windows.Forms.DataGridView()
        Me.IDRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txbBuscarR = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEliminarR = New System.Windows.Forms.Button()
        Me.btnEditarR = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNuevoR = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregarR = New System.Windows.Forms.Button()
        Me.txbDescRol = New System.Windows.Forms.TextBox()
        Me.txbRol = New System.Windows.Forms.TextBox()
        Me.txbIDR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RolTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.RolTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.dgvRol)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txbBuscarR)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnEliminarR)
        Me.GroupBox1.Controls.Add(Me.btnEditarR)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnNuevoR)
        Me.GroupBox1.Controls.Add(Me.btnAtras)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAgregarR)
        Me.GroupBox1.Controls.Add(Me.txbDescRol)
        Me.GroupBox1.Controls.Add(Me.txbRol)
        Me.GroupBox1.Controls.Add(Me.txbIDR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1223, 695)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rol"
        '
        'dgvRol
        '
        Me.dgvRol.AutoGenerateColumns = False
        Me.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRolDataGridViewTextBoxColumn, Me.NombreRolDataGridViewTextBoxColumn, Me.DescRolDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvRol.DataSource = Me.RolBindingSource
        Me.dgvRol.Location = New System.Drawing.Point(230, 447)
        Me.dgvRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvRol.Name = "dgvRol"
        Me.dgvRol.RowHeadersWidth = 51
        Me.dgvRol.RowTemplate.Height = 24
        Me.dgvRol.Size = New System.Drawing.Size(790, 224)
        Me.dgvRol.TabIndex = 42
        '
        'IDRolDataGridViewTextBoxColumn
        '
        Me.IDRolDataGridViewTextBoxColumn.DataPropertyName = "ID_Rol"
        Me.IDRolDataGridViewTextBoxColumn.HeaderText = "ID_Rol"
        Me.IDRolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDRolDataGridViewTextBoxColumn.Name = "IDRolDataGridViewTextBoxColumn"
        Me.IDRolDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDRolDataGridViewTextBoxColumn.Width = 125
        '
        'NombreRolDataGridViewTextBoxColumn
        '
        Me.NombreRolDataGridViewTextBoxColumn.DataPropertyName = "nombreRol"
        Me.NombreRolDataGridViewTextBoxColumn.HeaderText = "nombreRol"
        Me.NombreRolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreRolDataGridViewTextBoxColumn.Name = "NombreRolDataGridViewTextBoxColumn"
        Me.NombreRolDataGridViewTextBoxColumn.Width = 125
        '
        'DescRolDataGridViewTextBoxColumn
        '
        Me.DescRolDataGridViewTextBoxColumn.DataPropertyName = "descRol"
        Me.DescRolDataGridViewTextBoxColumn.HeaderText = "descRol"
        Me.DescRolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescRolDataGridViewTextBoxColumn.Name = "DescRolDataGridViewTextBoxColumn"
        Me.DescRolDataGridViewTextBoxColumn.Width = 125
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
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "Rol"
        Me.RolBindingSource.DataSource = Me.BiomessDataSet2
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
        Me.Label13.Location = New System.Drawing.Point(241, 392)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 26)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Buscar"
        '
        'txbBuscarR
        '
        Me.txbBuscarR.Location = New System.Drawing.Point(338, 387)
        Me.txbBuscarR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbBuscarR.Name = "txbBuscarR"
        Me.txbBuscarR.Size = New System.Drawing.Size(649, 32)
        Me.txbBuscarR.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(869, 277)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 48)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Eliminar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(691, 277)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 48)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rol"
        '
        'btnEliminarR
        '
        Me.btnEliminarR.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarR.BackgroundImage = CType(resources.GetObject("btnEliminarR.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarR.FlatAppearance.BorderSize = 4
        Me.btnEliminarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEliminarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarR.Location = New System.Drawing.Point(873, 223)
        Me.btnEliminarR.Name = "btnEliminarR"
        Me.btnEliminarR.Size = New System.Drawing.Size(74, 51)
        Me.btnEliminarR.TabIndex = 37
        Me.btnEliminarR.UseVisualStyleBackColor = False
        '
        'btnEditarR
        '
        Me.btnEditarR.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarR.BackgroundImage = CType(resources.GetObject("btnEditarR.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditarR.FlatAppearance.BorderSize = 4
        Me.btnEditarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarR.Location = New System.Drawing.Point(682, 223)
        Me.btnEditarR.Name = "btnEditarR"
        Me.btnEditarR.Size = New System.Drawing.Size(74, 51)
        Me.btnEditarR.TabIndex = 36
        Me.btnEditarR.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(272, 286)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nuevo"
        '
        'btnNuevoR
        '
        Me.btnNuevoR.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoR.BackgroundImage = CType(resources.GetObject("btnNuevoR.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevoR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevoR.FlatAppearance.BorderSize = 4
        Me.btnNuevoR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNuevoR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoR.Location = New System.Drawing.Point(272, 223)
        Me.btnNuevoR.Name = "btnNuevoR"
        Me.btnNuevoR.Size = New System.Drawing.Size(74, 51)
        Me.btnNuevoR.TabIndex = 19
        Me.btnNuevoR.UseVisualStyleBackColor = False
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
        Me.btnAtras.Location = New System.Drawing.Point(22, 611)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(56, 60)
        Me.btnAtras.TabIndex = 18
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(459, 277)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 48)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & "Rol"
        '
        'btnAgregarR
        '
        Me.btnAgregarR.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarR.BackgroundImage = CType(resources.GetObject("btnAgregarR.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarR.FlatAppearance.BorderSize = 4
        Me.btnAgregarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarR.Location = New System.Drawing.Point(463, 223)
        Me.btnAgregarR.Name = "btnAgregarR"
        Me.btnAgregarR.Size = New System.Drawing.Size(74, 51)
        Me.btnAgregarR.TabIndex = 14
        Me.btnAgregarR.UseVisualStyleBackColor = False
        '
        'txbDescRol
        '
        Me.txbDescRol.Location = New System.Drawing.Point(770, 59)
        Me.txbDescRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbDescRol.Name = "txbDescRol"
        Me.txbDescRol.Size = New System.Drawing.Size(407, 32)
        Me.txbDescRol.TabIndex = 11
        '
        'txbRol
        '
        Me.txbRol.Location = New System.Drawing.Point(120, 111)
        Me.txbRol.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbRol.Name = "txbRol"
        Me.txbRol.Size = New System.Drawing.Size(407, 32)
        Me.txbRol.TabIndex = 8
        '
        'txbIDR
        '
        Me.txbIDR.Location = New System.Drawing.Point(120, 64)
        Me.txbIDR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txbIDR.Name = "txbIDR"
        Me.txbIDR.ReadOnly = True
        Me.txbIDR.Size = New System.Drawing.Size(407, 32)
        Me.txbIDR.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(659, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'frmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmRol"
        Me.Text = "frmRol"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txbBuscarR As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEliminarR As Button
    Friend WithEvents btnEditarR As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnNuevoR As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregarR As Button
    Friend WithEvents txbDescRol As TextBox
    Friend WithEvents txbRol As TextBox
    Friend WithEvents txbIDR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRol As DataGridView
    Friend WithEvents BiomessDataSet2 As biomessDataSet2
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As biomessDataSet2TableAdapters.RolTableAdapter
    Friend WithEvents IDRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
