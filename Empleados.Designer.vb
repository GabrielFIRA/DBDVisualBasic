<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.lklEmpleados = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lklAusencias = New System.Windows.Forms.LinkLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAusencias = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(670, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpleados.BackgroundImage = CType(resources.GetObject("btnEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEmpleados.Location = New System.Drawing.Point(227, 54)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(110, 110)
        Me.btnEmpleados.TabIndex = 3
        Me.btnEmpleados.UseVisualStyleBackColor = False
        '
        'lklEmpleados
        '
        Me.lklEmpleados.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lklEmpleados.AutoSize = True
        Me.lklEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.lklEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lklEmpleados.ForeColor = System.Drawing.SystemColors.Control
        Me.lklEmpleados.LinkColor = System.Drawing.SystemColors.Control
        Me.lklEmpleados.Location = New System.Drawing.Point(377, 83)
        Me.lklEmpleados.Name = "lklEmpleados"
        Me.lklEmpleados.Size = New System.Drawing.Size(188, 39)
        Me.lklEmpleados.TabIndex = 11
        Me.lklEmpleados.TabStop = True
        Me.lklEmpleados.Text = "Empleados"
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
        Me.MenuStrip1.TabIndex = 15
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
        Me.EmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
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
        Me.EmpresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(155, 41)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(554, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Caracterisiticas empleado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel6
        '
        Me.LinkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LinkLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.LinkLabel6.LinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel6.Location = New System.Drawing.Point(1081, 514)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(173, 39)
        Me.LinkLabel6.TabIndex = 43
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Asistencia"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LinkLabel7.ForeColor = System.Drawing.SystemColors.Control
        Me.LinkLabel7.LinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel7.Location = New System.Drawing.Point(1081, 385)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(159, 39)
        Me.LinkLabel7.TabIndex = 42
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Permisos"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LinkLabel8.ForeColor = System.Drawing.SystemColors.Control
        Me.LinkLabel8.LinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel8.Location = New System.Drawing.Point(1081, 259)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(194, 39)
        Me.LinkLabel8.TabIndex = 41
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Vacaciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(878, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 110)
        Me.Button1.TabIndex = 40
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(878, 485)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 110)
        Me.Button6.TabIndex = 39
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.Location = New System.Drawing.Point(878, 230)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 110)
        Me.Button8.TabIndex = 38
        Me.Button8.UseVisualStyleBackColor = False
        '
        'LinkLabel4
        '
        Me.LinkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LinkLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.LinkLabel4.LinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel4.Location = New System.Drawing.Point(430, 635)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(146, 39)
        Me.LinkLabel4.TabIndex = 37
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Horarios"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LinkLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.LinkLabel3.LinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel3.Location = New System.Drawing.Point(430, 514)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(110, 39)
        Me.LinkLabel3.TabIndex = 36
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Faltas"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LinkLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.LinkLabel2.LinkColor = System.Drawing.SystemColors.Control
        Me.LinkLabel2.Location = New System.Drawing.Point(430, 385)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(132, 39)
        Me.LinkLabel2.TabIndex = 35
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Atrasos"
        '
        'lklAusencias
        '
        Me.lklAusencias.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lklAusencias.AutoSize = True
        Me.lklAusencias.BackColor = System.Drawing.Color.Transparent
        Me.lklAusencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lklAusencias.ForeColor = System.Drawing.SystemColors.Control
        Me.lklAusencias.LinkColor = System.Drawing.SystemColors.Control
        Me.lklAusencias.Location = New System.Drawing.Point(430, 259)
        Me.lklAusencias.Name = "lklAusencias"
        Me.lklAusencias.Size = New System.Drawing.Size(175, 39)
        Me.lklAusencias.TabIndex = 34
        Me.lklAusencias.TabStop = True
        Me.lklAusencias.Text = "Ausencias"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(227, 356)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 110)
        Me.Button5.TabIndex = 33
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(227, 485)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 110)
        Me.Button4.TabIndex = 32
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(227, 606)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 110)
        Me.Button3.TabIndex = 31
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnAusencias
        '
        Me.btnAusencias.BackColor = System.Drawing.Color.Transparent
        Me.btnAusencias.BackgroundImage = CType(resources.GetObject("btnAusencias.BackgroundImage"), System.Drawing.Image)
        Me.btnAusencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAusencias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAusencias.Location = New System.Drawing.Point(227, 230)
        Me.btnAusencias.Name = "btnAusencias"
        Me.btnAusencias.Size = New System.Drawing.Size(110, 110)
        Me.btnAusencias.TabIndex = 30
        Me.btnAusencias.UseVisualStyleBackColor = False
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.LinkLabel6)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.LinkLabel8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.lklAusencias)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAusencias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lklEmpleados)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents lklEmpleados As LinkLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents lklAusencias As LinkLabel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAusencias As Button
End Class
