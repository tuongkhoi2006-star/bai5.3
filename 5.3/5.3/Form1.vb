Public Class Form1
    Private ReadOnly _products As New List(Of Product)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDanhMuc.Items.AddRange(New Object() {"Điện tử", "Gia dụng", "Thực phẩm", "Thời trang", "Khác"})
        bindingSource.DataSource = _products
        dgvProducts.DataSource = bindingSource
    End Sub

    Private Function DocDuLieuNhap() As Product
        If String.IsNullOrWhiteSpace(txtMaSP.Text) OrElse String.IsNullOrWhiteSpace(txtTenSP.Text) Then
            MessageBox.Show("Vui lòng nhập Mã SP và Tên SP.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If

        Dim donGia As Decimal
        If Not Decimal.TryParse(txtDonGia.Text, donGia) OrElse donGia < 0 Then
            MessageBox.Show("Đơn giá không hợp lệ.", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If

        Dim soLuong As Integer
        If Not Integer.TryParse(txtSoLuong.Text, soLuong) OrElse soLuong < 0 Then
            MessageBox.Show("Số lượng không hợp lệ.", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End If

        Return New Product(txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), donGia, soLuong, cboDanhMuc.Text.Trim())
    End Function

    Private Sub LamMoiNhapLieu()
        txtMaSP.Clear()
        txtTenSP.Clear()
        txtDonGia.Clear()
        txtSoLuong.Clear()
        cboDanhMuc.SelectedIndex = -1
        txtMaSP.Focus()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim sp = DocDuLieuNhap()
        If sp Is Nothing Then Return

        _products.Add(sp)
        bindingSource.ResetBindings(False)
        LamMoiNhapLieu()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim sp = TryCast(bindingSource.Current, Product)
        If sp Is Nothing Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa trên lưới.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim duLieuMoi = DocDuLieuNhap()
        If duLieuMoi Is Nothing Then Return

        sp.ProductId = duLieuMoi.ProductId
        sp.ProductName = duLieuMoi.ProductName
        sp.UnitPrice = duLieuMoi.UnitPrice
        sp.Quantity = duLieuMoi.Quantity
        sp.Category = duLieuMoi.Category
        bindingSource.ResetCurrentItem()
        LamMoiNhapLieu()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim sp = TryCast(bindingSource.Current, Product)
        If sp Is Nothing Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa trên lưới.", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ketQua = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm '{sp.ProductName}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ketQua = DialogResult.Yes Then
            _products.Remove(sp)
            bindingSource.ResetBindings(False)
            LamMoiNhapLieu()
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim tuKhoa = txtTimKiem.Text.Trim()
        If String.IsNullOrEmpty(tuKhoa) Then
            bindingSource.DataSource = _products
        Else
            Dim ketQua = _products.Where(Function(p) p.ProductName IsNot Nothing AndAlso
                    p.ProductName.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)).ToList()
            bindingSource.DataSource = ketQua
        End If
        bindingSource.ResetBindings(False)
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex < 0 Then Return

        Dim sp = TryCast(dgvProducts.Rows(e.RowIndex).DataBoundItem, Product)
        If sp Is Nothing Then Return

        txtMaSP.Text = sp.ProductId
        txtTenSP.Text = sp.ProductName
        txtDonGia.Text = sp.UnitPrice.ToString()
        txtSoLuong.Text = sp.Quantity.ToString()
        cboDanhMuc.Text = sp.Category
    End Sub
End Class
