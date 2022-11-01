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
    public partial class CategoryGUI : Form
    {
        CategoryBUS categoryBUS = new CategoryBUS();
        public CategoryGUI()
        {
            InitializeComponent();
            GetAll();
        }

        public void GetAll()
        {
            dgvCategory.DataSource = categoryBUS.GetAllCategory();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCategory.CurrentRow.Index;
            txtID.Text = dgvCategory.Rows[i].Cells[0].Value.ToString();
            txtTenDanhMuc.Text = dgvCategory.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDanhMuc.Text.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống các ô", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Category c = new Category();
                c.CategoryName = txtTenDanhMuc.Text.Trim();

                categoryBUS.CreateCategory(c);

                GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Hình như bạn chưa chọn danh mục để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtTenDanhMuc.Text.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống các ô", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Category c = new Category();
                c.Id = int.Parse(txtID.Text.Trim());
                c.CategoryName = txtTenDanhMuc.Text.Trim();

                categoryBUS.UpdateCategory(c);
                GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Hình như bạn chưa chọn danh mục để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                categoryBUS.DeleteCategory(int.Parse(txtID.Text.Trim()));

                GetAll();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
