namespace BanDienThoai.GUI
{
    partial class _3ChamKhachHang
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
            this.dgv3ChamUser = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3ChamUser
            // 
            this.dgv3ChamUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3ChamUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_FirstName,
            this.txt_LastName,
            this.txt_SoDienThoai,
            this.txt_DiaChi});
            this.dgv3ChamUser.Location = new System.Drawing.Point(88, 126);
            this.dgv3ChamUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv3ChamUser.Name = "dgv3ChamUser";
            this.dgv3ChamUser.ReadOnly = true;
            this.dgv3ChamUser.RowHeadersWidth = 51;
            this.dgv3ChamUser.RowTemplate.Height = 25;
            this.dgv3ChamUser.Size = new System.Drawing.Size(624, 200);
            this.dgv3ChamUser.TabIndex = 14;
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
            // txt_FirstName
            // 
            this.txt_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_FirstName.DataPropertyName = "FirstName";
            this.txt_FirstName.HeaderText = "Họ";
            this.txt_FirstName.MinimumWidth = 6;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.ReadOnly = true;
            // 
            // txt_LastName
            // 
            this.txt_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_LastName.DataPropertyName = "LastName";
            this.txt_LastName.HeaderText = "Tên";
            this.txt_LastName.MinimumWidth = 6;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.DataPropertyName = "PhoneNumber";
            this.txt_SoDienThoai.HeaderText = "Số Điện Thoại";
            this.txt_SoDienThoai.MinimumWidth = 6;
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.ReadOnly = true;
            this.txt_SoDienThoai.Width = 125;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataPropertyName = "Address";
            this.txt_DiaChi.HeaderText = "Địa Chỉ";
            this.txt_DiaChi.MinimumWidth = 6;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Width = 125;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(558, 67);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 33);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 70);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 27);
            this.txtSearch.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(420, 353);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 31);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(270, 353);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(86, 31);
            this.btnChon.TabIndex = 15;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // _3ChamKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv3ChamUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Name = "_3ChamKhachHang";
            this.Text = "_3ChamKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv3ChamUser;
        private Button btnReset;
        private Button button1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnHuy;
        private Button btnChon;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_FirstName;
        private DataGridViewTextBoxColumn txt_LastName;
        private DataGridViewTextBoxColumn txt_SoDienThoai;
        private DataGridViewTextBoxColumn txt_DiaChi;
    }
}