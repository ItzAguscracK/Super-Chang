Public Class Recibo

    Private Sub Recibo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblprecio.Text = "$" & Module1.precio
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class