Public Class cargarstock

    Private Sub btnRecaS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecaS.Click
        recargarstock.Show()
        Me.Close()
    End Sub

    Private Sub btnNueS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueS.Click
        nuevostock.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class