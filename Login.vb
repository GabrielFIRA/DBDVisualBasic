Public Class Login
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim row_v As DataRowView = cbnombreUsu.SelectedItem
        Dim row As DataRow = row_v.Row
        Dim itemName As String = row(8).ToString()

        If tbClave.Text.Equals(itemName) Then
            Dim win = New Reportes()
            Me.Dispose()
            win.Show()
        Else
            MessageBox.Show("CONTRASEÑA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
        BiomessES.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BiomessDataSet2.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.BiomessDataSet2.Usuario)

    End Sub
End Class