Public Class inicio

    Private Sub btncobro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncobro.Click
        cobro.Show()
        Me.Close()
    End Sub

    Private Sub btnaemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaemp.Click
        contraseñajefe.Show()
    End Sub

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    Private Sub btneemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneemp.Click
        contraseña_jefe.Show()
    End Sub

    Private Sub btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstock.Click
        contraseña_empleado.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
