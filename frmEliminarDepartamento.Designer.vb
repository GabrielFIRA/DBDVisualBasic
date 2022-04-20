<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminarDepartamento))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.tbConfirmarDepartamento = New System.Windows.Forms.TextBox()
        Me.tbDepartamentoAEliminar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(16, 15)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(160, 49)
        Me.btnAtras.TabIndex = 46
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(478, 488)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 29)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Eliminar"
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(444, 289)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(186, 181)
        Me.btnEliminar.TabIndex = 41
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'tbConfirmarDepartamento
        '
        Me.tbConfirmarDepartamento.Location = New System.Drawing.Point(444, 225)
        Me.tbConfirmarDepartamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbConfirmarDepartamento.Name = "tbConfirmarDepartamento"
        Me.tbConfirmarDepartamento.Size = New System.Drawing.Size(373, 22)
        Me.tbConfirmarDepartamento.TabIndex = 39
        '
        'tbDepartamentoAEliminar
        '
        Me.tbDepartamentoAEliminar.Location = New System.Drawing.Point(444, 171)
        Me.tbDepartamentoAEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDepartamentoAEliminar.Name = "tbDepartamentoAEliminar"
        Me.tbDepartamentoAEliminar.Size = New System.Drawing.Size(373, 22)
        Me.tbDepartamentoAEliminar.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(141, 171)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 29)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Departamento a Eliminar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(27, 225)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 29)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Confirmar Departamento a Eliminar:"
        '
        'frmEliminarDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.tbConfirmarDepartamento)
        Me.Controls.Add(Me.tbDepartamentoAEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEliminarDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents tbConfirmarDepartamento As TextBox
    Friend WithEvents tbDepartamentoAEliminar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
