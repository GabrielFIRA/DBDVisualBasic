﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargos))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarCargos = New System.Windows.Forms.Button()
        Me.btnCrearCargo = New System.Windows.Forms.Button()
        Me.btnModificarCargo = New System.Windows.Forms.Button()
        Me.btnMostrarCargos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(23, 47)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(160, 49)
        Me.btnAtras.TabIndex = 24
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(786, 402)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Mostrar Cargos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(779, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Eliminar Cargos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(274, 405)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Modificar Cargo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(274, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Crear Nuevo Cargo"
        '
        'btnEliminarCargos
        '
        Me.btnEliminarCargos.AutoSize = True
        Me.btnEliminarCargos.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarCargos.BackgroundImage = CType(resources.GetObject("btnEliminarCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCargos.Location = New System.Drawing.Point(567, 124)
        Me.btnEliminarCargos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarCargos.Name = "btnEliminarCargos"
        Me.btnEliminarCargos.Size = New System.Drawing.Size(197, 167)
        Me.btnEliminarCargos.TabIndex = 19
        Me.btnEliminarCargos.UseVisualStyleBackColor = False
        '
        'btnCrearCargo
        '
        Me.btnCrearCargo.AutoSize = True
        Me.btnCrearCargo.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCargo.BackgroundImage = CType(resources.GetObject("btnCrearCargo.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCargo.Location = New System.Drawing.Point(23, 124)
        Me.btnCrearCargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrearCargo.Name = "btnCrearCargo"
        Me.btnCrearCargo.Size = New System.Drawing.Size(197, 167)
        Me.btnCrearCargo.TabIndex = 18
        Me.btnCrearCargo.UseVisualStyleBackColor = False
        '
        'btnModificarCargo
        '
        Me.btnModificarCargo.AutoSize = True
        Me.btnModificarCargo.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarCargo.BackgroundImage = CType(resources.GetObject("btnModificarCargo.BackgroundImage"), System.Drawing.Image)
        Me.btnModificarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarCargo.Location = New System.Drawing.Point(23, 340)
        Me.btnModificarCargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificarCargo.Name = "btnModificarCargo"
        Me.btnModificarCargo.Size = New System.Drawing.Size(202, 167)
        Me.btnModificarCargo.TabIndex = 17
        Me.btnModificarCargo.UseVisualStyleBackColor = False
        '
        'btnMostrarCargos
        '
        Me.btnMostrarCargos.AutoSize = True
        Me.btnMostrarCargos.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrarCargos.BackgroundImage = CType(resources.GetObject("btnMostrarCargos.BackgroundImage"), System.Drawing.Image)
        Me.btnMostrarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarCargos.Location = New System.Drawing.Point(567, 333)
        Me.btnMostrarCargos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrarCargos.Name = "btnMostrarCargos"
        Me.btnMostrarCargos.Size = New System.Drawing.Size(197, 174)
        Me.btnMostrarCargos.TabIndex = 16
        Me.btnMostrarCargos.UseVisualStyleBackColor = False
        '
        'frmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminarCargos)
        Me.Controls.Add(Me.btnCrearCargo)
        Me.Controls.Add(Me.btnModificarCargo)
        Me.Controls.Add(Me.btnMostrarCargos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCargos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminarCargos As Button
    Friend WithEvents btnCrearCargo As Button
    Friend WithEvents btnModificarCargo As Button
    Friend WithEvents btnMostrarCargos As Button
End Class
