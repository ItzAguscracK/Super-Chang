Public Class contraseña_jefe
    Private Sub contraseña_jefe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        x = 0
        sql = "select contrasenia from empleado where id_empleado = 1"
        Proc(sql)
        rs.Read()
        If rs(0) = txtcontraseña.Text Then
            eliminar_empleado.Show()
            inicio.Close()
            Me.Close()
        Else
            MsgBox("Contraseña Incorrecta", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
            txtcontraseña.Text = ""
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub txtcontraseña_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
End Class