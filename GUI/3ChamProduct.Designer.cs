namespace BanDienThoai.GUI
{
    partial class _3ChamProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3ChamProduct));
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_NameProduct,
            this.txt_DanhMuc,
            this.txt_GiaTien,
            this.txt_MoTa,
            this.txtSoLuong,
            this.Image,
            this.Id1,
            this.Column1});
            this.dgvSanPham.Location = new System.Drawing.Point(2, 94);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.Size = new System.Drawing.Size(645, 134);
            this.dgvSanPham.TabIndex = 31;
            // 
            // txt_ID
            // 
            this.txt_ID.DataPropertyName = "Id";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.MinimumWidth = 6;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Width = 125;
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.DataPropertyName = "NameProduct";
            this.txt_NameProduct.HeaderText = "Tên Sản Phẩm";
            this.txt_NameProduct.MinimumWidth = 6;
            this.txt_NameProduct.Name = "txt_NameProduct";
            this.txt_NameProduct.ReadOnly = true;
            this.txt_NameProduct.Width = 125;
            // 
            // txt_DanhMuc
            // 
            this.txt_DanhMuc.DataPropertyName = "CategoryName";
            this.txt_DanhMuc.HeaderText = "Danh Mục";
            this.txt_DanhMuc.MinimumWidth = 6;
            this.txt_DanhMuc.Name = "txt_DanhMuc";
            this.txt_DanhMuc.ReadOnly = true;
            this.txt_DanhMuc.Width = 125;
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.DataPropertyName = "Price";
            this.txt_GiaTien.HeaderText = "Giá";
            this.txt_GiaTien.MinimumWidth = 6;
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.ReadOnly = true;
            this.txt_GiaTien.Width = 125;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.DataPropertyName = "Description";
            this.txt_MoTa.HeaderText = "Mô Tả";
            this.txt_MoTa.MinimumWidth = 6;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.ReadOnly = true;
            this.txt_MoTa.Width = 125;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataPropertyName = "Stock";
            this.txtSoLuong.HeaderText = "Số Lượng";
            this.txtSoLuong.MinimumWidth = 6;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Column1";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            this.Image.Width = 125;
            // 
            // Id1
            // 
            this.Id1.DataPropertyName = "Id1";
            this.Id1.HeaderText = "Column1";
            this.Id1.MinimumWidth = 6;
            this.Id1.Name = "Id1";
            this.Id1.ReadOnly = true;
            this.Id1.Visible = false;
            this.Id1.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Status";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // btnChon
            // 
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(242, 247);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(66, 29);
            this.btnChon.TabIndex = 32;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(347, 247);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 29);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(176, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(177, 23);
            this.txtSearch.TabIndex = 35;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(384, 49);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 29);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(500, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "Reset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _3ChamProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "_3ChamProduct";
            this.Text = "Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSanPham;
        private Button btnChon;
        private Button btnHuy;
        private Label label1;
        private TextBox txtSearch;
        private Button btnTimKiem;
        private Button button1;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_NameProduct;
        private DataGridViewTextBoxColumn txt_DanhMuc;
        private DataGridViewTextBoxColumn txt_GiaTien;
        private DataGridViewTextBoxColumn txt_MoTa;
        private DataGridViewTextBoxColumn txtSoLuong;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn Id1;
        private DataGridViewTextBoxColumn Column1;
    }
}