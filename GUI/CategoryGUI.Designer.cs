namespace BanDienThoai.GUI
{
    partial class CategoryGUI
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
            this.lbl_NameCategory = new System.Windows.Forms.Label();
            this.btn_Can = new BanDienThoai.GUI.VBButton();
            this.btnSua = new BanDienThoai.GUI.VBButton();
            this.btnXoa = new BanDienThoai.GUI.VBButton();
            this.btnThem = new BanDienThoai.GUI.VBButton();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NameCategory
            // 
            this.lbl_NameCategory.AutoSize = true;
            this.lbl_NameCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NameCategory.Location = new System.Drawing.Point(47, 163);
            this.lbl_NameCategory.Name = "lbl_NameCategory";
            this.lbl_NameCategory.Size = new System.Drawing.Size(112, 21);
            this.lbl_NameCategory.TabIndex = 18;
            this.lbl_NameCategory.Text = "Tên Danh Mục";
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
            this.btn_Can.Location = new System.Drawing.Point(204, 352);
            this.btn_Can.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(144, 38);
            this.btn_Can.TabIndex = 27;
            this.btn_Can.Text = "      Cancel";
            this.btn_Can.TextColor = System.Drawing.Color.White;
            this.btn_Can.UseVisualStyleBackColor = false;
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
            this.btnSua.Location = new System.Drawing.Point(31, 352);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 38);
            this.btnSua.TabIndex = 26;
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
            this.btnXoa.Location = new System.Drawing.Point(204, 289);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 38);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "      Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Location = new System.Drawing.Point(31, 289);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 38);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgv_Category
            // 
            this.dgv_Category.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Location = new System.Drawing.Point(383, 128);
            this.dgv_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersWidth = 51;
            this.dgv_Category.RowTemplate.Height = 29;
            this.dgv_Category.Size = new System.Drawing.Size(327, 350);
            this.dgv_Category.TabIndex = 28;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(73, 204);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(227, 23);
            this.txtTenDanhMuc.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(73, 115);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 23);
            this.txtID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // dgvCategory
            // 
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_NameCategory});
            this.dgvCategory.Location = new System.Drawing.Point(383, 128);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowTemplate.Height = 25;
            this.dgvCategory.Size = new System.Drawing.Size(327, 350);
            this.dgvCategory.TabIndex = 32;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // txt_ID
            // 
            this.txt_ID.DataPropertyName = "Id";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.Name = "txt_ID";
            // 
            // txt_NameCategory
            // 
            this.txt_NameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_NameCategory.DataPropertyName = "CategoryName";
            this.txt_NameCategory.HeaderText = "Danh Mục";
            this.txt_NameCategory.Name = "txt_NameCategory";
            // 
            // CategoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(879, 562);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.dgv_Category);
            this.Controls.Add(this.btn_Can);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbl_NameCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryGUI";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_NameCategory;
        private VBButton btn_Can;
        private VBButton btnSua;
        private VBButton btnXoa;
        private VBButton btnThem;
        private DataGridView dgv_Category;
        private TextBox txtTenDanhMuc;
        private TextBox txtID;
        private Label label1;
        private DataGridView dgvCategory;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_NameCategory;
    }
}