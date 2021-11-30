Public Class cobro
    Public total As Integer = 0
    Private Sub txtproducto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtproducto.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcant_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcant.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Module1.precio = total
        total = 0
        x = 0
        sql = "call cargastock"
        Proc(sql)
        x = 0
        sql = "truncate table tempo_produ"
        Proc(sql)
        Recibo.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

        If txtcant.Text = "" Or txtproducto.Text = "" Then
            MsgBox("Falta ingresar algun dato", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
        Else
            Dim stoc As Integer
            x = 0
            sql = "select stock - '" & txtcant.Text & "' from stock where id_produ = '" & txtproducto.Text & "'"
            Proc(sql)
            rs.Read()
            stoc = (rs(0))
            If rs(0) > -1 Then
                sql = ("insert into tempo_produ values('" & txtproducto.Text & "', '" & stoc & "')")
                Proc(sql)
                x = 0
                sql = "select precio from productos where id_produ = '" & txtproducto.Text & "'"
                Proc(sql)
                rs.Read()
                total = total + rs(0) * txtcant.Text
                x = 0
                sql = "select producto from productos where id_produ = '" & txtproducto.Text & "'"
                Proc(sql)
                rs.Read()
                dgv.Rows.Add(rs(0), txtcant.Text)

            Else

                MsgBox("NO HAY SUFICIENTE STOCK: '" & rs(0) & "'", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")

            End If

            txtcant.Text = ""
            txtproducto.Text = ""
        End If


    End Sub
End Class