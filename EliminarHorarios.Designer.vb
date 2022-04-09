<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarHorarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTipoHora = New System.Windows.Forms.Label()
        Me.lbHoraSalida = New System.Windows.Forms.Label()
        Me.lbHoraEntrada = New System.Windows.Forms.Label()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnSiguiente)
        Me.Panel1.Controls.Add(Me.btnAnterior)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbTipoHora)
        Me.Panel1.Controls.Add(Me.lbHoraSalida)
        Me.Panel1.Controls.Add(Me.lbHoraEntrada)
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
        Me.Panel1.TabIndex = 2
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
        Me.btnSiguiente.Location = New System.Drawing.Point(488, 118)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(136, 38)
        Me.btnSiguiente.TabIndex = 36
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
        Me.btnAnterior.Location = New System.Drawing.Point(335, 118)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(136, 38)
        Me.btnAnterior.TabIndex = 35
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(17, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(274, 31)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Seleccionar Horarios:"
        '
        'lbTipoHora
        '
        Me.lbTipoHora.AutoSize = True
        Me.lbTipoHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoHora.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTipoHora.Location = New System.Drawing.Point(258, 606)
        Me.lbTipoHora.Name = "lbTipoHora"
        Me.lbTipoHora.Size = New System.Drawing.Size(32, 31)
        Me.lbTipoHora.TabIndex = 21
        Me.lbTipoHora.Text = "X"
        '
        'lbHoraSalida
        '
        Me.lbHoraSalida.AutoSize = True
        Me.lbHoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoraSalida.ForeColor = System.Drawing.SystemColors.Control
        Me.lbHoraSalida.Location = New System.Drawing.Point(258, 475)
        Me.lbHoraSalida.Name = "lbHoraSalida"
        Me.lbHoraSalida.Size = New System.Drawing.Size(32, 31)
        Me.lbHoraSalida.TabIndex = 20
        Me.lbHoraSalida.Text = "X"
        '
        'lbHoraEntrada
        '
        Me.lbHoraEntrada.AutoSize = True
        Me.lbHoraEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoraEntrada.ForeColor = System.Drawing.SystemColors.Control
        Me.lbHoraEntrada.Location = New System.Drawing.Point(258, 344)
        Me.lbHoraEntrada.Name = "lbHoraEntrada"
        Me.lbHoraEntrada.Size = New System.Drawing.Size(32, 31)
        Me.lbHoraEntrada.TabIndex = 19
        Me.lbHoraEntrada.Text = "X"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleado.ForeColor = System.Drawing.SystemColors.Control
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(264, 213)
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
        Me.Label5.Location = New System.Drawing.Point(11, 606)
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
        Me.Label4.Location = New System.Drawing.Point(17, 475)
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
        Me.Label3.Location = New System.Drawing.Point(17, 213)
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
        Me.Label2.Location = New System.Drawing.Point(17, 344)
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
        Me.Label1.Size = New System.Drawing.Size(240, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Crear Horarios"
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
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Location = New System.Drawing.Point(264, 656)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(437, 42)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'EliminarHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "EliminarHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Horarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lbTipoHora As Label
    Friend WithEvents lbHoraSalida As Label
    Friend WithEvents lbHoraEntrada As Label
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEliminar As Button
End Class
