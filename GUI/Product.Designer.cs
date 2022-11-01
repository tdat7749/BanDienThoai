namespace BanDienThoai.GUI
{
    partial class Product
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
            this.txt_NameSale = new BanDienThoai.GUI.CustomTextBox();
            this.lbl_NameProduct = new System.Windows.Forms.Label();
            this.txt_Description = new BanDienThoai.GUI.CustomTextBox();
            this.lbl_Despcription = new System.Windows.Forms.Label();
            this.txt_CategoryID = new BanDienThoai.GUI.CustomTextBox();
            this.lbl_CategoryID = new System.Windows.Forms.Label();
            this.customTextBox3 = new BanDienThoai.GUI.CustomTextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Stock = new BanDienThoai.GUI.CustomTextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.btn_Can = new BanDienThoai.GUI.VBButton();
            this.btnSua = new BanDienThoai.GUI.VBButton();
            this.btnXoa = new BanDienThoai.GUI.VBButton();
            this.btnThem = new BanDienThoai.GUI.VBButton();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NameSale
            // 
            this.txt_NameSale.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_NameSale.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_NameSale.BorderSize = 3;
            this.txt_NameSale.Location = new System.Drawing.Point(53, 74);
            this.txt_NameSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameSale.Multiline = false;
            this.txt_NameSale.Name = "txt_NameSale";
            this.txt_NameSale.PasswordChar = false;
            this.txt_NameSale.Size = new System.Drawing.Size(262, 23);
            this.txt_NameSale.TabIndex = 17;
            this.txt_NameSale.Texts = "";
            this.txt_NameSale.UnderlinedStyle = false;
            // 
            // lbl_NameProduct
            // 
            this.lbl_NameProduct.AutoSize = true;
            this.lbl_NameProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NameProduct.Location = new System.Drawing.Point(33, 40);
            this.lbl_NameProduct.Name = "lbl_NameProduct";
            this.lbl_NameProduct.Size = new System.Drawing.Size(109, 21);
            this.lbl_NameProduct.TabIndex = 16;
            this.lbl_NameProduct.Text = "Tên Sản Phẩm";
            // 
            // txt_Description
            // 
            this.txt_Description.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Description.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Description.BorderSize = 3;
            this.txt_Description.Location = new System.Drawing.Point(53, 148);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Description.Multiline = false;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PasswordChar = false;
            this.txt_Description.Size = new System.Drawing.Size(262, 23);
            this.txt_Description.TabIndex = 19;
            this.txt_Description.Texts = "";
            this.txt_Description.UnderlinedStyle = false;
            // 
            // lbl_Despcription
            // 
            this.lbl_Despcription.AutoSize = true;
            this.lbl_Despcription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Despcription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Despcription.Location = new System.Drawing.Point(33, 117);
            this.lbl_Despcription.Name = "lbl_Despcription";
            this.lbl_Despcription.Size = new System.Drawing.Size(56, 21);
            this.lbl_Despcription.TabIndex = 18;
            this.lbl_Despcription.Text = "Mô Tả";
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_CategoryID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_CategoryID.BorderSize = 3;
            this.txt_CategoryID.Location = new System.Drawing.Point(53, 228);
            this.txt_CategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CategoryID.Multiline = false;
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.PasswordChar = false;
            this.txt_CategoryID.Size = new System.Drawing.Size(262, 23);
            this.txt_CategoryID.TabIndex = 21;
            this.txt_CategoryID.Texts = "";
            this.txt_CategoryID.UnderlinedStyle = false;
            // 
            // lbl_CategoryID
            // 
            this.lbl_CategoryID.AutoSize = true;
            this.lbl_CategoryID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CategoryID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CategoryID.Location = new System.Drawing.Point(29, 193);
            this.lbl_CategoryID.Name = "lbl_CategoryID";
            this.lbl_CategoryID.Size = new System.Drawing.Size(83, 21);
            this.lbl_CategoryID.TabIndex = 20;
            this.lbl_CategoryID.Text = "Danh Mục";
            // 
            // customTextBox3
            // 
            this.customTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox3.BorderSize = 3;
            this.customTextBox3.Location = new System.Drawing.Point(53, 311);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.Size = new System.Drawing.Size(262, 23);
            this.customTextBox3.TabIndex = 23;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Price.Location = new System.Drawing.Point(33, 272);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(68, 21);
            this.lbl_Price.TabIndex = 22;
            this.lbl_Price.Text = "Giá Tiền";
            // 
            // txt_Stock
            // 
            this.txt_Stock.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Stock.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Stock.BorderSize = 3;
            this.txt_Stock.Location = new System.Drawing.Point(489, 74);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stock.Multiline = false;
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.PasswordChar = false;
            this.txt_Stock.Size = new System.Drawing.Size(262, 23);
            this.txt_Stock.TabIndex = 25;
            this.txt_Stock.Texts = "";
            this.txt_Stock.UnderlinedStyle = false;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Stock.Location = new System.Drawing.Point(469, 40);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(80, 21);
            this.lbl_Stock.TabIndex = 24;
            this.lbl_Stock.Text = "Số Lượng";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Image.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Image.Location = new System.Drawing.Point(469, 117);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(77, 21);
            this.lbl_Image.TabIndex = 26;
            this.lbl_Image.Text = "Hình Ảnh";
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.BackgroundImage = global::BanDienThoai.Properties.Resources.add__1_;
            this.pb_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Image.Location = new System.Drawing.Point(489, 148);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(309, 159);
            this.pb_Image.TabIndex = 27;
            this.pb_Image.TabStop = false;
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
            this.btn_Can.Location = new System.Drawing.Point(654, 376);
            this.btn_Can.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(144, 38);
            this.btn_Can.TabIndex = 31;
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
            this.btnSua.Location = new System.Drawing.Point(442, 376);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 38);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "   Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
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
            this.btnXoa.Location = new System.Drawing.Point(237, 376);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 38);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
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
            this.btnThem.Location = new System.Drawing.Point(42, 376);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 38);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "   Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dgv_Product
            // 
            this.dgv_Product.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(53, 430);
            this.dgv_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 29;
            this.dgv_Product.Size = new System.Drawing.Size(745, 121);
            this.dgv_Product.TabIndex = 32;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(879, 562);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.btn_Can);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.txt_CategoryID);
            this.Controls.Add(this.lbl_CategoryID);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_Despcription);
            this.Controls.Add(this.txt_NameSale);
            this.Controls.Add(this.lbl_NameProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox txt_NameSale;
        private Label lbl_NameProduct;
        private CustomTextBox txt_Description;
        private Label lbl_Despcription;
        private CustomTextBox txt_CategoryID;
        private Label lbl_CategoryID;
        private CustomTextBox customTextBox3;
        private Label lbl_Price;
        private CustomTextBox txt_Stock;
        private Label lbl_Stock;
        private Label lbl_Image;
        private PictureBox pb_Image;
        private VBButton btn_Can;
        private VBButton btnSua;
        private VBButton btnXoa;
        private VBButton btnThem;
        private DataGridView dgv_Product;
    }
}