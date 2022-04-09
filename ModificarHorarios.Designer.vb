<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarHorarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.cbHoraEntrada = New System.Windows.Forms.ComboBox()
        Me.cbHoraSalida = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbMinutoEntrada = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMinutoSalida = New System.Windows.Forms.ComboBox()
        Me.cbTipoHora = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnSiguiente)
        Me.Panel1.Controls.Add(Me.btnAnterior)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cbTipoHora)
        Me.Panel1.Controls.Add(Me.cbMinutoSalida)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbMinutoEntrada)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbHoraSalida)
        Me.Panel1.Controls.Add(Me.cbHoraEntrada)
        Me.Panel1.Controls.Add(Me.cbEmpleado)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 790)
        Me.Panel1.TabIndex = 1
        '
        'cbEmpleado
        '
        Me.cbEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleado.ForeColor = System.Drawing.SystemColors.Control
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(259, 259)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(437, 37)
        Me.cbEmpleado.TabIndex = 18
        Me.cbEmpleado.Text = "Selecionar..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(12, 614)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 31)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(12, 521)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 31)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hora de Salida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 31)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hora de Entrada:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(357, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Modificar Horarios"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(12, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(120, 40)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'cbHoraEntrada
        '
        Me.cbHoraEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbHoraEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHoraEntrada.ForeColor = System.Drawing.SystemColors.Control
        Me.cbHoraEntrada.FormattingEnabled = True
        Me.cbHoraEntrada.Location = New System.Drawing.Point(352, 384)
        Me.cbHoraEntrada.Name = "cbHoraEntrada"
        Me.cbHoraEntrada.Size = New System.Drawing.Size(92, 37)
        Me.cbHoraEntrada.TabIndex = 22
        '
        'cbHoraSalida
        '
        Me.cbHoraSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbHoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHoraSalida.ForeColor = System.Drawing.SystemColors.Control
        Me.cbHoraSalida.FormattingEnabled = True
        Me.cbHoraSalida.Location = New System.Drawing.Point(352, 521)
        Me.cbHoraSalida.Name = "cbHoraSalida"
        Me.cbHoraSalida.Size = New System.Drawing.Size(92, 37)
        Me.cbHoraSalida.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(253, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 31)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "HH:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(503, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 31)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "MM:"
        '
        'cbMinutoEntrada
        '
        Me.cbMinutoEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbMinutoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMinutoEntrada.ForeColor = System.Drawing.SystemColors.Control
        Me.cbMinutoEntrada.FormattingEnabled = True
        Me.cbMinutoEntrada.Location = New System.Drawing.Point(604, 384)
        Me.cbMinutoEntrada.Name = "cbMinutoEntrada"
        Me.cbMinutoEntrada.Size = New System.Drawing.Size(92, 37)
        Me.cbMinutoEntrada.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(253, 521)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 31)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "HH:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(503, 521)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 31)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "MM:"
        '
        'cbMinutoSalida
        '
        Me.cbMinutoSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbMinutoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMinutoSalida.ForeColor = System.Drawing.SystemColors.Control
        Me.cbMinutoSalida.FormattingEnabled = True
        Me.cbMinutoSalida.Location = New System.Drawing.Point(604, 521)
        Me.cbMinutoSalida.Name = "cbMinutoSalida"
        Me.cbMinutoSalida.Size = New System.Drawing.Size(92, 37)
        Me.cbMinutoSalida.TabIndex = 29
        '
        'cbTipoHora
        '
        Me.cbTipoHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbTipoHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoHora.ForeColor = System.Drawing.SystemColors.Control
        Me.cbTipoHora.FormattingEnabled = True
        Me.cbTipoHora.Location = New System.Drawing.Point(259, 614)
        Me.cbTipoHora.Name = "cbTipoHora"
        Me.cbTipoHora.Size = New System.Drawing.Size(437, 37)
        Me.cbTipoHora.TabIndex = 30
        Me.cbTipoHora.Text = "Selecionar..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(12, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(274, 31)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Seleccionar Horarios:"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSiguiente.Location = New System.Drawing.Point(483, 134)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(136, 38)
        Me.btnSiguiente.TabIndex = 33
        Me.btnSiguiente.Text = "Siguiente   "
        Me.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnterior.Location = New System.Drawing.Point(330, 134)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(136, 38)
        Me.btnAnterior.TabIndex = 32
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificar.Location = New System.Drawing.Point(764, 521)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(217, 137)
        Me.btnModificar.TabIndex = 34
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'ModificarHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "ModificarHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Horarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents cbHoraSalida As ComboBox
    Friend WithEvents cbHoraEntrada As ComboBox
    Friend WithEvents cbMinutoSalida As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbMinutoEntrada As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbTipoHora As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnModificar As Button
End Class
