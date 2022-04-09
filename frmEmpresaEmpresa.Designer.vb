<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresaEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresaEmpresa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModificarDatos = New System.Windows.Forms.Button()
        Me.btnMostrarDatosEmpresa = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(138, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Modificar Datos Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(445, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mostrar Datos Empresa"
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.AutoSize = True
        Me.btnModificarDatos.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarDatos.Image = Global.Biomess_0._1.My.Resources.Resources.Ajustes
        Me.btnModificarDatos.Location = New System.Drawing.Point(176, 91)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(136, 136)
        Me.btnModificarDatos.TabIndex = 6
        Me.btnModificarDatos.UseVisualStyleBackColor = False
        '
        'btnMostrarDatosEmpresa
        '
        Me.btnMostrarDatosEmpresa.AutoSize = True
        Me.btnMostrarDatosEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrarDatosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarDatosEmpresa.Image = Global.Biomess_0._1.My.Resources.Resources.Mostrar
        Me.btnMostrarDatosEmpresa.Location = New System.Drawing.Point(479, 91)
        Me.btnMostrarDatosEmpresa.Name = "btnMostrarDatosEmpresa"
        Me.btnMostrarDatosEmpresa.Size = New System.Drawing.Size(136, 136)
        Me.btnMostrarDatosEmpresa.TabIndex = 7
        Me.btnMostrarDatosEmpresa.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(12, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 10
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'frmEmpresaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biomess_0._1.My.Resources.Resources.Grey2
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnMostrarDatosEmpresa)
        Me.Controls.Add(Me.btnModificarDatos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmpresaEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificarDatos As Button
    Friend WithEvents btnMostrarDatosEmpresa As Button
    Friend WithEvents btnAtras As Button
End Class
