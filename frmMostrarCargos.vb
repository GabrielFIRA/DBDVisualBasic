Public Class frmMostrarCargos
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New Cargos()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frmMostrarCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BiomessDataSet2.Cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter1.Fill(Me.BiomessDataSet2.Cargo)
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.BiomessDataSet.Cargo)

    End Sub

    Private Sub CargoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CargoDataGridView.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Me.dgvUsuario.DataSource = Me.UsuarioTableAdapter.GetDataBy1(Me.tbBuscar.Text)
        Me.CargoDataGridView.DataSource = Me.CargoTableAdapter1.GetDataBy(Me.TextBox1.Text)
    End Sub
End Class