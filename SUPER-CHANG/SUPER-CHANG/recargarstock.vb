Public Class recargarstock
    Dim produ As Integer
    Dim stockActual As Integer
    Dim sumStock As Integer

    Private Sub recargarstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x = 0
        sql = "SELECT producto FROM productos"
        Proc(sql)
            While rs.Read = True
                lstRecarga.Items.Add(rs(0))
            End While
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click

        If txtProd.Text = "" Or txtStock.Text = "" Then
            MsgBox("Falta ingresar algun dato", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
        Else
            x = 0
            sql = "SELECT id_produ FROM productos WHERE producto = '" & lstRecarga.Text & "'"
            Proc(sql)
            If rs.Read = True Then
                produ = rs(0)

                x = 0
                sql = "SELECT stock FROM stock WHERE id_produ = '" & produ & "'"
                Proc(sql)
                If rs.Read = True Then
                    stockActual = rs(0)
                End If

                sumStock = stockActual + txtStock.Text

                x = 0
                sql = "UPDATE stock SET stock = '" & sumStock + txtStock.Text & "' WHERE id_produ = '" & produ & "'"
                Proc(sql)
                MsgBox("El stock ha sido actualizado con exito")
            Else
                MsgBox("El producto no esta registrado en la Base de Datos", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ERROR")
            End If

            x = 0
            sql = "SELECT p.provedor FROM productos AS prd INNER JOIN stock AS s ON prd.id_produ = s.id_produ INNER JOIN proveedores AS p ON s.id_prove = p.id_prove WHERE prd.producto = '" & txtProd.Text & "'"
            Proc(sql)
            If rs.Read = True Then
                proveedor = rs(0)
            End If

            x = 0
            sql = "SELECT pr.precio FROM productos AS pr INNER JOIN stock as s ON pr.id_produ = s.id_produ WHERE pr.producto = '" & txtProd.Text & "'"
            Proc(sql)
            If rs.Read = True Then
                precioN = rs(0) * Val(txtStock.Text)
            End If
            producto = txtProd.Text
            stock = txtStock.Text

            txtProd.Text = ""
            txtStock.Text = ""
            stockActual = 0
            sumStock = 0
            recibo_proveedores.Show()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        cargarstock.Show()
        Me.Close()
    End Sub

    Private Sub txtProd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtProd.KeyPress
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

    Private Sub lstRecarga_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRecarga.SelectedIndexChanged
        txtProd.Text = lstRecarga.Text
    End Sub
End Class