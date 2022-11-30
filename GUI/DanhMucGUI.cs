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
    public partial class DanhMucGUI : Form
    {
        CategoryBUS categoryBUS = new CategoryBUS();

        public DanhMucGUI()
        {
            InitializeComponent();
            groupBox1.BackColor = SetTransparency(180, Color.White);
            groupBox2.BackColor = SetTransparency(180, Color.White);
            GetAllDanhMuc();
        }

        static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);

        }

        public void GetAllDanhMuc()
        {
            dgvDanhMuc.DataSource = categoryBUS.GetAllCategory();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhMuc.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaDanhMuc.Text = dgvDanhMuc.Rows[i].Cells[0].Value.ToString();
                txtTenDanhMuc.Text = dgvDanhMuc.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là thêm danh mục này chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Category category = new Category();
                category.CategoryName = txtTenDanhMuc.Text.Trim();

                categoryBUS.CreateCategory(category);
                MessageBox.Show("Thêm danh mục thành công", "Thành Công", MessageBoxButtons.OK);
                GetAllDanhMuc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaDanhMuc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn danh mục để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là sửa danh mục này chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Category category = new Category();
                category.Id = int.Parse(txtMaDanhMuc.Text.Trim());
                category.CategoryName = txtTenDanhMuc.Text.Trim();

                categoryBUS.UpdateCategory(category);
                MessageBox.Show("Sửa danh mục thành công", "Thành Công", MessageBoxButtons.OK);
                GetAllDanhMuc();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDanhMuc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là xóa danh mục này chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Category category = new Category();
                category.Id = int.Parse(txtMaDanhMuc.Text.Trim());

                categoryBUS.DeleteCategory(category.Id);
                MessageBox.Show("Xóa danh mục thành công", "Thành Công", MessageBoxButtons.OK);
                GetAllDanhMuc();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";
            txtSearch.Text = "";
            GetAllDanhMuc();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục muốn tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvDanhMuc.DataSource = categoryBUS.GetCategoryByName(txtSearch.Text.Trim());
            if (dgvDanhMuc.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllDanhMuc();
                return;
            }
        }
    }
}
