<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarUsuario))
        Me.UserRolOrgnViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserrolOrgViewBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet21 = New Biomess_0._1.biomessDataSet2()
        Me.UserRolViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.RolTableAdapter()
        Me.UserRolViewTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.userRolViewTableAdapter()
        Me.UserrolOrgViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_rol_OrgViewTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.user_rol_OrgViewTableAdapter()
        Me.UserrolOrgViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_Rol_OrgnViewTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.user_Rol_OrgnViewTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.txbUserName = New System.Windows.Forms.TextBox()
        Me.txbNombres = New System.Windows.Forms.TextBox()
        Me.txbApellidos = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbCEmail = New System.Windows.Forms.TextBox()
        Me.txbCContraseña = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbContraseña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbBuscar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbxRol = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dvUsuario = New System.Windows.Forms.DataGridView()
        Me.IDUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.UserRolOrgnViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserrolOrgViewBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRolViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserrolOrgViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserrolOrgViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserRolOrgnViewBindingSource
        '
        Me.UserRolOrgnViewBindingSource.DataMember = "user_Rol_OrgnView"
        Me.UserRolOrgnViewBindingSource.DataSource = Me.BiomessDataSet2
        '
        'BiomessDataSet2
        '
        Me.BiomessDataSet2.DataSetName = "biomessDataSet2"
        Me.BiomessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "Rol"
        Me.RolBindingSource.DataSource = Me.BiomessDataSet2
        '
        'UserrolOrgViewBindingSource2
        '
        Me.UserrolOrgViewBindingSource2.DataMember = "user_rol_OrgView"
        Me.UserrolOrgViewBindingSource2.DataSource = Me.BiomessDataSet21
        '
        'BiomessDataSet21
        '
        Me.BiomessDataSet21.DataSetName = "biomessDataSet2"
        Me.BiomessDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserRolViewBindingSource
        '
        Me.UserRolViewBindingSource.DataMember = "userRolView"
        Me.UserRolViewBindingSource.DataSource = Me.BiomessDataSet2
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'UserRolViewTableAdapter
        '
        Me.UserRolViewTableAdapter.ClearBeforeFill = True
        '
        'UserrolOrgViewBindingSource
        '
        Me.UserrolOrgViewBindingSource.DataMember = "user_rol_OrgView"
        Me.UserrolOrgViewBindingSource.DataSource = Me.BiomessDataSet21
        '
        'User_rol_OrgViewTableAdapter
        '
        Me.User_rol_OrgViewTableAdapter.ClearBeforeFill = True
        '
        'UserrolOrgViewBindingSource1
        '
        Me.UserrolOrgViewBindingSource1.DataMember = "user_rol_OrgView"
        Me.UserrolOrgViewBindingSource1.DataSource = Me.BiomessDataSet21
        '
        'User_Rol_OrgnViewTableAdapter
        '
        Me.User_Rol_OrgnViewTableAdapter.ClearBeforeFill = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 216)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(659, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(659, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contraseña"
        '
        'txbID
        '
        Me.txbID.Location = New System.Drawing.Point(120, 64)
        Me.txbID.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbID.Name = "txbID"
        Me.txbID.ReadOnly = True
        Me.txbID.Size = New System.Drawing.Size(407, 32)
        Me.txbID.TabIndex = 7
        '
        'txbUserName
        '
        Me.txbUserName.Location = New System.Drawing.Point(226, 111)
        Me.txbUserName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbUserName.Name = "txbUserName"
        Me.txbUserName.Size = New System.Drawing.Size(407, 32)
        Me.txbUserName.TabIndex = 8
        '
        'txbNombres
        '
        Me.txbNombres.Location = New System.Drawing.Point(140, 162)
        Me.txbNombres.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbNombres.Name = "txbNombres"
        Me.txbNombres.Size = New System.Drawing.Size(407, 32)
        Me.txbNombres.TabIndex = 9
        '
        'txbApellidos
        '
        Me.txbApellidos.Location = New System.Drawing.Point(140, 211)
        Me.txbApellidos.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbApellidos.Name = "txbApellidos"
        Me.txbApellidos.Size = New System.Drawing.Size(407, 32)
        Me.txbApellidos.TabIndex = 10
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(719, 57)
        Me.txbEmail.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(407, 32)
        Me.txbEmail.TabIndex = 11
        '
        'txbCEmail
        '
        Me.txbCEmail.Location = New System.Drawing.Point(766, 111)
        Me.txbCEmail.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbCEmail.Name = "txbCEmail"
        Me.txbCEmail.Size = New System.Drawing.Size(407, 32)
        Me.txbCEmail.TabIndex = 12
        '
        'txbCContraseña
        '
        Me.txbCContraseña.Location = New System.Drawing.Point(766, 209)
        Me.txbCContraseña.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbCContraseña.Name = "txbCContraseña"
        Me.txbCContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbCContraseña.Size = New System.Drawing.Size(407, 32)
        Me.txbCContraseña.TabIndex = 13
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderSize = 4
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(120, 267)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 51)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 322)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 48)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(659, 209)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 62)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Confirmar Contraseña"
        '
        'txbContraseña
        '
        Me.txbContraseña.Location = New System.Drawing.Point(766, 162)
        Me.txbContraseña.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txbContraseña.Name = "txbContraseña"
        Me.txbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbContraseña.Size = New System.Drawing.Size(407, 32)
        Me.txbContraseña.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(659, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 51)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Confirmar Email"
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
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevo.FlatAppearance.BorderSize = 4
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(32, 267)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(73, 51)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(33, 322)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nuevo"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.BorderSize = 4
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(207, 267)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(73, 51)
        Me.btnEditar.TabIndex = 36
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 4
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(293, 267)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 51)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(203, 324)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 48)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Editar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(289, 324)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 48)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Eliminar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario"
        '
        'txbBuscar
        '
        Me.txbBuscar.Location = New System.Drawing.Point(494, 338)
        Me.txbBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txbBuscar.Name = "txbBuscar"
        Me.txbBuscar.Size = New System.Drawing.Size(649, 32)
        Me.txbBuscar.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(404, 341)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 26)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Buscar"
        '
        'cbxRol
        '
        Me.cbxRol.DataSource = Me.RolBindingSource
        Me.cbxRol.DisplayMember = "nombreRol"
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Location = New System.Drawing.Point(766, 267)
        Me.cbxRol.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(407, 34)
        Me.cbxRol.TabIndex = 43
        Me.cbxRol.ValueMember = "ID_Rol"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(715, 270)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 24)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Rol"
        '
        'dvUsuario
        '
        Me.dvUsuario.AutoGenerateColumns = False
        Me.dvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUsuarioDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.IDRolDataGridViewTextBoxColumn, Me.NombreRolDataGridViewTextBoxColumn, Me.NombreOrgDataGridViewTextBoxColumn})
        Me.dvUsuario.DataSource = Me.UserRolOrgnViewBindingSource
        Me.dvUsuario.Location = New System.Drawing.Point(385, 399)
        Me.dvUsuario.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dvUsuario.Name = "dvUsuario"
        Me.dvUsuario.RowHeadersWidth = 51
        Me.dvUsuario.RowTemplate.Height = 24
        Me.dvUsuario.Size = New System.Drawing.Size(777, 263)
        Me.dvUsuario.TabIndex = 45
        '
        'IDUsuarioDataGridViewTextBoxColumn
        '
        Me.IDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario"
        Me.IDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID_Usuario"
        Me.IDUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDUsuarioDataGridViewTextBoxColumn.Name = "IDUsuarioDataGridViewTextBoxColumn"
        Me.IDUsuarioDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Visible = False
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'IDRolDataGridViewTextBoxColumn
        '
        Me.IDRolDataGridViewTextBoxColumn.DataPropertyName = "ID_Rol"
        Me.IDRolDataGridViewTextBoxColumn.HeaderText = "ID_Rol"
        Me.IDRolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDRolDataGridViewTextBoxColumn.Name = "IDRolDataGridViewTextBoxColumn"
        Me.IDRolDataGridViewTextBoxColumn.Visible = False
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
        'NombreOrgDataGridViewTextBoxColumn
        '
        Me.NombreOrgDataGridViewTextBoxColumn.DataPropertyName = "nombreOrg"
        Me.NombreOrgDataGridViewTextBoxColumn.HeaderText = "nombreOrg"
        Me.NombreOrgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreOrgDataGridViewTextBoxColumn.Name = "NombreOrgDataGridViewTextBoxColumn"
        Me.NombreOrgDataGridViewTextBoxColumn.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.dvUsuario)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbxRol)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txbBuscar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnAtras)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txbContraseña)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txbCContraseña)
        Me.GroupBox1.Controls.Add(Me.txbCEmail)
        Me.GroupBox1.Controls.Add(Me.txbEmail)
        Me.GroupBox1.Controls.Add(Me.txbApellidos)
        Me.GroupBox1.Controls.Add(Me.txbNombres)
        Me.GroupBox1.Controls.Add(Me.txbUserName)
        Me.GroupBox1.Controls.Add(Me.txbID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(1267, 686)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario"
        '
        'frmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmAgregarUsuario"
        Me.Text = "frmAgregarUsuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UserRolOrgnViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserrolOrgViewBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRolViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserrolOrgViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserrolOrgViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BiomessDataSet2 As biomessDataSet2
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As biomessDataSet2TableAdapters.RolTableAdapter
    Friend WithEvents UserRolViewBindingSource As BindingSource
    Friend WithEvents UserRolViewTableAdapter As biomessDataSet2TableAdapters.userRolViewTableAdapter
    Friend WithEvents BiomessDataSet21 As biomessDataSet2
    Friend WithEvents UserrolOrgViewBindingSource As BindingSource
    Friend WithEvents User_rol_OrgViewTableAdapter As biomessDataSet2TableAdapters.user_rol_OrgViewTableAdapter
    Friend WithEvents UserrolOrgViewBindingSource2 As BindingSource
    Friend WithEvents UserrolOrgViewBindingSource1 As BindingSource
    Friend WithEvents UserRolOrgnViewBindingSource As BindingSource
    Friend WithEvents User_Rol_OrgnViewTableAdapter As biomessDataSet2TableAdapters.user_Rol_OrgnViewTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbID As TextBox
    Friend WithEvents txbUserName As TextBox
    Friend WithEvents txbNombres As TextBox
    Friend WithEvents txbApellidos As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbCEmail As TextBox
    Friend WithEvents txbCContraseña As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txbContraseña As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txbBuscar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbxRol As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dvUsuario As DataGridView
    Friend WithEvents IDUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreOrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
