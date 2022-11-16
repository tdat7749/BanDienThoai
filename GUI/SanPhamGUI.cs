using BanDienThoai.BUS;
using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDienThoai.GUI
{
    public partial class SanPhamGUI : Form
    {
        ProductBUS productBUS = new ProductBUS();
        string urlImg,urlCopy;
        string url = Application.StartupPath;
        public SanPhamGUI()
        {
            InitializeComponent();
            GetAllProDuct();
            
        }
        public void GetAllProDuct()
        {
            dgvSanPham.DataSource = productBUS.GetAllProduct();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string item = cbbLuaChon.GetItemText(cbbLuaChon.SelectedItem);
            string name = txtSearch.Text.Trim();

            if (item == "Tên Sản Phẩm")
            {
                dgvSanPham.DataSource = productBUS.GetProductByName(name);
            }
            else if (item == "Hãng")
            {
                dgvSanPham.DataSource = productBUS.GetProductByCategory(name);
            }
            else if (item == "Tất Cả")
            {
                dgvSanPham.DataSource = productBUS.GetAllProduct();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text.Trim() == "" ||
                txtDonGia.Text.Trim() == "" ||
                txtMoTa.Text.Trim() == "" ||
                txtMaHang.Text.Trim() == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtMaSanPham.Text != "")
            {
                MessageBox.Show("Sản phẩm đã có trong dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.Copy(urlCopy, url + urlImg);
            

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là thêm sản phẩm này chứ ?", "Sản Phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Product product = new Product();
                product.Name = txtTenSanPham.Text.Trim();
                product.Description = txtMoTa.Text.Trim();
                product.Image = urlImg;
                product.Price = decimal.Parse(txtDonGia.Text.Trim());
                product.CategoryID = 1;

                productBUS.CreateProduct(product);
                MessageBox.Show("Thêm sản phẩm thành công !!", "Nhân Viên", MessageBoxButtons.OK);
                GetAllProDuct();

                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtTenSanPham.Text == "" || txtDonGia.Text == "" || txtMoTa.Text == "" || txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product();
            product.Id = int.Parse(txtMaSanPham.Text);
            product.Name = txtTenSanPham.Text.Trim();
            product.Description = txtMoTa.Text.Trim();
            product.Image = urlImg;
            product.Price = decimal.Parse(txtDonGia.Text.Trim());
            product.CategoryID = int.Parse(txtMaHang.Text);

            productBUS.UpdateProduct(product);
            MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
            GetAllProDuct();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này chứ ?", "Sản Phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                productBUS.DeleteProduct(int.Parse(txtMaSanPham.Text.Trim()));
            }
                
            MessageBox.Show("Xóa thành công", "Thành Công", MessageBoxButtons.OK);
            GetAllProDuct();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Image Files(*.PNG;*.JPG;*.JFIF)|*.PNG;*.JPG;*.JFIF",
                Title = "Select Image"
            };
            //openFileDialog1.InitialDirectory = url;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    urlImg = openFileDialog1.FileName;
                    urlCopy = urlImg;
                    Bitmap bm = new Bitmap(urlImg);
                    pbSanPham.Image = bm;
                    pbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    urlImg = Path.GetFileName(urlImg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            if (i >= 0 && dgvSanPham.Rows[i].Cells[0].Value.ToString() != "")
            {
                urlImg = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                Bitmap bm = new Bitmap(url + urlImg);
                pbSanPham.Image = bm;
                txtMaSanPham.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                txtSoLuongConLai.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                txtMoTa.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                txtTenHang.Text = dgvSanPham.Rows[i].Cells[6].Value.ToString();
                txtMaHang.Text = dgvSanPham.Rows[i].Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3ChamCategory form = new _3ChamCategory();
            form.ShowDialog();
            txtMaHang.Text = _3ChamCategory.id;
            txtTenHang.Text = _3ChamCategory.name;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSanPham.Text = ""; txtTenSanPham.Text = "";
            txtDonGia.Text = "";
            txtMaHang.Text = "";
            txtMoTa.Text = "";
            txtSoLuongConLai.Text = "";
            txtTenHang.Text = "";
            pbSanPham.Image = null;
            pbSanPham.Invalidate();
        }

        private void SanPhamGUI_Load(object sender, EventArgs e)
        {
            url = Directory.GetParent(url).Parent.Parent.Parent.FullName;
            url += @"\imgProduct\pictureC#\";
            pbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
