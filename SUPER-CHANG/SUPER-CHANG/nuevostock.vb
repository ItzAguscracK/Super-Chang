Public Class nuevostock
    Dim iProd As Integer
    Dim iProv As Integer

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click

        If txtMarca.Text = "" Or txtPrecio.Text = "" Or txtProd.Text = "" Or txtStock.Text = "" Or cmbProve.Text = "" Then
            MsgBox("Falta ingresar algun dato", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
        Else
            x = 0
            sql = "INSERT INTO productos VALUES('', '" & txtProd.Text & "', '" & txtMarca.Text & "', '" & txtPrecio.Text & "')"
            Proc(sql)

            x = 0
            sql = "SELECT id_produ FROM productos WHERE producto = '" & txtProd.Text & "'"
            Proc(sql)
            If rs.Read = True Then
                iProd = rs(0)
            End If

            x = 0
            sql = "SELECT id_prove FROM proveedores WHERE provedor = '" & cmbProve.Text & "'"
            Proc(sql)
            If rs.Read = True Then
                iProv = rs(0)
            End If

            x = 0
            sql = "INSERT INTO stock VALUES('', '" & txtStock.Text & "', '" & iProd & "', '" & iProv & "')"
            Proc(sql)

            precioN = Val(txtStock.Text * txtPrecio.Text)
            proveedor = cmbProve.Text
            producto = txtProd.Text
            stock = txtStock.Text

            txtMarca.Text = ""
            txtPrecio.Text = ""
            txtProd.Text = ""
            txtStock.Text = ""
            cmbProve.Text = ""
            recibo_proveedores.Show()

        End If
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        cargarstock.Show()
        Me.Close()
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        Dim numbers As Windows.Forms.TextBox = sender
        If InStr("1234567890.()-+ ", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub nuevostock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x = 0
        sql = "SELECT provedor FROM proveedores"
        Proc(sql)


        While rs.Read = True
            cmbProve.Items.Add(rs(0))
        End While
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class