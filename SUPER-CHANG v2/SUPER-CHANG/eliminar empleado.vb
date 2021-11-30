Public Class eliminar_empleado




    Private Sub eliminar_empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        x = 0
        sql = "select count(*) from empleado where dni = '" & txtdni.Text & "'"
        Proc(sql)
        rs.Read()
        If rs(0) <> 0 Then
            x = 0
            sql = "delete from empleado where dni = '" & txtdni.Text & "'"
            Proc(sql)
            MsgBox("Empleado eliminado con exito", vbOKOnly)
            txtdni.Text = ""
        Else
            MsgBox("El empleado no existe", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub
End Class