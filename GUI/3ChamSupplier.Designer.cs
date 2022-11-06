namespace BanDienThoai.GUI
{
    partial class _3ChamSupplier
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
            this.dgv3ChamSupplier = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_AddressSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3ChamSupplier
            // 
            this.dgv3ChamSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3ChamSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_NameSupplier,
            this.txt_AddressSupplier});
            this.dgv3ChamSupplier.Location = new System.Drawing.Point(-1, 112);
            this.dgv3ChamSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv3ChamSupplier.Name = "dgv3ChamSupplier";
            this.dgv3ChamSupplier.ReadOnly = true;
            this.dgv3ChamSupplier.RowHeadersWidth = 51;
            this.dgv3ChamSupplier.RowTemplate.Height = 25;
            this.dgv3ChamSupplier.Size = new System.Drawing.Size(624, 200);
            this.dgv3ChamSupplier.TabIndex = 0;
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
            // txt_NameSupplier
            // 
            this.txt_NameSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NameSupplier.DataPropertyName = "NameSupplier";
            this.txt_NameSupplier.HeaderText = "Nhà Cung Cấp";
            this.txt_NameSupplier.MinimumWidth = 6;
            this.txt_NameSupplier.Name = "txt_NameSupplier";
            this.txt_NameSupplier.ReadOnly = true;
            // 
            // txt_AddressSupplier
            // 
            this.txt_AddressSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_AddressSupplier.DataPropertyName = "AddressSupplier";
            this.txt_AddressSupplier.HeaderText = "Địa Chỉ";
            this.txt_AddressSupplier.MinimumWidth = 6;
            this.txt_AddressSupplier.Name = "txt_AddressSupplier";
            this.txt_AddressSupplier.ReadOnly = true;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(181, 339);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(86, 31);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(331, 339);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 31);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // _3ChamSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 388);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgv3ChamSupplier);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_3ChamSupplier";
            this.Text = "_3ChamSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv3ChamSupplier;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_NameSupplier;
        private DataGridViewTextBoxColumn txt_AddressSupplier;
        private Button btnChon;
        private Button btnHuy;
    }
}