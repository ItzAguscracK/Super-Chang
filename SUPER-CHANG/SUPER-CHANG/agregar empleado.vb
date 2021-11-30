Public Class agregar_empleado

    


    Private Sub agregar_empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboaut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboaut.CheckedChanged
        If cboaut.Checked = True Then
            txtcontraseña.Enabled = True
        Else
            txtcontraseña.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        If txtapellido.Text = "" Or txtdireccion.Text = "" Or txtdni.Text = "" Or txtnombre.Text = "" Or txtTelefono.Text = "" Then
            MsgBox("Falta ingresar un dato", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
        Else
            x = 0
            Dim aut As Integer
            If cboaut.Checked = True Then
                aut = 1
            Else
                aut = 0
            End If
            sql = "insert into empleado values('', '" & txtnombre.Text & "', '" & txtapellido.Text & "', '" & txtdni.Text & "', '" & txtcontraseña.Text & "', '" & txtdireccion.Text & "', '" & txtTelefono.Text & "', curdate() , '" & aut & "')"
            Proc(sql)
            MsgBox("Empleado cargado con exito", vbOKOnly)
            txtapellido.Text = ""
            txtcontraseña.Text = ""
            txtdireccion.Text = ""
            txtTelefono.Text = ""
            txtdni.Text = ""
            txtnombre.Text = ""
            cboaut.AutoCheck = False
        End If
    End Sub

    Private Sub txtcontraseña_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtdni_KeyPress1(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

End Class