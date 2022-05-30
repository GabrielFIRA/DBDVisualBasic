<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnRol = New System.Windows.Forms.Button()
        Me.btnOpc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRolOpc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(238, 998)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(225, 44)
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(225, 58)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(225, 58)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(225, 58)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(225, 58)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
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
        Me.btnAgregar.Location = New System.Drawing.Point(354, 80)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(320, 328)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnRol
        '
        Me.btnRol.BackColor = System.Drawing.Color.Transparent
        Me.btnRol.BackgroundImage = CType(resources.GetObject("btnRol.BackgroundImage"), System.Drawing.Image)
        Me.btnRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRol.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRol.FlatAppearance.BorderSize = 4
        Me.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRol.Location = New System.Drawing.Point(923, 80)
        Me.btnRol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRol.Name = "btnRol"
        Me.btnRol.Size = New System.Drawing.Size(320, 328)
        Me.btnRol.TabIndex = 4
        Me.btnRol.UseVisualStyleBackColor = False
        '
        'btnOpc
        '
        Me.btnOpc.BackColor = System.Drawing.Color.Transparent
        Me.btnOpc.BackgroundImage = CType(resources.GetObject("btnOpc.BackgroundImage"), System.Drawing.Image)
        Me.btnOpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnOpc.FlatAppearance.BorderSize = 4
        Me.btnOpc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnOpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpc.Location = New System.Drawing.Point(354, 575)
        Me.btnOpc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpc.Name = "btnOpc"
        Me.btnOpc.Size = New System.Drawing.Size(320, 328)
        Me.btnOpc.TabIndex = 5
        Me.btnOpc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(739, 724)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Opcion"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(739, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 55)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1299, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 55)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Rol"
        '
        'btnRolOpc
        '
        Me.btnRolOpc.BackColor = System.Drawing.Color.Transparent
        Me.btnRolOpc.BackgroundImage = CType(resources.GetObject("btnRolOpc.BackgroundImage"), System.Drawing.Image)
        Me.btnRolOpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRolOpc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRolOpc.FlatAppearance.BorderSize = 4
        Me.btnRolOpc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRolOpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRolOpc.Location = New System.Drawing.Point(923, 568)
        Me.btnRolOpc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRolOpc.Name = "btnRolOpc"
        Me.btnRolOpc.Size = New System.Drawing.Size(320, 328)
        Me.btnRolOpc.TabIndex = 10
        Me.btnRolOpc.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1299, 709)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 55)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Rol-Opcion"
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), System.Drawing.Image)
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReportes.FlatAppearance.BorderSize = 4
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Location = New System.Drawing.Point(1566, 325)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(149, 149)
        Me.btnReportes.TabIndex = 12
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1573, 529)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 55)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Reporte"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1880, 998)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRolOpc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpc)
        Me.Controls.Add(Me.btnRol)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnRol As Button
    Friend WithEvents btnOpc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRolOpc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReportes As Button
    Friend WithEvents Label5 As Label
End Class
