<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearDepartamento))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.tbConfirmarNombre = New System.Windows.Forms.TextBox()
        Me.tbNuevoNombre = New System.Windows.Forms.TextBox()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet = New Biomess_0._1.biomessDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartamentoTableAdapter = New Biomess_0._1.biomessDataSetTableAdapters.DepartamentoTableAdapter()
        Me.TableAdapterManager = New Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager()
        Me.BiomessDataSet2 = New Biomess_0._1.biomessDataSet2()
        Me.OrganizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrganizacionTableAdapter = New Biomess_0._1.biomessDataSet2TableAdapters.OrganizacionTableAdapter()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(227, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Agregar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(501, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Limpiar Campos"
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(501, 233)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(146, 146)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(198, 233)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 146)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(12, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 20
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'tbConfirmarNombre
        '
        Me.tbConfirmarNombre.Location = New System.Drawing.Point(346, 166)
        Me.tbConfirmarNombre.Name = "tbConfirmarNombre"
        Me.tbConfirmarNombre.Size = New System.Drawing.Size(281, 20)
        Me.tbConfirmarNombre.TabIndex = 19
        '
        'tbNuevoNombre
        '
        Me.tbNuevoNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentoBindingSource, "nombreDepart", True))
        Me.tbNuevoNombre.Location = New System.Drawing.Point(346, 122)
        Me.tbNuevoNombre.Name = "tbNuevoNombre"
        Me.tbNuevoNombre.Size = New System.Drawing.Size(281, 20)
        Me.tbNuevoNombre.TabIndex = 18
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BiomessDataSet
        '
        'BiomessDataSet
        '
        Me.BiomessDataSet.DataSetName = "biomessDataSet"
        Me.BiomessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(194, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nuevo Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(112, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Confirmar Nuevo Nombre:"
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AsistenciaTableAdapter = Nothing
        Me.TableAdapterManager.AtrasosTableAdapter = Nothing
        Me.TableAdapterManager.AusenciasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Me.DepartamentoTableAdapter
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FaltasTableAdapter = Nothing
        Me.TableAdapterManager.HorariosTableAdapter = Nothing
        Me.TableAdapterManager.OpcionesTableAdapter = Nothing
        Me.TableAdapterManager.OrganizacionTableAdapter = Nothing
        Me.TableAdapterManager.PermisosTableAdapter = Nothing
        Me.TableAdapterManager.Rol_OpcionesTableAdapter = Nothing
        Me.TableAdapterManager.RolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'BiomessDataSet2
        '
        Me.BiomessDataSet2.DataSetName = "biomessDataSet2"
        Me.BiomessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrganizacionBindingSource
        '
        Me.OrganizacionBindingSource.DataMember = "Organizacion"
        Me.OrganizacionBindingSource.DataSource = Me.BiomessDataSet2
        '
        'OrganizacionTableAdapter
        '
        Me.OrganizacionTableAdapter.ClearBeforeFill = True
        '
        'frmCrearDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.tbConfirmarNombre)
        Me.Controls.Add(Me.tbNuevoNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCrearDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Departamento"
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents tbConfirmarNombre As TextBox
    Friend WithEvents tbNuevoNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BiomessDataSet As biomessDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As biomessDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents TableAdapterManager As biomessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BiomessDataSet2 As biomessDataSet2
    Friend WithEvents OrganizacionBindingSource As BindingSource
    Friend WithEvents OrganizacionTableAdapter As biomessDataSet2TableAdapters.OrganizacionTableAdapter
End Class
