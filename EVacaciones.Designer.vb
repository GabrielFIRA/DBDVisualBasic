<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vacaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgbVacaciones = New System.Windows.Forms.DataGridView()
        Me.IDVacacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicioPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoVacacionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VacacionesViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VacacionesViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Atras = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.VacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VacacionesTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.VacacionesTableAdapter()
        Me.EmpleadoViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.empleadoViewTableAdapter()
        Me.VacacionesViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.vacacionesViewTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.dgbVacaciones)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 390)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vacaciones"
        '
        'dgbVacaciones
        '
        Me.dgbVacaciones.AutoGenerateColumns = False
        Me.dgbVacaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgbVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbVacaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVacacionesDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.InicioPeriodoDataGridViewTextBoxColumn, Me.FinPeriodoDataGridViewTextBoxColumn, Me.TipoVacacionDataGridViewCheckBoxColumn})
        Me.dgbVacaciones.DataSource = Me.VacacionesViewBindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbVacaciones.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbVacaciones.Location = New System.Drawing.Point(6, 62)
        Me.dgbVacaciones.Name = "dgbVacaciones"
        Me.dgbVacaciones.RowHeadersWidth = 50
        Me.dgbVacaciones.Size = New System.Drawing.Size(1314, 321)
        Me.dgbVacaciones.TabIndex = 50
        '
        'IDVacacionesDataGridViewTextBoxColumn
        '
        Me.IDVacacionesDataGridViewTextBoxColumn.DataPropertyName = "ID_Vacaciones"
        Me.IDVacacionesDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDVacacionesDataGridViewTextBoxColumn.Name = "IDVacacionesDataGridViewTextBoxColumn"
        Me.IDVacacionesDataGridViewTextBoxColumn.Width = 200
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
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
        'TipoVacacionDataGridViewCheckBoxColumn
        '
        Me.TipoVacacionDataGridViewCheckBoxColumn.DataPropertyName = "tipoVacacion"
        Me.TipoVacacionDataGridViewCheckBoxColumn.HeaderText = "Tipo"
        Me.TipoVacacionDataGridViewCheckBoxColumn.Name = "TipoVacacionDataGridViewCheckBoxColumn"
        Me.TipoVacacionDataGridViewCheckBoxColumn.Width = 200
        '
        'VacacionesViewBindingSource1
        '
        Me.VacacionesViewBindingSource1.DataMember = "vacacionesView"
        Me.VacacionesViewBindingSource1.DataSource = Me.BiomessDataSet1
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
        'VacacionesViewBindingSource
        '
        Me.VacacionesViewBindingSource.DataMember = "vacacionesView"
        Me.VacacionesViewBindingSource.DataSource = Me.BiomessDataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 269)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Vacaciones"
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(274, 66)
        Me.txbID.Name = "txbID"
        Me.txbID.ReadOnly = True
        Me.txbID.Size = New System.Drawing.Size(100, 30)
        Me.txbID.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(231, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 25)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Feriado", "Vacaciones"})
        Me.cbTipo.Location = New System.Drawing.Point(274, 153)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(163, 33)
        Me.cbTipo.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(211, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Tipo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dpFechaFinal
        '
        Me.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaFinal.Location = New System.Drawing.Point(980, 135)
        Me.dpFechaFinal.Name = "dpFechaFinal"
        Me.dpFechaFinal.Size = New System.Drawing.Size(133, 30)
        Me.dpFechaFinal.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(861, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Fecha final:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dpFechaInicio
        '
        Me.dpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaInicio.Location = New System.Drawing.Point(980, 66)
        Me.dpFechaInicio.Name = "dpFechaInicio"
        Me.dpFechaInicio.Size = New System.Drawing.Size(133, 30)
        Me.dpFechaInicio.TabIndex = 67
        '
        'cbEmpleado
        '
        Me.cbEmpleado.DataSource = Me.EmpleadoViewBindingSource
        Me.cbEmpleado.DisplayMember = "nombreCompleto"
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(274, 109)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(311, 33)
        Me.cbEmpleado.TabIndex = 66
        Me.cbEmpleado.ValueMember = "ID_Empleado"
        '
        'EmpleadoViewBindingSource
        '
        Me.EmpleadoViewBindingSource.DataMember = "empleadoView"
        Me.EmpleadoViewBindingSource.DataSource = Me.BiomessDataSet1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(162, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 64
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
        Me.Label7.Location = New System.Drawing.Point(852, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Fecha inicio:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'VacacionesBindingSource
        '
        Me.VacacionesBindingSource.DataMember = "Vacaciones"
        Me.VacacionesBindingSource.DataSource = Me.BiomessDataSet1
        '
        'VacacionesTableAdapter
        '
        Me.VacacionesTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoViewTableAdapter
        '
        Me.EmpleadoViewTableAdapter.ClearBeforeFill = True
        '
        'VacacionesViewTableAdapter
        '
        Me.VacacionesViewTableAdapter.ClearBeforeFill = True
        '
        'Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Atras)
        Me.Name = "Vacaciones"
        Me.Text = "EVacaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadoViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgbVacaciones As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Atras As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dpFechaFinal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dpFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BiomessDataSet1 As biomessDataSet1
    Friend WithEvents VacacionesViewBindingSource As BindingSource
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As biomessDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents VacacionesBindingSource As BindingSource
    Friend WithEvents VacacionesTableAdapter As biomessDataSet1TableAdapters.VacacionesTableAdapter
    Friend WithEvents IDVacacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InicioPeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinPeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoVacacionDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmpleadoViewBindingSource As BindingSource
    Friend WithEvents EmpleadoViewTableAdapter As biomessDataSet1TableAdapters.empleadoViewTableAdapter
    Friend WithEvents txbID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents VacacionesViewBindingSource1 As BindingSource
    Friend WithEvents VacacionesViewTableAdapter As biomessDataSet1TableAdapters.vacacionesViewTableAdapter
End Class
