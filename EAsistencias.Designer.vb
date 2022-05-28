<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EAsistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EAsistencias))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgbAsistencias = New System.Windows.Forms.DataGridView()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAsistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EoSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AsistenciasViewBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet11 = New Biomess_0._1.biomessDataSet1()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AsistenciasViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.AsistenciasViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmpleadoViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Atras = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsistenciaTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.AsistenciaTableAdapter()
        Me.AusenciasViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AusenciasViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.ausenciasViewTableAdapter()
        Me.AsistenciasViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.asistenciasViewTableAdapter()
        Me.EmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.empleadoViewTableAdapter()
        Me.btnEdicion = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtSalida = New System.Windows.Forms.Label()
        Me.tpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtTipo = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.txtEntrada = New System.Windows.Forms.Label()
        Me.tpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsistenciasViewBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsistenciasViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsistenciasViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AusenciasViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.dgbAsistencias)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 390)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asistencias"
        '
        'dgbAsistencias
        '
        Me.dgbAsistencias.AutoGenerateColumns = False
        Me.dgbAsistencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgbAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreCompletoDataGridViewTextBoxColumn, Me.IDAsistenciaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.SemanaDataGridViewTextBoxColumn, Me.HoraEntradaDataGridViewTextBoxColumn, Me.HoraSalidaDataGridViewTextBoxColumn, Me.EoSDataGridViewCheckBoxColumn})
        Me.dgbAsistencias.DataSource = Me.AsistenciasViewBindingSource2
        Me.dgbAsistencias.Location = New System.Drawing.Point(6, 62)
        Me.dgbAsistencias.Name = "dgbAsistencias"
        Me.dgbAsistencias.RowHeadersWidth = 50
        Me.dgbAsistencias.Size = New System.Drawing.Size(1314, 321)
        Me.dgbAsistencias.TabIndex = 50
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 370
        '
        'IDAsistenciaDataGridViewTextBoxColumn
        '
        Me.IDAsistenciaDataGridViewTextBoxColumn.DataPropertyName = "ID_Asistencia"
        Me.IDAsistenciaDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDAsistenciaDataGridViewTextBoxColumn.Name = "IDAsistenciaDataGridViewTextBoxColumn"
        Me.IDAsistenciaDataGridViewTextBoxColumn.Width = 150
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 150
        '
        'SemanaDataGridViewTextBoxColumn
        '
        Me.SemanaDataGridViewTextBoxColumn.DataPropertyName = "semana"
        Me.SemanaDataGridViewTextBoxColumn.HeaderText = "Semana"
        Me.SemanaDataGridViewTextBoxColumn.Name = "SemanaDataGridViewTextBoxColumn"
        Me.SemanaDataGridViewTextBoxColumn.Width = 150
        '
        'HoraEntradaDataGridViewTextBoxColumn
        '
        Me.HoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.HeaderText = "Hora entrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.Name = "HoraEntradaDataGridViewTextBoxColumn"
        Me.HoraEntradaDataGridViewTextBoxColumn.Width = 225
        '
        'HoraSalidaDataGridViewTextBoxColumn
        '
        Me.HoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.HeaderText = "Hora salida"
        Me.HoraSalidaDataGridViewTextBoxColumn.Name = "HoraSalidaDataGridViewTextBoxColumn"
        Me.HoraSalidaDataGridViewTextBoxColumn.Width = 225
        '
        'EoSDataGridViewCheckBoxColumn
        '
        Me.EoSDataGridViewCheckBoxColumn.DataPropertyName = "EoS"
        Me.EoSDataGridViewCheckBoxColumn.HeaderText = "Tipo"
        Me.EoSDataGridViewCheckBoxColumn.Name = "EoSDataGridViewCheckBoxColumn"
        Me.EoSDataGridViewCheckBoxColumn.Visible = False
        Me.EoSDataGridViewCheckBoxColumn.Width = 150
        '
        'AsistenciasViewBindingSource2
        '
        Me.AsistenciasViewBindingSource2.DataMember = "asistenciasView"
        Me.AsistenciasViewBindingSource2.DataSource = Me.BiomessDataSet11
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
        'AsistenciasViewBindingSource1
        '
        Me.AsistenciasViewBindingSource1.DataMember = "asistenciasView"
        Me.AsistenciasViewBindingSource1.DataSource = Me.BiomessDataSet1
        '
        'BiomessDataSet1
        '
        Me.BiomessDataSet1.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsistenciasViewBindingSource
        '
        Me.AsistenciasViewBindingSource.DataMember = "asistenciasView"
        Me.AsistenciasViewBindingSource.DataSource = Me.BiomessDataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.btnNormal)
        Me.GroupBox1.Controls.Add(Me.btnEdicion)
        Me.GroupBox1.Controls.Add(Me.tpHoraEntrada)
        Me.GroupBox1.Controls.Add(Me.txtEntrada)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dpFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.tpHoraSalida)
        Me.GroupBox1.Controls.Add(Me.txtSalida)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 269)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Asistencias"
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(339, 60)
        Me.txbID.Name = "txbID"
        Me.txbID.Size = New System.Drawing.Size(100, 30)
        Me.txbID.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(296, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 25)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "ID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EmpleadoViewBindingSource
        '
        Me.EmpleadoViewBindingSource.DataMember = "empleadoView"
        Me.EmpleadoViewBindingSource.DataSource = Me.BiomessDataSet11
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
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BiomessDataSet1
        '
        'Atras
        '
        Me.Atras.BackColor = System.Drawing.Color.Transparent
        Me.Atras.BackgroundImage = CType(resources.GetObject("Atras.BackgroundImage"), System.Drawing.Image)
        Me.Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Atras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Atras.Location = New System.Drawing.Point(12, 8)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(108, 41)
        Me.Atras.TabIndex = 68
        Me.Atras.UseVisualStyleBackColor = False
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'AsistenciaBindingSource
        '
        Me.AsistenciaBindingSource.DataMember = "Asistencia"
        Me.AsistenciaBindingSource.DataSource = Me.BiomessDataSet1
        '
        'AsistenciaTableAdapter
        '
        Me.AsistenciaTableAdapter.ClearBeforeFill = True
        '
        'AusenciasViewBindingSource
        '
        Me.AusenciasViewBindingSource.DataMember = "ausenciasView"
        Me.AusenciasViewBindingSource.DataSource = Me.BiomessDataSet11
        '
        'AusenciasViewTableAdapter
        '
        Me.AusenciasViewTableAdapter.ClearBeforeFill = True
        '
        'AsistenciasViewTableAdapter
        '
        Me.AsistenciasViewTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoBindingSource1
        '
        Me.EmpleadoBindingSource1.DataMember = "Empleado"
        Me.EmpleadoBindingSource1.DataSource = Me.BiomessDataSet11
        '
        'EmpleadoViewTableAdapter
        '
        Me.EmpleadoViewTableAdapter.ClearBeforeFill = True
        '
        'btnEdicion
        '
        Me.btnEdicion.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEdicion.Location = New System.Drawing.Point(31, 42)
        Me.btnEdicion.Name = "btnEdicion"
        Me.btnEdicion.Size = New System.Drawing.Size(142, 34)
        Me.btnEdicion.TabIndex = 70
        Me.btnEdicion.Text = "Modo edición"
        Me.btnEdicion.UseVisualStyleBackColor = False
        '
        'btnNormal
        '
        Me.btnNormal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnNormal.Location = New System.Drawing.Point(31, 82)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(142, 34)
        Me.btnNormal.TabIndex = 71
        Me.btnNormal.Text = "Modo normal"
        Me.btnNormal.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(825, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(975, 57)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(127, 30)
        Me.dpFecha.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(227, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Empleado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'cbEmpleado
        '
        Me.cbEmpleado.DataSource = Me.EmpleadoViewBindingSource
        Me.cbEmpleado.DisplayMember = "nombreCompleto"
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(339, 102)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(311, 33)
        Me.cbEmpleado.TabIndex = 57
        Me.cbEmpleado.ValueMember = "ID_Empleado"
        '
        'txtSalida
        '
        Me.txtSalida.AutoSize = True
        Me.txtSalida.BackColor = System.Drawing.Color.Transparent
        Me.txtSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtSalida.ForeColor = System.Drawing.SystemColors.Control
        Me.txtSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtSalida.Location = New System.Drawing.Point(838, 151)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(120, 25)
        Me.txtSalida.TabIndex = 60
        Me.txtSalida.Text = "Hora Salida:"
        Me.txtSalida.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtSalida.Visible = False
        '
        'tpHoraSalida
        '
        Me.tpHoraSalida.CustomFormat = "HH:mm:ss"
        Me.tpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tpHoraSalida.Location = New System.Drawing.Point(975, 148)
        Me.tpHoraSalida.Name = "tpHoraSalida"
        Me.tpHoraSalida.ShowUpDown = True
        Me.tpHoraSalida.Size = New System.Drawing.Size(133, 30)
        Me.tpHoraSalida.TabIndex = 61
        Me.tpHoraSalida.Value = New Date(2022, 5, 10, 21, 5, 0, 0)
        Me.tpHoraSalida.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.AutoSize = True
        Me.txtTipo.BackColor = System.Drawing.Color.Transparent
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtTipo.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTipo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtTipo.Location = New System.Drawing.Point(276, 151)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(57, 25)
        Me.txtTipo.TabIndex = 62
        Me.txtTipo.Text = "Tipo:"
        Me.txtTipo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.cbTipo.Location = New System.Drawing.Point(339, 148)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(183, 33)
        Me.cbTipo.TabIndex = 63
        '
        'txtEntrada
        '
        Me.txtEntrada.AutoSize = True
        Me.txtEntrada.BackColor = System.Drawing.Color.Transparent
        Me.txtEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtEntrada.ForeColor = System.Drawing.SystemColors.Control
        Me.txtEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtEntrada.Location = New System.Drawing.Point(838, 110)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(60, 25)
        Me.txtEntrada.TabIndex = 68
        Me.txtEntrada.Text = "Hora:"
        Me.txtEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tpHoraEntrada
        '
        Me.tpHoraEntrada.CustomFormat = "HH:mm:ss"
        Me.tpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tpHoraEntrada.Location = New System.Drawing.Point(975, 102)
        Me.tpHoraEntrada.Name = "tpHoraEntrada"
        Me.tpHoraEntrada.ShowUpDown = True
        Me.tpHoraEntrada.Size = New System.Drawing.Size(133, 30)
        Me.tpHoraEntrada.TabIndex = 69
        Me.tpHoraEntrada.Value = New Date(2022, 5, 10, 21, 5, 0, 0)
        '
        'EAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Atras)
        Me.Name = "EAsistencias"
        Me.Text = "AAsistencias"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsistenciasViewBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsistenciasViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsistenciasViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AusenciasViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgbAsistencias As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Atras As Button
    Friend WithEvents BiomessDataSet1 As biomessDataSet1
    Friend WithEvents AsistenciasViewBindingSource As BindingSource
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As biomessDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents AsistenciaBindingSource As BindingSource
    Friend WithEvents AsistenciaTableAdapter As biomessDataSet1TableAdapters.AsistenciaTableAdapter
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txbID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AsistenciasViewBindingSource1 As BindingSource
    Friend WithEvents BiomessDataSet11 As biomessDataSet1
    Friend WithEvents AusenciasViewBindingSource As BindingSource
    Friend WithEvents AusenciasViewTableAdapter As biomessDataSet1TableAdapters.ausenciasViewTableAdapter
    Friend WithEvents IDAsistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemanaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EoSDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AsistenciasViewBindingSource2 As BindingSource
    Friend WithEvents AsistenciasViewTableAdapter As biomessDataSet1TableAdapters.asistenciasViewTableAdapter
    Friend WithEvents EmpleadoBindingSource1 As BindingSource
    Friend WithEvents EmpleadoViewBindingSource As BindingSource
    Friend WithEvents EmpleadoViewTableAdapter As biomessDataSet1TableAdapters.empleadoViewTableAdapter
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnEdicion As Button
    Friend WithEvents tpHoraEntrada As DateTimePicker
    Friend WithEvents txtEntrada As Label
    Friend WithEvents dpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents txtTipo As Label
    Friend WithEvents tpHoraSalida As DateTimePicker
    Friend WithEvents txtSalida As Label
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label2 As Label
End Class
