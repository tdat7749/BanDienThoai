namespace BanDienThoai.GUI
{
    partial class SupplierGUI
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
            this.lbl_NameSupplier = new System.Windows.Forms.Label();
            this.lbl_AddressSupplier = new System.Windows.Forms.Label();
            this.btnThem = new BanDienThoai.GUI.VBButton();
            this.btnSua = new BanDienThoai.GUI.VBButton();
            this.btnXoa = new BanDienThoai.GUI.VBButton();
            this.btn_Can = new BanDienThoai.GUI.VBButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_AddressSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNameSupplier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NameSupplier
            // 
            this.lbl_NameSupplier.AutoSize = true;
            this.lbl_NameSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NameSupplier.Location = new System.Drawing.Point(38, 118);
            this.lbl_NameSupplier.Name = "lbl_NameSupplier";
            this.lbl_NameSupplier.Size = new System.Drawing.Size(142, 21);
            this.lbl_NameSupplier.TabIndex = 0;
            this.lbl_NameSupplier.Text = "Tên Nhà Cung Cấp";
            // 
            // lbl_AddressSupplier
            // 
            this.lbl_AddressSupplier.AutoSize = true;
            this.lbl_AddressSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AddressSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AddressSupplier.Location = new System.Drawing.Point(38, 208);
            this.lbl_AddressSupplier.Name = "lbl_AddressSupplier";
            this.lbl_AddressSupplier.Size = new System.Drawing.Size(60, 21);
            this.lbl_AddressSupplier.TabIndex = 1;
            this.lbl_AddressSupplier.Text = "Địa Chỉ";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Black;
            this.btnThem.BackgroundColor = System.Drawing.Color.Black;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::BanDienThoai.Properties.Resources._717px_Japanese_Crest_janome_svg_removebg_preview__1_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(40, 371);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 38);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Black;
            this.btnSua.BackgroundColor = System.Drawing.Color.Black;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::BanDienThoai.Properties.Resources._717px_Japanese_Crest_janome_svg_removebg_preview__1_;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(220, 371);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "      Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Black;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Black;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::BanDienThoai.Properties.Resources._717px_Japanese_Crest_janome_svg_removebg_preview__1_;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(40, 425);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 38);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "      Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Can
            // 
            this.btn_Can.BackColor = System.Drawing.Color.Black;
            this.btn_Can.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Can.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Can.BorderRadius = 20;
            this.btn_Can.BorderSize = 0;
            this.btn_Can.FlatAppearance.BorderSize = 0;
            this.btn_Can.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Can.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Can.ForeColor = System.Drawing.Color.White;
            this.btn_Can.Image = global::BanDienThoai.Properties.Resources._717px_Japanese_Crest_janome_svg_removebg_preview__1_;
            this.btn_Can.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Can.Location = new System.Drawing.Point(220, 425);
            this.btn_Can.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(144, 38);
            this.btn_Can.TabIndex = 7;
            this.btn_Can.Text = "      Cancel";
            this.btn_Can.TextColor = System.Drawing.Color.White;
            this.btn_Can.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(371, 342);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(59, 246);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 106);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_NameSupplier,
            this.txt_AddressSupplier});
            this.dgvSupplier.Location = new System.Drawing.Point(385, 78);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowTemplate.Height = 25;
            this.dgvSupplier.Size = new System.Drawing.Size(371, 342);
            this.dgvSupplier.TabIndex = 10;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellContentClick);
            // 
            // txt_ID
            // 
            this.txt_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_ID.DataPropertyName = "Id";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.Name = "txt_ID";
            // 
            // txt_NameSupplier
            // 
            this.txt_NameSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NameSupplier.DataPropertyName = "NameSupplier";
            this.txt_NameSupplier.HeaderText = "Nhà Cung Cấp";
            this.txt_NameSupplier.Name = "txt_NameSupplier";
            // 
            // txt_AddressSupplier
            // 
            this.txt_AddressSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_AddressSupplier.DataPropertyName = "AddressSupplier";
            this.txt_AddressSupplier.HeaderText = "Địa Chỉ";
            this.txt_AddressSupplier.Name = "txt_AddressSupplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(59, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(262, 23);
            this.txtID.TabIndex = 13;
            // 
            // txtNameSupplier
            // 
            this.txtNameSupplier.Location = new System.Drawing.Point(59, 164);
            this.txtNameSupplier.Name = "txtNameSupplier";
            this.txtNameSupplier.Size = new System.Drawing.Size(262, 23);
            this.txtNameSupplier.TabIndex = 14;
            // 
            // SupplierGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(812, 515);
            this.Controls.Add(this.txtNameSupplier);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Can);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbl_AddressSupplier);
            this.Controls.Add(this.lbl_NameSupplier);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SupplierGUI";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_NameSupplier;
        private Label lbl_AddressSupplier;
        private VBButton btnThem;
        private VBButton btnSua;
        private VBButton btnXoa;
        private VBButton btn_Can;
        private DataGridView dataGridView1;
        private RichTextBox txtAddress;
        private DataGridView dgvSupplier;
        private Label label1;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_NameSupplier;
        private DataGridViewTextBoxColumn txt_AddressSupplier;
        private TextBox txtID;
        private TextBox txtNameSupplier;
    }
}