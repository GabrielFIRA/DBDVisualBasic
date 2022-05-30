<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EAtrasos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EAtrasos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgbAtrasos = New System.Windows.Forms.DataGridView()
        Me.IDAtrasosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaAtrasoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoAtrasoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JustificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtrasosViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet1 = New Biomess_0._1.biomessDataSet1()
        Me.txbBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tpHora = New System.Windows.Forms.DateTimePicker()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txbJustificacion = New System.Windows.Forms.TextBox()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Atras = New System.Windows.Forms.Button()
        Me.AtrasosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtrasosTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.AtrasosTableAdapter()
        Me.AtrasosViewTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.atrasosViewTableAdapter()
        Me.EmpleadoTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.HorariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorariosTableAdapter = New Biomess_0._1.biomessDataSet1TableAdapters.HorariosTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbAtrasos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtrasosViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtrasosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.dgbAtrasos)
        Me.GroupBox2.Controls.Add(Me.txbBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1326, 390)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Atrasos"
        '
        'dgbAtrasos
        '
        Me.dgbAtrasos.AutoGenerateColumns = False
        Me.dgbAtrasos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgbAtrasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbAtrasos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAtrasosDataGridViewTextBoxColumn, Me.nombreCompleto, Me.DiaAtrasoDataGridViewTextBoxColumn, Me.TiempoAtrasoDataGridViewTextBoxColumn, Me.JustificacionDataGridViewTextBoxColumn})
        Me.dgbAtrasos.DataSource = Me.AtrasosViewBindingSource
        Me.dgbAtrasos.Location = New System.Drawing.Point(6, 62)
        Me.dgbAtrasos.Name = "dgbAtrasos"
        Me.dgbAtrasos.RowHeadersWidth = 50
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.dgbAtrasos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgbAtrasos.Size = New System.Drawing.Size(1314, 321)
        Me.dgbAtrasos.TabIndex = 50
        '
        'IDAtrasosDataGridViewTextBoxColumn
        '
        Me.IDAtrasosDataGridViewTextBoxColumn.DataPropertyName = "ID_Atrasos"
        Me.IDAtrasosDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDAtrasosDataGridViewTextBoxColumn.Name = "IDAtrasosDataGridViewTextBoxColumn"
        Me.IDAtrasosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'nombreCompleto
        '
        Me.nombreCompleto.DataPropertyName = "nombreCompleto"
        Me.nombreCompleto.HeaderText = "Nombre Completo"
        Me.nombreCompleto.Name = "nombreCompleto"
        Me.nombreCompleto.Width = 350
        '
        'DiaAtrasoDataGridViewTextBoxColumn
        '
        Me.DiaAtrasoDataGridViewTextBoxColumn.DataPropertyName = "diaAtraso"
        Me.DiaAtrasoDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.DiaAtrasoDataGridViewTextBoxColumn.Name = "DiaAtrasoDataGridViewTextBoxColumn"
        Me.DiaAtrasoDataGridViewTextBoxColumn.Width = 200
        '
        'TiempoAtrasoDataGridViewTextBoxColumn
        '
        Me.TiempoAtrasoDataGridViewTextBoxColumn.DataPropertyName = "tiempoAtraso"
        Me.TiempoAtrasoDataGridViewTextBoxColumn.HeaderText = "Tiempo atrasado"
        Me.TiempoAtrasoDataGridViewTextBoxColumn.Name = "TiempoAtrasoDataGridViewTextBoxColumn"
        Me.TiempoAtrasoDataGridViewTextBoxColumn.Width = 200
        '
        'JustificacionDataGridViewTextBoxColumn
        '
        Me.JustificacionDataGridViewTextBoxColumn.DataPropertyName = "justificacion"
        Me.JustificacionDataGridViewTextBoxColumn.HeaderText = "Justificación"
        Me.JustificacionDataGridViewTextBoxColumn.Name = "JustificacionDataGridViewTextBoxColumn"
        Me.JustificacionDataGridViewTextBoxColumn.Width = 420
        '
        'AtrasosViewBindingSource
        '
        Me.AtrasosViewBindingSource.DataMember = "atrasosView"
        Me.AtrasosViewBindingSource.DataSource = Me.BiomessDataSet1
        '
        'BiomessDataSet1
        '
        Me.BiomessDataSet1.DataSetName = "biomessDataSet1"
        Me.BiomessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txbBuscar
        '
        Me.txbBuscar.BackColor = System.Drawing.Color.Gray
        Me.txbBuscar.Location = New System.Drawing.Point(398, 26)
        Me.txbBuscar.Name = "txbBuscar"
        Me.txbBuscar.Size = New System.Drawing.Size(513, 30)
        Me.txbBuscar.TabIndex = 49
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
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tpHora)
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
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Atrasos"
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(571, 18)
        Me.txbID.Name = "txbID"
        Me.txbID.ReadOnly = True
        Me.txbID.Size = New System.Drawing.Size(100, 30)
        Me.txbID.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(528, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(128, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Hora:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tpHora
        '
        Me.tpHora.CustomFormat = ""
        Me.tpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tpHora.Location = New System.Drawing.Point(194, 172)
        Me.tpHora.Name = "tpHora"
        Me.tpHora.ShowUpDown = True
        Me.tpHora.Size = New System.Drawing.Size(156, 30)
        Me.tpHora.TabIndex = 60
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(194, 125)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(156, 30)
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
        Me.cbEmpleado.DataSource = Me.EmpleadoBindingSource
        Me.cbEmpleado.DisplayMember = "nombreCompleto"
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(194, 81)
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
        Me.Label2.Location = New System.Drawing.Point(91, 84)
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
        Me.Label7.Location = New System.Drawing.Point(115, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 25)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Fecha:"
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
        Me.Atras.TabIndex = 56
        Me.Atras.UseVisualStyleBackColor = False
        '
        'AtrasosBindingSource
        '
        Me.AtrasosBindingSource.DataMember = "Atrasos"
        Me.AtrasosBindingSource.DataSource = Me.BiomessDataSet1
        '
        'AtrasosTableAdapter
        '
        Me.AtrasosTableAdapter.ClearBeforeFill = True
        '
        'AtrasosViewTableAdapter
        '
        Me.AtrasosViewTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'HorariosBindingSource
        '
        Me.HorariosBindingSource.DataMember = "Horarios"
        Me.HorariosBindingSource.DataSource = Me.BiomessDataSet1
        '
        'HorariosTableAdapter
        '
        Me.HorariosTableAdapter.ClearBeforeFill = True
        '
        'EAtrasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Atras)
        Me.Name = "EAtrasos"
        Me.Text = "EAtrasos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbAtrasos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtrasosViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtrasosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgbAtrasos As DataGridView
    Friend WithEvents txbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dpFecha As DateTimePicker
    Friend WithEvents txbJustificacion As TextBox
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Atras As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tpHora As DateTimePicker
    Friend WithEvents BiomessDataSet1 As biomessDataSet1
    Friend WithEvents AtrasosBindingSource As BindingSource
    Friend WithEvents AtrasosTableAdapter As biomessDataSet1TableAdapters.AtrasosTableAdapter
    Friend WithEvents AtrasosViewBindingSource As BindingSource
    Friend WithEvents AtrasosViewTableAdapter As biomessDataSet1TableAdapters.atrasosViewTableAdapter
    Friend WithEvents IDAtrasosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents DiaAtrasoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiempoAtrasoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JustificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As biomessDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents HorariosBindingSource As BindingSource
    Friend WithEvents HorariosTableAdapter As biomessDataSet1TableAdapters.HorariosTableAdapter
    Friend WithEvents txbID As TextBox
    Friend WithEvents Label4 As Label
End Class
