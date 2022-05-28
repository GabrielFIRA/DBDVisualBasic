Public Class frmMostrarEmpresa
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Me.Closed
        BiomessES.Close()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim win = New frmEmpresaEmpresa()
        win.Show()
        Me.Dispose()
    End Sub

    Private Sub frmMostrarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BiomessDataSet.Organizacion' Puede moverla o quitarla según sea necesario.
        Me.OrganizacionTableAdapter.Fill(Me.BiomessDataSet.Organizacion)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class