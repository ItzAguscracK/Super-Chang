Public Class contraseña_empleado
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcontraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        x = 0
        sql = "select count(*) from empleado where dni = '" & txtusuario.Text & "' and contrasenia = '" & txtcontraseña.Text & "' and autorizado = 1"
        Proc(sql)
        rs.Read()
        If rs(0) > 0 Then
            cargarstock.Show()
            inicio.Close()
            Me.Close()
        Else
            MsgBox("Contraseña Incorrecta", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
            txtcontraseña.Text = ""
            txtusuario.Text = ""
        End If
    End Sub
End Class