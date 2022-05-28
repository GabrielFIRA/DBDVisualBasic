Imports System.Data.SqlClient
Public Class frmAgregarUsuario

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub frmAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.user_Rol_OrgnView' Puede moverla o quitarla según sea necesario.
        Me.User_Rol_OrgnViewTableAdapter.Fill(Me.BiomessDataSet2.user_Rol_OrgnView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet21.user_rol_OrgView' Puede moverla o quitarla según sea necesario.
        Me.User_rol_OrgViewTableAdapter.Fill(Me.BiomessDataSet21.user_rol_OrgView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.userRolView' Puede moverla o quitarla según sea necesario.
        Me.UserRolViewTableAdapter.Fill(Me.BiomessDataSet2.userRolView)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.Rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.BiomessDataSet2.Rol)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet2.Rol' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Usuario()
        win.Show()
        Me.Dispose()
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        Me.txbID.Text = ""
        Me.txbUserName.Text = ""
        Me.txbNombres.Text = ""
        Me.txbApellidos.Text = ""
        Me.txbContraseña.Text = ""
        Me.txbCContraseña.Text = ""
        Me.txbEmail.Text = ""
        Me.txbCEmail.Text = ""
        Me.cbxRol.SelectedIndex = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.txbUserName.Text.Equals("") Or Me.txbNombres.Text.Equals("") Or Me.txbApellidos.Text.Equals("") Or Me.txbEmail.Text.Equals("") Or Me.txbCEmail.Text.Equals("") Or Me.txbContraseña.Text.Equals("") Or Me.txbCContraseña.Text.Equals("") Or Me.cbxRol.SelectedValue < 0 Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else
                If Me.txbContraseña.Text <> Me.txbCContraseña.Text Then
                    MessageBox.Show("Las contraseñas no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.txbContraseña.Text = ""
                    Me.txbCContraseña.Text = ""
                    Me.txbContraseña.Focus()
                Else
                    If Me.txbEmail.Text <> Me.txbCEmail.Text Then
                        MessageBox.Show("Los correos no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txbEmail.Text = ""
                        Me.txbCEmail.Text = ""
                        Me.txbEmail.Focus()
                    Else
                        Dim tblUsuario As New biomessDataSet2TableAdapters.UsuarioTableAdapter
                        tblUsuario.InsertQuery(Me.cbxRol.SelectedValue, 1, Me.txbUserName.Text, Me.txbNombres.Text, Me.txbApellidos.Text, Me.txbEmail.Text, 1, Me.txbContraseña.Text)
                        MessageBox.Show("El Registro se ha guardado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.User_Rol_OrgnViewTableAdapter.Fill(Me.BiomessDataSet2.user_Rol_OrgnView)
                        limpiarCampos()

                    End If
                End If
            End If
        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Me.txbUserName.Text.Equals("") Or Me.txbNombres.Text.Equals("") Or Me.txbApellidos.Text.Equals("") Or Me.txbEmail.Text.Equals("") Or Me.txbCEmail.Text.Equals("") Or Me.txbContraseña.Text.Equals("") Or Me.txbCContraseña.Text.Equals("") Or Me.cbxRol.SelectedValue < 0 Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else
                If Me.txbContraseña.Text <> Me.txbCContraseña.Text Then
                    MessageBox.Show("Las contraseñas no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.txbContraseña.Text = ""
                    Me.txbCContraseña.Text = ""
                    Me.txbContraseña.Focus()
                Else
                    If Me.txbEmail.Text <> Me.txbCEmail.Text Then
                        MessageBox.Show("Los correos no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txbEmail.Text = ""
                        Me.txbCEmail.Text = ""
                        Me.txbEmail.Focus()
                    Else
                        Dim tblUsuario As New biomessDataSet2TableAdapters.UsuarioTableAdapter
                        tblUsuario.UpdateQuery(Me.cbxRol.SelectedValue, 1, Me.txbUserName.Text, Me.txbNombres.Text, Me.txbApellidos.Text, Me.txbEmail.Text, 2, Me.txbContraseña.Text, Me.txbID.Text, 1)
                        MessageBox.Show("El Registro se ha Actualizado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.User_Rol_OrgnViewTableAdapter.Fill(Me.BiomessDataSet2.user_Rol_OrgnView)
                        limpiarCampos()

                    End If
                End If
            End If
        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try

    End Sub

    Private Sub dvUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvUsuario.CellClick
        Me.txbID.Text = dvUsuario.CurrentRow.Cells.Item(0).Value.ToString()
        Me.txbUserName.Text = dvUsuario.CurrentRow.Cells.Item(1).Value.ToString()
        Me.txbNombres.Text = dvUsuario.CurrentRow.Cells.Item(2).Value.ToString()
        Me.txbApellidos.Text = dvUsuario.CurrentRow.Cells.Item(3).Value.ToString()
        Me.txbEmail.Text = dvUsuario.CurrentRow.Cells.Item(4).Value.ToString()
        Me.txbCEmail.Text = dvUsuario.CurrentRow.Cells.Item(4).Value.ToString()
        Me.cbxRol.SelectedValue = dvUsuario.CurrentRow.Cells.Item(5).Value.ToString()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.txbID.Text.Equals("") Then
                MessageBox.Show("Es necesario el ID del Usuario a eliminar. Señale el usuario en la tabla!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            Else

                Dim tblUsuario As New biomessDataSet2TableAdapters.UsuarioTableAdapter
                tblUsuario.DeleteQuery(Me.txbID.Text)
                MessageBox.Show("El registro se ha eliminado con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.User_Rol_OrgnViewTableAdapter.Fill(Me.BiomessDataSet2.user_Rol_OrgnView)
                limpiarCampos()

            End If

        Catch sqlEx As SqlException
            MsgBox("Error al registrar al usuario: ", sqlEx.Message())
            MsgBox("Error al registrar al usuario: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar al usuario: ", ex.Message())
            MsgBox("Error al registrar al usuario: ", ex.StackTrace())

        End Try
    End Sub

    Private Sub txbBuscar_TextChanged(sender As Object, e As EventArgs) Handles txbBuscar.TextChanged
        Me.dvUsuario.DataSource = Me.User_Rol_OrgnViewTableAdapter.GetDataBy(txbBuscar.Text)
    End Sub
End Class