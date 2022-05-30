<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EEmpleados))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmpleadoViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpleadoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbPIN = New System.Windows.Forms.TextBox()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbCedula = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbCelular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbCorreo = New System.Windows.Forms.TextBox()
        Me.txbINSS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.DepartamentoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.DepartamentoTableAdapter()
        Me.EmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.CargoTableAdapter()
        Me.EmpleadoViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.empleadoViewTableAdapter()
        Me.dgbEmpleados = New System.Windows.Forms.DataGridView()
        Me.IDEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroCel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreDepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.dgbEmpleados)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 370)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empleados"
        '
        'EmpleadoViewBindingSource
        '
        Me.EmpleadoViewBindingSource.DataMember = "empleadoView"
        Me.EmpleadoViewBindingSource.DataSource = Me.BiomessDataSet1
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
        'EmpleadoBindingSource2
        '
        Me.EmpleadoBindingSource2.DataMember = "Empleado"
        Me.EmpleadoBindingSource2.DataSource = Me.BiomessDataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txbPIN)
        Me.GroupBox1.Controls.Add(Me.dpFecha)
        Me.GroupBox1.Controls.Add(Me.cbCargo)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txbNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txbCedula)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txbCelular)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txbCorreo)
        Me.GroupBox1.Controls.Add(Me.txbINSS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 282)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos empleado"
        '
        'txbID
        '
        Me.txbID.BackColor = System.Drawing.Color.Gray
        Me.txbID.Location = New System.Drawing.Point(274, 41)
        Me.txbID.Name = "txbID"
        Me.txbID.ReadOnly = True
        Me.txbID.Size = New System.Drawing.Size(72, 30)
        Me.txbID.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label9.Location = New System.Drawing.Point(231, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 25)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "ID:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.Location = New System.Drawing.Point(874, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 25)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "PIN:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbPIN
        '
        Me.txbPIN.BackColor = System.Drawing.Color.Gray
        Me.txbPIN.Location = New System.Drawing.Point(930, 177)
        Me.txbPIN.Name = "txbPIN"
        Me.txbPIN.Size = New System.Drawing.Size(157, 30)
        Me.txbPIN.TabIndex = 56
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(274, 130)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(128, 30)
        Me.dpFecha.TabIndex = 54
        '
        'cbCargo
        '
        Me.cbCargo.DataSource = Me.CargoBindingSource
        Me.cbCargo.DisplayMember = "nombreCargo"
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(928, 127)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(210, 33)
        Me.cbCargo.TabIndex = 53
        Me.cbCargo.ValueMember = "ID_Cargo"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.BiomessDataSet1
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEliminar.Location = New System.Drawing.Point(1144, 232)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 34)
        Me.btnEliminar.TabIndex = 52
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEditar.Location = New System.Drawing.Point(1037, 232)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(101, 34)
        Me.btnEditar.TabIndex = 51
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAgregar.Location = New System.Drawing.Point(930, 232)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(101, 34)
        Me.btnAgregar.TabIndex = 50
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnNuevo.Location = New System.Drawing.Point(823, 232)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(101, 34)
        Me.btnNuevo.TabIndex = 49
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txbNombre
        '
        Me.txbNombre.BackColor = System.Drawing.Color.Gray
        Me.txbNombre.Location = New System.Drawing.Point(274, 90)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(295, 30)
        Me.txbNombre.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(97, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre completo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(187, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Cédula:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbCedula
        '
        Me.txbCedula.BackColor = System.Drawing.Color.Gray
        Me.txbCedula.Location = New System.Drawing.Point(274, 175)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(184, 30)
        Me.txbCedula.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label13.Location = New System.Drawing.Point(852, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 25)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Cargo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(203, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "INSS:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbCelular
        '
        Me.txbCelular.BackColor = System.Drawing.Color.Gray
        Me.txbCelular.Location = New System.Drawing.Point(930, 41)
        Me.txbCelular.Name = "txbCelular"
        Me.txbCelular.Size = New System.Drawing.Size(157, 30)
        Me.txbCelular.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(844, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Celular:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbCorreo
        '
        Me.txbCorreo.BackColor = System.Drawing.Color.Gray
        Me.txbCorreo.Location = New System.Drawing.Point(930, 88)
        Me.txbCorreo.Name = "txbCorreo"
        Me.txbCorreo.Size = New System.Drawing.Size(368, 30)
        Me.txbCorreo.TabIndex = 40
        '
        'txbINSS
        '
        Me.txbINSS.BackColor = System.Drawing.Color.Gray
        Me.txbINSS.Location = New System.Drawing.Point(274, 217)
        Me.txbINSS.Name = "txbINSS"
        Me.txbINSS.Size = New System.Drawing.Size(157, 30)
        Me.txbINSS.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(747, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Correo electrónico:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(96, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 25)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Fecha nacimiento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BiomessDataSet1BindingSource
        '
        'BiomessDataSet1BindingSource
        '
        Me.BiomessDataSet1BindingSource.DataSource = Me.BiomessDataSet1
        Me.BiomessDataSet1BindingSource.Position = 0
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button9.Location = New System.Drawing.Point(12, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 41)
        Me.Button9.TabIndex = 51
        Me.Button9.UseVisualStyleBackColor = False
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BiomessDataSet1BindingSource
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoBindingSource1
        '
        Me.EmpleadoBindingSource1.DataMember = "Empleado"
        Me.EmpleadoBindingSource1.DataSource = Me.BiomessDataSet1
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoViewTableAdapter
        '
        Me.EmpleadoViewTableAdapter.ClearBeforeFill = True
        '
        'dgbEmpleados
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray
        Me.dgbEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgbEmpleados.AutoGenerateColumns = False
        Me.dgbEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgbEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgbEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEmpleadoDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.INSSDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.numeroCel, Me.FechaIngresoDataGridViewTextBoxColumn, Me.nombreCargo, Me.nombreDepart, Me.PIN})
        Me.dgbEmpleados.DataSource = Me.EmpleadoViewBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbEmpleados.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgbEmpleados.Location = New System.Drawing.Point(6, 62)
        Me.dgbEmpleados.Name = "dgbEmpleados"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgbEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgbEmpleados.RowHeadersWidth = 50
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dgbEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgbEmpleados.Size = New System.Drawing.Size(1314, 325)
        Me.dgbEmpleados.TabIndex = 50
        '
        'IDEmpleadoDataGridViewTextBoxColumn
        '
        Me.IDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Empleado"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.IDEmpleadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.IDEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDEmpleadoDataGridViewTextBoxColumn.Name = "IDEmpleadoDataGridViewTextBoxColumn"
        Me.IDEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDEmpleadoDataGridViewTextBoxColumn.Width = 40
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 180
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaNacDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.Width = 110
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cédula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.Width = 150
        '
        'INSSDataGridViewTextBoxColumn
        '
        Me.INSSDataGridViewTextBoxColumn.DataPropertyName = "INSS"
        Me.INSSDataGridViewTextBoxColumn.HeaderText = "INSS"
        Me.INSSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.INSSDataGridViewTextBoxColumn.Name = "INSSDataGridViewTextBoxColumn"
        Me.INSSDataGridViewTextBoxColumn.Width = 75
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo electrónico"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 150
        '
        'numeroCel
        '
        Me.numeroCel.DataPropertyName = "numeroCel"
        Me.numeroCel.HeaderText = "Celular"
        Me.numeroCel.Name = "numeroCel"
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "fechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.Width = 115
        '
        'nombreCargo
        '
        Me.nombreCargo.DataPropertyName = "nombreCargo"
        Me.nombreCargo.HeaderText = "Cargo"
        Me.nombreCargo.MinimumWidth = 6
        Me.nombreCargo.Name = "nombreCargo"
        Me.nombreCargo.Width = 130
        '
        'nombreDepart
        '
        Me.nombreDepart.DataPropertyName = "nombreDepart"
        Me.nombreDepart.HeaderText = "Departamento"
        Me.nombreDepart.MinimumWidth = 6
        Me.nombreDepart.Name = "nombreDepart"
        Me.nombreDepart.Width = 140
        '
        'PIN
        '
        Me.PIN.DataPropertyName = "PIN"
        Me.PIN.HeaderText = "PIN"
        Me.PIN.Name = "PIN"
        Me.PIN.Width = 80
        '
        'EEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button9)
        Me.Name = "EEmpleados"
        Me.Text = "EEmpleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbCedula As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbCelular As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbCorreo As TextBox
    Friend WithEvents txbINSS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents BiomessDataSet1BindingSource As BindingSource
    Friend WithEvents BiomessDataSet1 As biomessDataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As biomessDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As biomessDataSet1TableAdapters.DepartamentoTableAdapter
    Friend WithEvents EmpleadoBindingSource2 As BindingSource
    Friend WithEvents EmpleadoBindingSource1 As BindingSource
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As biomessDataSet1TableAdapters.CargoTableAdapter
    Friend WithEvents EmpleadoViewBindingSource As BindingSource
    Friend WithEvents EmpleadoViewTableAdapter As biomessDataSet1TableAdapters.empleadoViewTableAdapter
    Friend WithEvents dpFecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txbPIN As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgbEmpleados As DataGridView
    Friend WithEvents IDEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents numeroCel As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCargo As DataGridViewTextBoxColumn
    Friend WithEvents nombreDepart As DataGridViewTextBoxColumn
    Friend WithEvents PIN As DataGridViewTextBoxColumn
End Class
