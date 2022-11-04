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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
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
            this.txtSoLuong});
            this.dgvSanPham.Location = new System.Drawing.Point(2, 94);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.Size = new System.Drawing.Size(645, 134);
            this.dgvSanPham.TabIndex = 31;
            // 
            // txt_ID
            // 
            this.txt_ID.DataPropertyName = "Id";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.Name = "txt_ID";
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.DataPropertyName = "NameProduct";
            this.txt_NameProduct.HeaderText = "Tên Sản Phẩm";
            this.txt_NameProduct.Name = "txt_NameProduct";
            // 
            // txt_DanhMuc
            // 
            this.txt_DanhMuc.DataPropertyName = "CategoryName";
            this.txt_DanhMuc.HeaderText = "Danh Mục";
            this.txt_DanhMuc.Name = "txt_DanhMuc";
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.DataPropertyName = "Price";
            this.txt_GiaTien.HeaderText = "Giá";
            this.txt_GiaTien.Name = "txt_GiaTien";
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.DataPropertyName = "Description";
            this.txt_MoTa.HeaderText = "Mô Tả";
            this.txt_MoTa.Name = "txt_MoTa";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataPropertyName = "Stock";
            this.txtSoLuong.HeaderText = "Số Lượng";
            this.txtSoLuong.Name = "txtSoLuong";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(166, 247);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 32;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(351, 247);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // _3ChamProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 291);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "_3ChamProduct";
            this.Text = "_3ChamProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSanPham;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_NameProduct;
        private DataGridViewTextBoxColumn txt_DanhMuc;
        private DataGridViewTextBoxColumn txt_GiaTien;
        private DataGridViewTextBoxColumn txt_MoTa;
        private DataGridViewTextBoxColumn txtSoLuong;
        private Button btnChon;
        private Button btnHuy;
    }
}