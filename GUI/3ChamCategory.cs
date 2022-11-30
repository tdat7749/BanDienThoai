using BanDienThoai.BUS;
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
    public partial class _3ChamCategory : Form
    {
        public static string id, name;
        CategoryBUS categoryBUS = new CategoryBUS();

        public _3ChamCategory()
        {
            InitializeComponent();
            GetAllCategory();
        }

        private void GetAllCategory()
        {
            dgvCategory.DataSource = categoryBUS.GetAllCategory();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvCategory.DataSource = categoryBUS.GetCategoryByName(txtSearch.Text.Trim());
            if (dgvCategory.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllCategory();
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllCategory();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgvCategory.CurrentRow.Index;
            if (i >= 0)
            {
                id = dgvCategory.Rows[i].Cells[0].Value.ToString();
                name = dgvCategory.Rows[i].Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hình như bạn chưa chọn danh mục");
            }
        }
    }
}
