<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RHorasTrabajadasDepart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RHorasTrabajadasDepart))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSemana = New System.Windows.Forms.ComboBox()
        Me.cbAño2 = New System.Windows.Forms.ComboBox()
        Me.cbMes2 = New System.Windows.Forms.ComboBox()
        Me.cbAño1 = New System.Windows.Forms.ComboBox()
        Me.cbMes1 = New System.Windows.Forms.ComboBox()
        Me.cbFecha = New System.Windows.Forms.ComboBox()
        Me.lbHorasTrabajadas = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTiempo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(13, 2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(141, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(395, 31)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Reporte GeneraI Departamento"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 33)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "Selecionar Departamento"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.cbSemana)
        Me.GroupBox2.Controls.Add(Me.cbAño2)
        Me.GroupBox2.Controls.Add(Me.cbMes2)
        Me.GroupBox2.Controls.Add(Me.cbAño1)
        Me.GroupBox2.Controls.Add(Me.cbMes1)
        Me.GroupBox2.Controls.Add(Me.cbFecha)
        Me.GroupBox2.Controls.Add(Me.lbHorasTrabajadas)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbTiempo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1325, 638)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Horas trabajadas"
        '
        'cbSemana
        '
        Me.cbSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbSemana.ForeColor = System.Drawing.SystemColors.Control
        Me.cbSemana.FormattingEnabled = True
        Me.cbSemana.Location = New System.Drawing.Point(94, 231)
        Me.cbSemana.Name = "cbSemana"
        Me.cbSemana.Size = New System.Drawing.Size(116, 28)
        Me.cbSemana.TabIndex = 11
        '
        'cbAño2
        '
        Me.cbAño2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbAño2.ForeColor = System.Drawing.SystemColors.Control
        Me.cbAño2.FormattingEnabled = True
        Me.cbAño2.Location = New System.Drawing.Point(160, 158)
        Me.cbAño2.Name = "cbAño2"
        Me.cbAño2.Size = New System.Drawing.Size(50, 28)
        Me.cbAño2.TabIndex = 10
        '
        'cbMes2
        '
        Me.cbMes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbMes2.ForeColor = System.Drawing.SystemColors.Control
        Me.cbMes2.FormattingEnabled = True
        Me.cbMes2.Location = New System.Drawing.Point(94, 158)
        Me.cbMes2.Name = "cbMes2"
        Me.cbMes2.Size = New System.Drawing.Size(50, 28)
        Me.cbMes2.TabIndex = 9
        '
        'cbAño1
        '
        Me.cbAño1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbAño1.ForeColor = System.Drawing.SystemColors.Control
        Me.cbAño1.FormattingEnabled = True
        Me.cbAño1.Location = New System.Drawing.Point(225, 94)
        Me.cbAño1.Name = "cbAño1"
        Me.cbAño1.Size = New System.Drawing.Size(80, 28)
        Me.cbAño1.TabIndex = 8
        '
        'cbMes1
        '
        Me.cbMes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbMes1.ForeColor = System.Drawing.SystemColors.Control
        Me.cbMes1.FormattingEnabled = True
        Me.cbMes1.Location = New System.Drawing.Point(160, 95)
        Me.cbMes1.Name = "cbMes1"
        Me.cbMes1.Size = New System.Drawing.Size(50, 28)
        Me.cbMes1.TabIndex = 7
        '
        'cbFecha
        '
        Me.cbFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.cbFecha.FormattingEnabled = True
        Me.cbFecha.Location = New System.Drawing.Point(94, 95)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(50, 28)
        Me.cbFecha.TabIndex = 6
        '
        'lbHorasTrabajadas
        '
        Me.lbHorasTrabajadas.AutoSize = True
        Me.lbHorasTrabajadas.BackColor = System.Drawing.Color.Transparent
        Me.lbHorasTrabajadas.Location = New System.Drawing.Point(182, 308)
        Me.lbHorasTrabajadas.Name = "lbHorasTrabajadas"
        Me.lbHorasTrabajadas.Size = New System.Drawing.Size(22, 22)
        Me.lbHorasTrabajadas.TabIndex = 5
        Me.lbHorasTrabajadas.Text = "X"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(6, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 22)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Horas Trabajadas:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(6, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 22)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Semana:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(6, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 22)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Mes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fecha:"
        '
        'cbTiempo
        '
        Me.cbTiempo.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiempo.ForeColor = System.Drawing.SystemColors.Control
        Me.cbTiempo.FormattingEnabled = True
        Me.cbTiempo.Items.AddRange(New Object() {"Dia", "Mes", "Semana"})
        Me.cbTiempo.Location = New System.Drawing.Point(10, 36)
        Me.cbTiempo.Name = "cbTiempo"
        Me.cbTiempo.Size = New System.Drawing.Size(295, 33)
        Me.cbTiempo.TabIndex = 0
        Me.cbTiempo.Text = "Seleccionar..."
        '
        'RHorasTrabajadasDepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnAtras)
        Me.MaximizeBox = False
        Me.Name = "RHorasTrabajadasDepart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RHorasTrabajadasDepart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbSemana As ComboBox
    Friend WithEvents cbAño2 As ComboBox
    Friend WithEvents cbMes2 As ComboBox
    Friend WithEvents cbAño1 As ComboBox
    Friend WithEvents cbMes1 As ComboBox
    Friend WithEvents cbFecha As ComboBox
    Friend WithEvents lbHorasTrabajadas As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbTiempo As ComboBox
End Class
