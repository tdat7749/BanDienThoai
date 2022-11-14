namespace BanDienThoai.GUI
{
    partial class HoaDonGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbLuaChon = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txt_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.txt_BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Totall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaHoaDonCT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTu = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnLocNgay = new System.Windows.Forms.Button();
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLocGia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(38, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(104, 92);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(113, 25);
            this.dtpNgayLap.TabIndex = 16;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.Location = new System.Drawing.Point(327, 94);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(113, 23);
            this.txtTongTien.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(232, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng Tiền (VND)";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKhachHang.Location = new System.Drawing.Point(327, 63);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(113, 23);
            this.txtKhachHang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(232, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khách Hàng";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhanVien.Location = new System.Drawing.Point(327, 32);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(113, 23);
            this.txtNhanVien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(232, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Lập";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaKhachHang.Location = new System.Drawing.Point(104, 63);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(113, 23);
            this.txtMaKhachHang.TabIndex = 3;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoaDon.Location = new System.Drawing.Point(104, 32);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(113, 23);
            this.txtMaHoaDon.TabIndex = 1;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cbbLuaChon);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(142, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 73);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Hóa Đơn";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.Location = new System.Drawing.Point(607, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 32);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(406, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 25);
            this.txtSearch.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(324, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Từ Khóa";
            // 
            // cbbLuaChon
            // 
            this.cbbLuaChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbLuaChon.FormattingEnabled = true;
            this.cbbLuaChon.Items.AddRange(new object[] {
            "Tất Cả",
            "Mã Khách Hàng",
            "Tên Khách Hàng"});
            this.cbbLuaChon.Location = new System.Drawing.Point(136, 31);
            this.cbbLuaChon.Name = "cbbLuaChon";
            this.cbbLuaChon.Size = new System.Drawing.Size(164, 25);
            this.cbbLuaChon.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(43, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Lựa Chọn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(38, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 225);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_Id,
            this.txt_NhanVien,
            this.txt_MaKhachHang,
            this.txt_TenKhachHang,
            this.txt_NgayLap,
            this.txt_TongTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 22);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowTemplate.Height = 25;
            this.dgvHoaDon.Size = new System.Drawing.Size(446, 203);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // txt_Id
            // 
            this.txt_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Id.DataPropertyName = "Id";
            this.txt_Id.HeaderText = "Mã Hóa Đơn";
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NhanVien.DataPropertyName = "StaffFullName";
            this.txt_NhanVien.HeaderText = "Nhân Viên";
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.ReadOnly = true;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_MaKhachHang.DataPropertyName = "UserId";
            this.txt_MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.ReadOnly = true;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_TenKhachHang.DataPropertyName = "FullName";
            this.txt_TenKhachHang.HeaderText = "Khách Hàng";
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NgayLap.DataPropertyName = "DateCreate";
            this.txt_NgayLap.HeaderText = "Ngày Lập";
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.ReadOnly = true;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_TongTien.DataPropertyName = "Total";
            this.txt_TongTien.HeaderText = "Tổng Tiền (VND)";
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvChiTietHoaDon);
            this.groupBox5.Location = new System.Drawing.Point(503, 387);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 225);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_BillId,
            this.txt_ProductId,
            this.txt_NameProduct,
            this.txt_Price,
            this.txt_Amount,
            this.txt_Totall});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 22);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowTemplate.Height = 25;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(446, 203);
            this.dgvChiTietHoaDon.TabIndex = 1;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // txt_BillId
            // 
            this.txt_BillId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_BillId.DataPropertyName = "BillId";
            this.txt_BillId.HeaderText = "Mã Hóa Đơn";
            this.txt_BillId.Name = "txt_BillId";
            this.txt_BillId.ReadOnly = true;
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_ProductId.DataPropertyName = "ProductId";
            this.txt_ProductId.HeaderText = "Mã Sản Phẩm";
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.ReadOnly = true;
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NameProduct.DataPropertyName = "NameProduct";
            this.txt_NameProduct.HeaderText = "Tên Sản Phẩm";
            this.txt_NameProduct.Name = "txt_NameProduct";
            this.txt_NameProduct.ReadOnly = true;
            // 
            // txt_Price
            // 
            this.txt_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Price.DataPropertyName = "Price";
            this.txt_Price.HeaderText = "Đơn Giá";
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.ReadOnly = true;
            // 
            // txt_Amount
            // 
            this.txt_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Amount.DataPropertyName = "Amount";
            this.txt_Amount.HeaderText = "Số Lượng";
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            // 
            // txt_Totall
            // 
            this.txt_Totall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Totall.DataPropertyName = "Total";
            this.txt_Totall.HeaderText = "Thành Tiền";
            this.txt_Totall.Name = "txt_Totall";
            this.txt_Totall.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaSanPham);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMaHoaDonCT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(503, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 147);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Hóa Đơn";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtThanhTien.Location = new System.Drawing.Point(327, 94);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(113, 23);
            this.txtThanhTien.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(232, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thành Tiền (VND)";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDonGia.Location = new System.Drawing.Point(327, 63);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(113, 23);
            this.txtDonGia.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(232, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Đơn Giá (VND)";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSanPham.Location = new System.Drawing.Point(327, 32);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(113, 23);
            this.txtMaSanPham.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(232, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Sản Phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoLuong.Location = new System.Drawing.Point(104, 94);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(113, 23);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số Lượng";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenSanPham.Location = new System.Drawing.Point(104, 63);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(113, 23);
            this.txtTenSanPham.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Sản Phẩm";
            // 
            // txtMaHoaDonCT
            // 
            this.txtMaHoaDonCT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoaDonCT.Location = new System.Drawing.Point(104, 32);
            this.txtMaHoaDonCT.Name = "txtMaHoaDonCT";
            this.txtMaHoaDonCT.Size = new System.Drawing.Size(113, 23);
            this.txtMaHoaDonCT.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã Hóa Đơn";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpNgayDen);
            this.groupBox6.Controls.Add(this.dtpNgayTu);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.btnLocNgay);
            this.groupBox6.Controls.Add(this.txtGiaDen);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtGiaTu);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.btnLocGia);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(142, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(688, 99);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lọc Hóa Đơn";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(415, 64);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(120, 25);
            this.dtpNgayDen.TabIndex = 16;
            // 
            // dtpNgayTu
            // 
            this.dtpNgayTu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTu.Location = new System.Drawing.Point(208, 64);
            this.dtpNgayTu.Name = "dtpNgayTu";
            this.dtpNgayTu.Size = new System.Drawing.Size(120, 25);
            this.dtpNgayTu.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(361, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 19);
            this.label18.TabIndex = 14;
            this.label18.Text = "Đến";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(170, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 19);
            this.label19.TabIndex = 12;
            this.label19.Text = "Từ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(81, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 19);
            this.label20.TabIndex = 11;
            this.label20.Text = "Theo Ngày";
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLocNgay.Location = new System.Drawing.Point(569, 64);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.Size = new System.Drawing.Size(75, 27);
            this.btnLocNgay.TabIndex = 9;
            this.btnLocNgay.Text = "Lọc";
            this.btnLocNgay.UseVisualStyleBackColor = true;
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaDen.Location = new System.Drawing.Point(415, 33);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(120, 25);
            this.txtGiaDen.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(361, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 19);
            this.label17.TabIndex = 8;
            this.label17.Text = "Đến";
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTu.Location = new System.Drawing.Point(208, 33);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(120, 25);
            this.txtGiaTu.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(170, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "Từ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(81, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Theo Giá : ";
            // 
            // btnLocGia
            // 
            this.btnLocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLocGia.Location = new System.Drawing.Point(569, 31);
            this.btnLocGia.Name = "btnLocGia";
            this.btnLocGia.Size = new System.Drawing.Size(75, 27);
            this.btnLocGia.TabIndex = 4;
            this.btnLocGia.Text = "Lọc";
            this.btnLocGia.UseVisualStyleBackColor = true;
            this.btnLocGia.Click += new System.EventHandler(this.btnLocGia_Click);
            // 
            // HoaDonGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 624);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDonGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HoaDonGUI";
            this.Load += new System.EventHandler(this.HoaDonGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTongTien;
        private Label label6;
        private TextBox txtKhachHang;
        private Label label5;
        private TextBox txtNhanVien;
        private Label label4;
        private Label label3;
        private TextBox txtMaKhachHang;
        private Label label2;
        private TextBox txtMaHoaDon;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvHoaDon;
        private GroupBox groupBox5;
        private DataGridView dgvChiTietHoaDon;
        private DataGridViewTextBoxColumn txt_BillId;
        private DataGridViewTextBoxColumn txt_ProductId;
        private DataGridViewTextBoxColumn txt_NameProduct;
        private DataGridViewTextBoxColumn txt_Price;
        private DataGridViewTextBoxColumn txt_Amount;
        private DataGridViewTextBoxColumn txt_Totall;
        private GroupBox groupBox2;
        private TextBox txtThanhTien;
        private Label label7;
        private TextBox txtDonGia;
        private Label label8;
        private TextBox txtMaSanPham;
        private Label label9;
        private TextBox txtSoLuong;
        private Label label10;
        private TextBox txtTenSanPham;
        private Label label11;
        private TextBox txtMaHoaDonCT;
        private Label label12;
        private DateTimePicker dtpNgayLap;
        private DataGridViewTextBoxColumn txt_Id;
        private DataGridViewTextBoxColumn txt_NhanVien;
        private DataGridViewTextBoxColumn txt_MaKhachHang;
        private DataGridViewTextBoxColumn txt_TenKhachHang;
        private DataGridViewTextBoxColumn txt_NgayLap;
        private DataGridViewTextBoxColumn txt_TongTien;
        private Button btnTimKiem;
        private TextBox txtSearch;
        private Label label14;
        private ComboBox cbbLuaChon;
        private Label label13;
        private GroupBox groupBox6;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button btnLocNgay;
        private TextBox txtGiaDen;
        private Label label17;
        private TextBox txtGiaTu;
        private Label label16;
        private Label label15;
        private Button btnLocGia;
        private DateTimePicker dtpNgayDen;
        private DateTimePicker dtpNgayTu;
    }
}