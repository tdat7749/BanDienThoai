﻿namespace BanDienThoai.GUI
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
            this.dgvSanPham.Location = new System.Drawing.Point(2, 125);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.Size = new System.Drawing.Size(737, 179);
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
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(190, 329);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(86, 31);
            this.btnChon.TabIndex = 32;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(401, 329);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 31);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // _3ChamProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 388);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvSanPham);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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