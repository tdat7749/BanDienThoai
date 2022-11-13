namespace BanDienThoai.GUI
{
    partial class _3ChamKhuyenMai
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
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.txt_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_SaleOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(409, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(149, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 23);
            this.txtSearch.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(289, 246);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(157, 246);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_Id,
            this.txt_NameSale,
            this.txt_SaleOff,
            this.txt_TimeStart,
            this.txt_TimeEnd});
            this.dgvKhuyenMai.Location = new System.Drawing.Point(-2, 76);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 25;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(546, 150);
            this.dgvKhuyenMai.TabIndex = 7;
            // 
            // txt_Id
            // 
            this.txt_Id.DataPropertyName = "Id";
            this.txt_Id.HeaderText = "Mã Khuyến Mãi";
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            // 
            // txt_NameSale
            // 
            this.txt_NameSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NameSale.DataPropertyName = "NameSale";
            this.txt_NameSale.HeaderText = "Khuyến Mãi";
            this.txt_NameSale.MinimumWidth = 6;
            this.txt_NameSale.Name = "txt_NameSale";
            this.txt_NameSale.ReadOnly = true;
            // 
            // txt_SaleOff
            // 
            this.txt_SaleOff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_SaleOff.DataPropertyName = "SaleOff";
            this.txt_SaleOff.HeaderText = "Phần Trăm Khuyến Mãi (%)";
            this.txt_SaleOff.MinimumWidth = 6;
            this.txt_SaleOff.Name = "txt_SaleOff";
            this.txt_SaleOff.ReadOnly = true;
            // 
            // txt_TimeStart
            // 
            this.txt_TimeStart.DataPropertyName = "TimeStart";
            this.txt_TimeStart.HeaderText = "Thời Gian Bắt Đầu";
            this.txt_TimeStart.Name = "txt_TimeStart";
            this.txt_TimeStart.ReadOnly = true;
            // 
            // txt_TimeEnd
            // 
            this.txt_TimeEnd.DataPropertyName = "TimeEnd";
            this.txt_TimeEnd.HeaderText = "Thời Gian Kết Thúc";
            this.txt_TimeEnd.Name = "txt_TimeEnd";
            this.txt_TimeEnd.ReadOnly = true;
            // 
            // _3ChamKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 273);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Name = "_3ChamKhuyenMai";
            this.Text = "_3ChamKhuyenMai";
            this.Load += new System.EventHandler(this._3ChamKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReset;
        private Button button1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnHuy;
        private Button btnChon;
        private DataGridView dgvKhuyenMai;
        private DataGridViewTextBoxColumn txt_Id;
        private DataGridViewTextBoxColumn txt_NameSale;
        private DataGridViewTextBoxColumn txt_SaleOff;
        private DataGridViewTextBoxColumn txt_TimeStart;
        private DataGridViewTextBoxColumn txt_TimeEnd;
    }
}