<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearPermisosvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearPermisosvb))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.cbAño1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMes1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbDia1 = New System.Windows.Forms.ComboBox()
        Me.cbAño2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMes2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDia2 = New System.Windows.Forms.ComboBox()
        Me.tbTipoPermiso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.btnCrear)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.cbAño1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbMes1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbDia1)
        Me.GroupBox1.Controls.Add(Me.cbAño2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbMes2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbDia2)
        Me.GroupBox1.Controls.Add(Me.tbTipoPermiso)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(300, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 704)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Permisos"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnCrear.Location = New System.Drawing.Point(196, 272)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(434, 68)
        Me.btnCrear.TabIndex = 18
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'cbEmpleado
        '
        Me.cbEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbEmpleado.ForeColor = System.Drawing.SystemColors.Control
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(196, 45)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(324, 33)
        Me.cbEmpleado.TabIndex = 17
        Me.cbEmpleado.Text = "Selecionar..."
        '
        'cbAño1
        '
        Me.cbAño1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbAño1.ForeColor = System.Drawing.SystemColors.Control
        Me.cbAño1.FormattingEnabled = True
        Me.cbAño1.Location = New System.Drawing.Point(538, 101)
        Me.cbAño1.Name = "cbAño1"
        Me.cbAño1.Size = New System.Drawing.Size(92, 33)
        Me.cbAño1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(463, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 26)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Año:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 26)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Mes:"
        '
        'cbMes1
        '
        Me.cbMes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbMes1.ForeColor = System.Drawing.SystemColors.Control
        Me.cbMes1.FormattingEnabled = True
        Me.cbMes1.Location = New System.Drawing.Point(383, 101)
        Me.cbMes1.Name = "cbMes1"
        Me.cbMes1.Size = New System.Drawing.Size(52, 33)
        Me.cbMes1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(191, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 26)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Dia:"
        '
        'cbDia1
        '
        Me.cbDia1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbDia1.ForeColor = System.Drawing.SystemColors.Control
        Me.cbDia1.FormattingEnabled = True
        Me.cbDia1.Location = New System.Drawing.Point(247, 101)
        Me.cbDia1.Name = "cbDia1"
        Me.cbDia1.Size = New System.Drawing.Size(52, 33)
        Me.cbDia1.TabIndex = 11
        '
        'cbAño2
        '
        Me.cbAño2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbAño2.ForeColor = System.Drawing.SystemColors.Control
        Me.cbAño2.FormattingEnabled = True
        Me.cbAño2.Location = New System.Drawing.Point(538, 157)
        Me.cbAño2.Name = "cbAño2"
        Me.cbAño2.Size = New System.Drawing.Size(92, 33)
        Me.cbAño2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(463, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 26)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Mes:"
        '
        'cbMes2
        '
        Me.cbMes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbMes2.ForeColor = System.Drawing.SystemColors.Control
        Me.cbMes2.FormattingEnabled = True
        Me.cbMes2.Location = New System.Drawing.Point(383, 157)
        Me.cbMes2.Name = "cbMes2"
        Me.cbMes2.Size = New System.Drawing.Size(52, 33)
        Me.cbMes2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Dia:"
        '
        'cbDia2
        '
        Me.cbDia2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbDia2.ForeColor = System.Drawing.SystemColors.Control
        Me.cbDia2.FormattingEnabled = True
        Me.cbDia2.Location = New System.Drawing.Point(247, 157)
        Me.cbDia2.Name = "cbDia2"
        Me.cbDia2.Size = New System.Drawing.Size(52, 33)
        Me.cbDia2.TabIndex = 5
        '
        'tbTipoPermiso
        '
        Me.tbTipoPermiso.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.tbTipoPermiso.ForeColor = System.Drawing.SystemColors.Control
        Me.tbTipoPermiso.Location = New System.Drawing.Point(196, 213)
        Me.tbTipoPermiso.Name = "tbTipoPermiso"
        Me.tbTipoPermiso.Size = New System.Drawing.Size(434, 32)
        Me.tbTipoPermiso.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo Permiso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fin del Periodo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio del Periodo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtras.Location = New System.Drawing.Point(13, 13)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(270, 90)
        Me.btnAtras.TabIndex = 16
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'CrearPermisosvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "CrearPermisosvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Permisos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents cbAño1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbMes1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbDia1 As ComboBox
    Friend WithEvents cbAño2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbMes2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDia2 As ComboBox
    Friend WithEvents tbTipoPermiso As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnAtras As Button
End Class
