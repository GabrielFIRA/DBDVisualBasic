<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EPermisos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgbPermisos = New System.Windows.Forms.DataGridView()
        Me.IDPermisosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicioPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPermisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisosViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PermisosViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.label43 = New System.Windows.Forms.Label()
        Me.txbTipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Atras = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.PermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermisosTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.PermisosTableAdapter()
        Me.PermisosViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.permisosViewTableAdapter()
        Me.EmpleadoViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.empleadoViewTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.dgbPermisos)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 390)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permisos"
        '
        'dgbPermisos
        '
        Me.dgbPermisos.AutoGenerateColumns = False
        Me.dgbPermisos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgbPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPermisosDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.InicioPeriodoDataGridViewTextBoxColumn, Me.FinPeriodoDataGridViewTextBoxColumn, Me.TipoPermisoDataGridViewTextBoxColumn})
        Me.dgbPermisos.DataSource = Me.PermisosViewBindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbPermisos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbPermisos.Location = New System.Drawing.Point(6, 62)
        Me.dgbPermisos.Name = "dgbPermisos"
        Me.dgbPermisos.RowHeadersWidth = 50
        Me.dgbPermisos.Size = New System.Drawing.Size(1314, 321)
        Me.dgbPermisos.TabIndex = 50
        '
        'IDPermisosDataGridViewTextBoxColumn
        '
        Me.IDPermisosDataGridViewTextBoxColumn.DataPropertyName = "ID_Permisos"
        Me.IDPermisosDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDPermisosDataGridViewTextBoxColumn.Name = "IDPermisosDataGridViewTextBoxColumn"
        Me.IDPermisosDataGridViewTextBoxColumn.Width = 200
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 470
        '
        'InicioPeriodoDataGridViewTextBoxColumn
        '
        Me.InicioPeriodoDataGridViewTextBoxColumn.DataPropertyName = "inicioPeriodo"
        Me.InicioPeriodoDataGridViewTextBoxColumn.HeaderText = "Inicio Periodo"
        Me.InicioPeriodoDataGridViewTextBoxColumn.Name = "InicioPeriodoDataGridViewTextBoxColumn"
        Me.InicioPeriodoDataGridViewTextBoxColumn.Width = 200
        '
        'FinPeriodoDataGridViewTextBoxColumn
        '
        Me.FinPeriodoDataGridViewTextBoxColumn.DataPropertyName = "finPeriodo"
        Me.FinPeriodoDataGridViewTextBoxColumn.HeaderText = "Fin periodo"
        Me.FinPeriodoDataGridViewTextBoxColumn.Name = "FinPeriodoDataGridViewTextBoxColumn"
        Me.FinPeriodoDataGridViewTextBoxColumn.Width = 200
        '
        'TipoPermisoDataGridViewTextBoxColumn
        '
        Me.TipoPermisoDataGridViewTextBoxColumn.DataPropertyName = "tipoPermiso"
        Me.TipoPermisoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoPermisoDataGridViewTextBoxColumn.Name = "TipoPermisoDataGridViewTextBoxColumn"
        Me.TipoPermisoDataGridViewTextBoxColumn.Width = 200
        '
        'PermisosViewBindingSource1
        '
        Me.PermisosViewBindingSource1.DataMember = "permisosView"
        Me.PermisosViewBindingSource1.DataSource = Me.BiomessDataSet1
        '
        'BiomessDataSet1
        '
        Me.BiomessDataSet1.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.Gray
        Me.txtBuscar.Location = New System.Drawing.Point(398, 26)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(513, 30)
        Me.txtBuscar.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(323, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Buscar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PermisosViewBindingSource
        '
        Me.PermisosViewBindingSource.DataMember = "permisosView"
        Me.PermisosViewBindingSource.DataSource = Me.BiomessDataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.label43)
        Me.GroupBox1.Controls.Add(Me.txbTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 269)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Permisos"
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(285, 98)
        Me.txbID.Name = "txbID"
        Me.txbID.ReadOnly = True
        Me.txbID.Size = New System.Drawing.Size(100, 30)
        Me.txbID.TabIndex = 65
        '
        'label43
        '
        Me.label43.AutoSize = True
        Me.label43.BackColor = System.Drawing.Color.Transparent
        Me.label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.label43.ForeColor = System.Drawing.SystemColors.Control
        Me.label43.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label43.Location = New System.Drawing.Point(242, 98)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(37, 25)
        Me.label43.TabIndex = 64
        Me.label43.Text = "ID:"
        Me.label43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbTipo
        '
        Me.txbTipo.Location = New System.Drawing.Point(285, 183)
        Me.txbTipo.Name = "txbTipo"
        Me.txbTipo.Size = New System.Drawing.Size(311, 30)
        Me.txbTipo.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(222, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Tipo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dpFechaFinal
        '
        Me.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaFinal.Location = New System.Drawing.Point(969, 155)
        Me.dpFechaFinal.Name = "dpFechaFinal"
        Me.dpFechaFinal.Size = New System.Drawing.Size(133, 30)
        Me.dpFechaFinal.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(853, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Fecha final:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dpFechaInicio
        '
        Me.dpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaInicio.Location = New System.Drawing.Point(969, 86)
        Me.dpFechaInicio.Name = "dpFechaInicio"
        Me.dpFechaInicio.Size = New System.Drawing.Size(133, 30)
        Me.dpFechaInicio.TabIndex = 59
        '
        'cbEmpleado
        '
        Me.cbEmpleado.DataSource = Me.EmpleadoViewBindingSource
        Me.cbEmpleado.DisplayMember = "nombreCompleto"
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(285, 138)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(311, 33)
        Me.cbEmpleado.TabIndex = 57
        Me.cbEmpleado.ValueMember = "ID_Empleado"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BiomessDataSet1
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEliminar.Location = New System.Drawing.Point(1108, 212)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 34)
        Me.btnEliminar.TabIndex = 52
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEditar.Location = New System.Drawing.Point(1001, 212)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(101, 34)
        Me.btnEditar.TabIndex = 51
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAgregar.Location = New System.Drawing.Point(894, 212)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(101, 34)
        Me.btnAgregar.TabIndex = 50
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnNuevo.Location = New System.Drawing.Point(787, 212)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(101, 34)
        Me.btnNuevo.TabIndex = 49
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(173, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Empleado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(844, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Fecha inicio:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Atras.TabIndex = 65
        Me.Atras.UseVisualStyleBackColor = False
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'PermisosBindingSource
        '
        Me.PermisosBindingSource.DataMember = "Permisos"
        Me.PermisosBindingSource.DataSource = Me.BiomessDataSet1
        '
        'PermisosTableAdapter
        '
        Me.PermisosTableAdapter.ClearBeforeFill = True
        '
        'PermisosViewTableAdapter
        '
        Me.PermisosViewTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoViewBindingSource
        '
        Me.EmpleadoViewBindingSource.DataMember = "empleadoView"
        Me.EmpleadoViewBindingSource.DataSource = Me.BiomessDataSet1
        '
        'EmpleadoViewTableAdapter
        '
        Me.EmpleadoViewTableAdapter.ClearBeforeFill = True
        '
        'EPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Atras)
        Me.Name = "EPermisos"
        Me.Text = "EPermisos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgbPermisos As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dpFechaFinal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dpFechaInicio As DateTimePicker
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Atras As Button
    Friend WithEvents BiomessDataSet1 As biomessDataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As biomessDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents PermisosViewBindingSource As BindingSource
    Friend WithEvents IDPermisosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InicioPeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinPeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoPermisoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PermisosBindingSource As BindingSource
    Friend WithEvents PermisosTableAdapter As biomessDataSet1TableAdapters.PermisosTableAdapter
    Friend WithEvents txbTipo As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents label43 As Label
    Friend WithEvents PermisosViewBindingSource1 As BindingSource
    Friend WithEvents PermisosViewTableAdapter As biomessDataSet1TableAdapters.permisosViewTableAdapter
    Friend WithEvents EmpleadoViewBindingSource As BindingSource
    Friend WithEvents EmpleadoViewTableAdapter As biomessDataSet1TableAdapters.empleadoViewTableAdapter
End Class
