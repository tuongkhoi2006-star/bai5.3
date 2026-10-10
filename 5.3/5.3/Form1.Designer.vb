<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        grpThongTin = New GroupBox()
        lblMaSP = New Label()
        txtMaSP = New TextBox()
        lblTenSP = New Label()
        txtTenSP = New TextBox()
        lblDonGia = New Label()
        txtDonGia = New TextBox()
        lblSoLuong = New Label()
        txtSoLuong = New TextBox()
        lblDanhMuc = New Label()
        cboDanhMuc = New ComboBox()
        grpChucNang = New GroupBox()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        btnTimKiem = New Button()
        txtTimKiem = New TextBox()
        dgvProducts = New DataGridView()
        bindingSource = New BindingSource(components)
        grpThongTin.SuspendLayout()
        grpChucNang.SuspendLayout()
        CType(dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'grpThongTin
        '
        grpThongTin.Controls.Add(lblMaSP)
        grpThongTin.Controls.Add(txtMaSP)
        grpThongTin.Controls.Add(lblTenSP)
        grpThongTin.Controls.Add(txtTenSP)
        grpThongTin.Controls.Add(lblDonGia)
        grpThongTin.Controls.Add(txtDonGia)
        grpThongTin.Controls.Add(lblSoLuong)
        grpThongTin.Controls.Add(txtSoLuong)
        grpThongTin.Controls.Add(lblDanhMuc)
        grpThongTin.Controls.Add(cboDanhMuc)
        grpThongTin.Location = New Point(12, 12)
        grpThongTin.Name = "grpThongTin"
        grpThongTin.Size = New Size(776, 110)
        grpThongTin.TabIndex = 0
        grpThongTin.TabStop = False
        grpThongTin.Text = "Thông tin sản phẩm"
        '
        'lblMaSP
        '
        lblMaSP.AutoSize = True
        lblMaSP.Location = New Point(15, 30)
        lblMaSP.Name = "lblMaSP"
        lblMaSP.Size = New Size(43, 15)
        lblMaSP.TabIndex = 0
        lblMaSP.Text = "Mã SP:"
        '
        'txtMaSP
        '
        txtMaSP.Location = New Point(90, 27)
        txtMaSP.Name = "txtMaSP"
        txtMaSP.Size = New Size(150, 23)
        txtMaSP.TabIndex = 1
        '
        'lblTenSP
        '
        lblTenSP.AutoSize = True
        lblTenSP.Location = New Point(15, 65)
        lblTenSP.Name = "lblTenSP"
        lblTenSP.Size = New Size(44, 15)
        lblTenSP.TabIndex = 2
        lblTenSP.Text = "Tên SP:"
        '
        'txtTenSP
        '
        txtTenSP.Location = New Point(90, 62)
        txtTenSP.Name = "txtTenSP"
        txtTenSP.Size = New Size(280, 23)
        txtTenSP.TabIndex = 3
        '
        'lblDonGia
        '
        lblDonGia.AutoSize = True
        lblDonGia.Location = New Point(280, 30)
        lblDonGia.Name = "lblDonGia"
        lblDonGia.Size = New Size(51, 15)
        lblDonGia.TabIndex = 4
        lblDonGia.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        txtDonGia.Location = New Point(340, 27)
        txtDonGia.Name = "txtDonGia"
        txtDonGia.Size = New Size(150, 23)
        txtDonGia.TabIndex = 5
        '
        'lblSoLuong
        '
        lblSoLuong.AutoSize = True
        lblSoLuong.Location = New Point(530, 30)
        lblSoLuong.Name = "lblSoLuong"
        lblSoLuong.Size = New Size(57, 15)
        lblSoLuong.TabIndex = 6
        lblSoLuong.Text = "Số lượng:"
        '
        'txtSoLuong
        '
        txtSoLuong.Location = New Point(595, 27)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(120, 23)
        txtSoLuong.TabIndex = 7
        '
        'lblDanhMuc
        '
        lblDanhMuc.AutoSize = True
        lblDanhMuc.Location = New Point(410, 65)
        lblDanhMuc.Name = "lblDanhMuc"
        lblDanhMuc.Size = New Size(65, 15)
        lblDanhMuc.TabIndex = 8
        lblDanhMuc.Text = "Danh mục:"
        '
        'cboDanhMuc
        '
        cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDown
        cboDanhMuc.FormattingEnabled = True
        cboDanhMuc.Location = New Point(480, 62)
        cboDanhMuc.Name = "cboDanhMuc"
        cboDanhMuc.Size = New Size(235, 23)
        cboDanhMuc.TabIndex = 9
        '
        'grpChucNang
        '
        grpChucNang.Controls.Add(btnThem)
        grpChucNang.Controls.Add(btnSua)
        grpChucNang.Controls.Add(btnXoa)
        grpChucNang.Controls.Add(txtTimKiem)
        grpChucNang.Controls.Add(btnTimKiem)
        grpChucNang.Location = New Point(12, 128)
        grpChucNang.Name = "grpChucNang"
        grpChucNang.Size = New Size(776, 60)
        grpChucNang.TabIndex = 1
        grpChucNang.TabStop = False
        grpChucNang.Text = "Chức năng"
        '
        'btnThem
        '
        btnThem.Location = New Point(15, 22)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(90, 27)
        btnThem.TabIndex = 0
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        btnSua.Location = New Point(115, 22)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(90, 27)
        btnSua.TabIndex = 1
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        btnXoa.Location = New Point(215, 22)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(90, 27)
        btnXoa.TabIndex = 2
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        txtTimKiem.Location = New Point(430, 24)
        txtTimKiem.Name = "txtTimKiem"
        txtTimKiem.Size = New Size(220, 23)
        txtTimKiem.TabIndex = 3
        '
        'btnTimKiem
        '
        btnTimKiem.Location = New Point(660, 22)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(90, 27)
        btnTimKiem.TabIndex = 4
        btnTimKiem.Text = "Tìm kiếm"
        btnTimKiem.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(12, 194)
        dgvProducts.MultiSelect = False
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(776, 244)
        dgvProducts.TabIndex = 2
        '
        'Form1
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpThongTin)
        Controls.Add(grpChucNang)
        Controls.Add(dgvProducts)
        Name = "Form1"
        Text = "Quản lý danh sách sản phẩm"
        grpThongTin.ResumeLayout(False)
        grpThongTin.PerformLayout()
        grpChucNang.ResumeLayout(False)
        grpChucNang.PerformLayout()
        CType(dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpThongTin As GroupBox
    Friend WithEvents lblMaSP As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents lblTenSP As Label
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents lblDonGia As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents lblSoLuong As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents lblDanhMuc As Label
    Friend WithEvents cboDanhMuc As ComboBox
    Friend WithEvents grpChucNang As GroupBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents bindingSource As BindingSource

End Class
