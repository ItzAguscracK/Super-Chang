Public Class recibo_proveedores

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub recibo_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblProveedor.Text = proveedor
        lblPrecio.Text = precioN
        lblProducto.Text = producto
        lblStock.Text = stock
    End Sub
End Class