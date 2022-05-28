<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EAusencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EAusencias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txbJustificacion = New System.Windows.Forms.TextBox()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet12 = New Biomess_0._1.biomessDataSet1()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.Atras = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgbAusencias = New System.Windows.Forms.DataGridView()
        Me.IDAusenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaAusenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusenciasViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet11 = New Biomess_0._1.biomessDataSet1()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AusenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AusenciasTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.AusenciasTableAdapter()
        Me.AusenciasViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.ausenciasViewTableAdapter()
        Me.EmpleadoViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.empleadoViewTableAdapter()
        Me.BiomessDataSet13 = New Biomess_0._1.biomessDataSet1()
        Me.EmpleadoViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbAusencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AusenciasViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AusenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dpFecha)
        Me.GroupBox1.Controls.Add(Me.txbJustificacion)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 269)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Ausencia"
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(266, 92)
        Me.txbID.Name = "txbID"
        Me.txbID.ReadOnly = True
        Me.txbID.Size = New System.Drawing.Size(100, 30)
        Me.txbID.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(139, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ID ausencia:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(266, 169)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(122, 30)
        Me.dpFecha.TabIndex = 59
        '
        'txbJustificacion
        '
        Me.txbJustificacion.AcceptsTab = True
        Me.txbJustificacion.Location = New System.Drawing.Point(796, 89)
        Me.txbJustificacion.Multiline = True
        Me.txbJustificacion.Name = "txbJustificacion"
        Me.txbJustificacion.Size = New System.Drawing.Size(333, 105)
        Me.txbJustificacion.TabIndex = 58
        '
        'cbEmpleado
        '
        Me.cbEmpleado.DataSource = Me.EmpleadoViewBindingSource1
        Me.cbEmpleado.DisplayMember = "nombreCompleto"
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(266, 130)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(311, 33)
        Me.cbEmpleado.TabIndex = 57
        Me.cbEmpleado.ValueMember = "ID_Empleado"
        '
        'EmpleadoBindingSource1
        '
        Me.EmpleadoBindingSource1.DataMember = "Empleado"
        Me.EmpleadoBindingSource1.DataSource = Me.BiomessDataSet12
        '
        'BiomessDataSet12
        '
        Me.BiomessDataSet12.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label2.Location = New System.Drawing.Point(154, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Empleado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(665, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Justificación:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(187, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 25)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Fecha:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BiomessDataSet1
        '
        'BiomessDataSet1
        '
        Me.BiomessDataSet1.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Atras.TabIndex = 53
        Me.Atras.UseVisualStyleBackColor = False
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.dgbAusencias)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 390)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausencias"
        '
        'dgbAusencias
        '
        Me.dgbAusencias.AutoGenerateColumns = False
        Me.dgbAusencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgbAusencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbAusencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAusenciaDataGridViewTextBoxColumn, Me.nombreCompleto, Me.DiaAusenciaDataGridViewTextBoxColumn, Me.JustificacionDataGridViewTextBoxColumn})
        Me.dgbAusencias.DataSource = Me.AusenciasViewBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbAusencias.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbAusencias.Location = New System.Drawing.Point(6, 62)
        Me.dgbAusencias.Name = "dgbAusencias"
        Me.dgbAusencias.RowHeadersWidth = 50
        Me.dgbAusencias.Size = New System.Drawing.Size(1314, 358)
        Me.dgbAusencias.TabIndex = 50
        '
        'IDAusenciaDataGridViewTextBoxColumn
        '
        Me.IDAusenciaDataGridViewTextBoxColumn.DataPropertyName = "ID_Ausencia"
        Me.IDAusenciaDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDAusenciaDataGridViewTextBoxColumn.Name = "IDAusenciaDataGridViewTextBoxColumn"
        Me.IDAusenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'nombreCompleto
        '
        Me.nombreCompleto.DataPropertyName = "nombreCompleto"
        Me.nombreCompleto.HeaderText = "Nombre Completo"
        Me.nombreCompleto.Name = "nombreCompleto"
        Me.nombreCompleto.Width = 350
        '
        'DiaAusenciaDataGridViewTextBoxColumn
        '
        Me.DiaAusenciaDataGridViewTextBoxColumn.DataPropertyName = "diaAusencia"
        Me.DiaAusenciaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.DiaAusenciaDataGridViewTextBoxColumn.Name = "DiaAusenciaDataGridViewTextBoxColumn"
        Me.DiaAusenciaDataGridViewTextBoxColumn.Width = 200
        '
        'JustificacionDataGridViewTextBoxColumn
        '
        Me.JustificacionDataGridViewTextBoxColumn.DataPropertyName = "justificacion"
        Me.JustificacionDataGridViewTextBoxColumn.HeaderText = "Justificación"
        Me.JustificacionDataGridViewTextBoxColumn.Name = "JustificacionDataGridViewTextBoxColumn"
        Me.JustificacionDataGridViewTextBoxColumn.Width = 620
        '
        'AusenciasViewBindingSource
        '
        Me.AusenciasViewBindingSource.DataMember = "ausenciasView"
        Me.AusenciasViewBindingSource.DataSource = Me.BiomessDataSet11
        '
        'BiomessDataSet11
        '
        Me.BiomessDataSet11.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'AusenciasBindingSource
        '
        Me.AusenciasBindingSource.DataMember = "Ausencias"
        Me.AusenciasBindingSource.DataSource = Me.BiomessDataSet1
        '
        'AusenciasTableAdapter
        '
        Me.AusenciasTableAdapter.ClearBeforeFill = True
        '
        'AusenciasViewTableAdapter
        '
        Me.AusenciasViewTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoViewBindingSource
        '
        Me.EmpleadoViewBindingSource.DataMember = "empleadoView"
        Me.EmpleadoViewBindingSource.DataSource = Me.BiomessDataSet12
        '
        'EmpleadoViewTableAdapter
        '
        Me.EmpleadoViewTableAdapter.ClearBeforeFill = True
        '
        'BiomessDataSet13
        '
        Me.BiomessDataSet13.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoViewBindingSource1
        '
        Me.EmpleadoViewBindingSource1.DataMember = "empleadoView"
        Me.EmpleadoViewBindingSource1.DataSource = Me.BiomessDataSet13
        '
        'EAusencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Atras)
        Me.Name = "EAusencias"
        Me.Text = "EAusencias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbAusencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AusenciasViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AusenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Atras As Button
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents BiomessDataSet1 As biomessDataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As biomessDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents dpFecha As DateTimePicker
    Friend WithEvents txbJustificacion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgbAusencias As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AusenciasBindingSource As BindingSource
    Friend WithEvents AusenciasTableAdapter As biomessDataSet1TableAdapters.AusenciasTableAdapter
    Friend WithEvents BiomessDataSet11 As biomessDataSet1
    Friend WithEvents AusenciasViewBindingSource As BindingSource
    Friend WithEvents AusenciasViewTableAdapter As biomessDataSet1TableAdapters.ausenciasViewTableAdapter
    Friend WithEvents IDAusenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents DiaAusenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JustificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txbID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BiomessDataSet12 As biomessDataSet1
    Friend WithEvents EmpleadoBindingSource1 As BindingSource
    Friend WithEvents EmpleadoViewBindingSource As BindingSource
    Friend WithEvents EmpleadoViewTableAdapter As biomessDataSet1TableAdapters.empleadoViewTableAdapter
    Friend WithEvents BiomessDataSet13 As biomessDataSet1
    Friend WithEvents EmpleadoViewBindingSource1 As BindingSource
End Class
