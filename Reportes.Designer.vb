<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.btnHorasTrabajadas = New System.Windows.Forms.Button()
        Me.btnAsistencia1 = New System.Windows.Forms.Button()
        Me.btnAsistencia2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(166, 729)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(153, 44)
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(153, 41)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(153, 41)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(153, 41)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(153, 41)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Individual", "Departamento"})
        Me.ComboBox1.Location = New System.Drawing.Point(656, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 46)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Seleccionar..."
        '
        'btnGeneral
        '
        Me.btnGeneral.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneral.BackgroundImage = CType(resources.GetObject("btnGeneral.BackgroundImage"), System.Drawing.Image)
        Me.btnGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGeneral.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGeneral.FlatAppearance.BorderSize = 4
        Me.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneral.Location = New System.Drawing.Point(227, 150)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(213, 213)
        Me.btnGeneral.TabIndex = 2
        Me.btnGeneral.UseVisualStyleBackColor = False
        '
        'btnHorasTrabajadas
        '
        Me.btnHorasTrabajadas.BackColor = System.Drawing.Color.Transparent
        Me.btnHorasTrabajadas.BackgroundImage = CType(resources.GetObject("btnHorasTrabajadas.BackgroundImage"), System.Drawing.Image)
        Me.btnHorasTrabajadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHorasTrabajadas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHorasTrabajadas.FlatAppearance.BorderSize = 4
        Me.btnHorasTrabajadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHorasTrabajadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorasTrabajadas.Location = New System.Drawing.Point(503, 150)
        Me.btnHorasTrabajadas.Name = "btnHorasTrabajadas"
        Me.btnHorasTrabajadas.Size = New System.Drawing.Size(213, 213)
        Me.btnHorasTrabajadas.TabIndex = 3
        Me.btnHorasTrabajadas.UseVisualStyleBackColor = False
        '
        'btnAsistencia1
        '
        Me.btnAsistencia1.BackColor = System.Drawing.Color.Transparent
        Me.btnAsistencia1.BackgroundImage = CType(resources.GetObject("btnAsistencia1.BackgroundImage"), System.Drawing.Image)
        Me.btnAsistencia1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsistencia1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAsistencia1.FlatAppearance.BorderSize = 4
        Me.btnAsistencia1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAsistencia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia1.Location = New System.Drawing.Point(789, 150)
        Me.btnAsistencia1.Name = "btnAsistencia1"
        Me.btnAsistencia1.Size = New System.Drawing.Size(213, 213)
        Me.btnAsistencia1.TabIndex = 4
        Me.btnAsistencia1.UseVisualStyleBackColor = False
        '
        'btnAsistencia2
        '
        Me.btnAsistencia2.BackColor = System.Drawing.Color.Transparent
        Me.btnAsistencia2.BackgroundImage = CType(resources.GetObject("btnAsistencia2.BackgroundImage"), System.Drawing.Image)
        Me.btnAsistencia2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsistencia2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAsistencia2.FlatAppearance.BorderSize = 4
        Me.btnAsistencia2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAsistencia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia2.Location = New System.Drawing.Point(1075, 150)
        Me.btnAsistencia2.Name = "btnAsistencia2"
        Me.btnAsistencia2.Size = New System.Drawing.Size(213, 213)
        Me.btnAsistencia2.TabIndex = 5
        Me.btnAsistencia2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(274, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "General"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(497, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Horas Trabajadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(811, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Asistencia 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(1101, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Asistencia 2"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAsistencia2)
        Me.Controls.Add(Me.btnAsistencia1)
        Me.Controls.Add(Me.btnHorasTrabajadas)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnGeneral As Button
    Friend WithEvents btnHorasTrabajadas As Button
    Friend WithEvents btnAsistencia1 As Button
    Friend WithEvents btnAsistencia2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
