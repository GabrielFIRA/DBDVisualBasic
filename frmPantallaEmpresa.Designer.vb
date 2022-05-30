<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPantallaEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPantallaEmpresa))
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.btnDepartamentos = New System.Windows.Forms.Button()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmpresa
        '
        Me.btnEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpresa.BackgroundImage = CType(resources.GetObject("btnEmpresa.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpresa.Location = New System.Drawing.Point(193, 34)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(150, 150)
        Me.btnEmpresa.TabIndex = 0
        Me.btnEmpresa.UseVisualStyleBackColor = False
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.AutoSize = True
        Me.btnDepartamentos.BackColor = System.Drawing.Color.Transparent
        Me.btnDepartamentos.BackgroundImage = CType(resources.GetObject("btnDepartamentos.BackgroundImage"), System.Drawing.Image)
        Me.btnDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartamentos.Location = New System.Drawing.Point(407, 34)
        Me.btnDepartamentos.Name = "btnDepartamentos"
        Me.btnDepartamentos.Size = New System.Drawing.Size(150, 150)
        Me.btnDepartamentos.TabIndex = 1
        Me.btnDepartamentos.UseVisualStyleBackColor = False
        '
        'btnCargos
        '
        Me.btnCargos.AutoSize = True
        Me.btnCargos.BackColor = System.Drawing.Color.Transparent
        Me.btnCargos.BackgroundImage = CType(resources.GetObject("btnCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargos.Location = New System.Drawing.Point(609, 34)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(150, 150)
        Me.btnCargos.TabIndex = 2
        Me.btnCargos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(227, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(420, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Departamentos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(643, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cargos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(164, 729)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(155, 44)
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(155, 41)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(155, 41)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(155, 41)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.EmpresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(155, 41)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(816, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Reportes"
        '
        'btnReportes
        '
        Me.btnReportes.AutoSize = True
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), System.Drawing.Image)
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Location = New System.Drawing.Point(784, 34)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(150, 150)
        Me.btnReportes.TabIndex = 8
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'frmPantallaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargos)
        Me.Controls.Add(Me.btnDepartamentos)
        Me.Controls.Add(Me.btnEmpresa)
        Me.Name = "frmPantallaEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmpresa As Button
    Friend WithEvents btnDepartamentos As Button
    Friend WithEvents btnCargos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReportes As Button
End Class
