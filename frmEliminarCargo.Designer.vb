<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarCargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminarCargo))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.tbConfirmarCargo = New System.Windows.Forms.TextBox()
        Me.tbCargoAEliminar = New System.Windows.Forms.TextBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BiomessDataSet = New Biomess_0._1.biomessDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbNombreDepar = New System.Windows.Forms.ComboBox()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter = New Biomess_0._1.biomessDataSetTableAdapters.DepartamentoTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CargoTableAdapter = New Biomess_0._1.biomessDataSetTableAdapters.CargoTableAdapter()
        Me.TableAdapterManager = New Biomess_0._1.biomessDataSetTableAdapters.TableAdapterManager()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(12, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 53
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(358, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Eliminar"
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(333, 234)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 147)
        Me.btnEliminar.TabIndex = 51
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'tbConfirmarCargo
        '
        Me.tbConfirmarCargo.Location = New System.Drawing.Point(266, 135)
        Me.tbConfirmarCargo.Name = "tbConfirmarCargo"
        Me.tbConfirmarCargo.Size = New System.Drawing.Size(232, 20)
        Me.tbConfirmarCargo.TabIndex = 50
        '
        'tbCargoAEliminar
        '
        Me.tbCargoAEliminar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargoBindingSource, "nombreCargo", True))
        Me.tbCargoAEliminar.Location = New System.Drawing.Point(266, 91)
        Me.tbCargoAEliminar.Name = "tbCargoAEliminar"
        Me.tbCargoAEliminar.Size = New System.Drawing.Size(232, 20)
        Me.tbCargoAEliminar.TabIndex = 49
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.BiomessDataSet
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
        Me.Label2.Location = New System.Drawing.Point(106, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Cargo a Eliminar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(20, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 24)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Confirmar Cargo a Eliminar:"
        '
        'cbNombreDepar
        '
        Me.cbNombreDepar.DataSource = Me.DepartamentoBindingSource
        Me.cbNombreDepar.DisplayMember = "nombreDepart"
        Me.cbNombreDepar.FormattingEnabled = True
        Me.cbNombreDepar.Location = New System.Drawing.Point(525, 135)
        Me.cbNombreDepar.Name = "cbNombreDepar"
        Me.cbNombreDepar.Size = New System.Drawing.Size(232, 21)
        Me.cbNombreDepar.TabIndex = 54
        Me.cbNombreDepar.ValueMember = "ID_Departamento"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BiomessDataSet
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(516, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Depar del Cargo a Eliminar:"
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AsistenciaTableAdapter = Nothing
        Me.TableAdapterManager.AtrasosTableAdapter = Nothing
        Me.TableAdapterManager.AusenciasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoTableAdapter = Me.CargoTableAdapter
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
        'frmEliminarCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbNombreDepar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.tbConfirmarCargo)
        Me.Controls.Add(Me.tbCargoAEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEliminarCargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Cargo"
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents tbConfirmarCargo As TextBox
    Friend WithEvents tbCargoAEliminar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbNombreDepar As ComboBox
    Friend WithEvents BiomessDataSet As biomessDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As biomessDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As biomessDataSetTableAdapters.CargoTableAdapter
    Friend WithEvents TableAdapterManager As biomessDataSetTableAdapters.TableAdapterManager
End Class
