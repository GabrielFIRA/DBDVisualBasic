<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentos))
        Me.btnMostrarDepartamentos = New System.Windows.Forms.Button()
        Me.btnModificarDepartamento = New System.Windows.Forms.Button()
        Me.btnCrearDepartamento = New System.Windows.Forms.Button()
        Me.btnEliminarDepartamentos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMostrarDepartamentos
        '
        Me.btnMostrarDepartamentos.AutoSize = True
        Me.btnMostrarDepartamentos.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrarDepartamentos.BackgroundImage = CType(resources.GetObject("btnMostrarDepartamentos.BackgroundImage"), System.Drawing.Image)
        Me.btnMostrarDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarDepartamentos.Location = New System.Drawing.Point(560, 308)
        Me.btnMostrarDepartamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrarDepartamentos.Name = "btnMostrarDepartamentos"
        Me.btnMostrarDepartamentos.Size = New System.Drawing.Size(181, 167)
        Me.btnMostrarDepartamentos.TabIndex = 7
        Me.btnMostrarDepartamentos.UseVisualStyleBackColor = False
        '
        'btnModificarDepartamento
        '
        Me.btnModificarDepartamento.AutoSize = True
        Me.btnModificarDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarDepartamento.BackgroundImage = CType(resources.GetObject("btnModificarDepartamento.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarDepartamento.Location = New System.Drawing.Point(16, 309)
        Me.btnModificarDepartamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificarDepartamento.Name = "btnModificarDepartamento"
        Me.btnModificarDepartamento.Size = New System.Drawing.Size(181, 167)
        Me.btnModificarDepartamento.TabIndex = 8
        Me.btnModificarDepartamento.UseVisualStyleBackColor = False
        '
        'btnCrearDepartamento
        '
        Me.btnCrearDepartamento.AutoSize = True
        Me.btnCrearDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearDepartamento.BackgroundImage = CType(resources.GetObject("btnCrearDepartamento.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearDepartamento.Location = New System.Drawing.Point(16, 92)
        Me.btnCrearDepartamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrearDepartamento.Name = "btnCrearDepartamento"
        Me.btnCrearDepartamento.Size = New System.Drawing.Size(181, 167)
        Me.btnCrearDepartamento.TabIndex = 9
        Me.btnCrearDepartamento.UseVisualStyleBackColor = False
        '
        'btnEliminarDepartamentos
        '
        Me.btnEliminarDepartamentos.AutoSize = True
        Me.btnEliminarDepartamentos.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarDepartamentos.BackgroundImage = CType(resources.GetObject("btnEliminarDepartamentos.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDepartamentos.Location = New System.Drawing.Point(560, 92)
        Me.btnEliminarDepartamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarDepartamentos.Name = "btnEliminarDepartamentos"
        Me.btnEliminarDepartamentos.Size = New System.Drawing.Size(181, 167)
        Me.btnEliminarDepartamentos.TabIndex = 10
        Me.btnEliminarDepartamentos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(205, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Crear Nuevo Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(205, 374)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Modificar Departamentos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(759, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Eliminar Departamentos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(749, 363)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mostrar Departamentos"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(16, 15)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(160, 49)
        Me.btnAtras.TabIndex = 15
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'frmDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminarDepartamentos)
        Me.Controls.Add(Me.btnCrearDepartamento)
        Me.Controls.Add(Me.btnModificarDepartamento)
        Me.Controls.Add(Me.btnMostrarDepartamentos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrarDepartamentos As Button
    Friend WithEvents btnModificarDepartamento As Button
    Friend WithEvents btnCrearDepartamento As Button
    Friend WithEvents btnEliminarDepartamentos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAtras As Button
End Class
