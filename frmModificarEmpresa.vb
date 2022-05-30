Imports System.Data.SqlClient
Public Class frmModificarEmpresa


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmEmpresaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        limpiarCampos()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If Me.tbNuevoNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbNuevoNombre.Focus()

            ElseIf Me.tbConfirmarNombre.Text.Equals("") Then
                MessageBox.Show("Debe escribir ambos nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbConfirmarNombre.Focus()
            ElseIf Me.tbNuevoNombre.Text <> Me.tbConfirmarNombre.Text Then
                MessageBox.Show("Los nombres no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                limpiarCampos()
                Me.tbNuevoNombre.Focus()


            Else
                Dim tblOrganizacion As New biomessDataSetTableAdapters.OrganizacionTableAdapter
                Dim rows() As DataRow = Me.OrganizacionTableAdapter.GetData().Select()
                Dim id_OrgTemp As Integer = rows(0).Item("ID_Organizacion")

                tblOrganizacion.UpdateQuery(nombreOrg:=Me.tbNuevoNombre.Text,
                                            estado:=2,
                                            Original_ID_Organizacion:=id_OrgTemp,
                                            ID_Organizacion:=id_OrgTemp)
                'En ID_ORGANIZACION pongan deberia ser 1 pero en fin pongan el id actual del unico nombre que hay'
                MessageBox.Show("El registro se ha guardado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.OrganizacionTableAdapter.Fill(Me.BiomessDataSet.Organizacion)
                limpiarCampos()
            End If
        Catch sqlex As SqlException
            MsgBox("Error al registrar al modificar el nombre de la Organizacion: ", sqlex.Message())
            MsgBox("Error al registrar al modificar el nombre de la Organizacion: ", sqlex.StackTrace())
        Catch ex As Exception
            MsgBox("Error al registrar al modificar el nombre de la Organizacion: ", ex.Message())
            MsgBox("Error al registrar al modificar el nombre de la Organizacion: ", ex.StackTrace())
        End Try
    End Sub


    Private Sub limpiarCampos()
        Me.tbNuevoNombre.Text = ""
        Me.tbConfirmarNombre.Text = ""
    End Sub

    Private Sub OrganizacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrganizacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BiomessDataSet)

    End Sub

    Private Sub frmModificarEmpresa_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Organizacion' Puede moverla o quitarla según sea necesario.
        Me.OrganizacionTableAdapter.Fill(Me.BiomessDataSet.Organizacion)

    End Sub


End Class