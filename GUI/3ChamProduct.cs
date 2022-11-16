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
    public partial class _3ChamProduct : Form
    {
        ProductBUS productBUS = new ProductBUS();

        public static string id;
        public static string name;
        public static string price;
        public _3ChamProduct()
        {
            InitializeComponent();
            GetAllProduct();
        }

        public void GetAllProduct()
        {
            dgvSanPham.DataSource = productBUS.GetAllProduct();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            if(i >= 0)
            {
                
                id = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                name = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                price = dgvSanPham.Rows[i].Cells[2].Value.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Hình như bạn chưa chọn sản phẩm");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvSanPham.DataSource = productBUS.GetProductByName(txtSearch.Text.Trim());
            if(dgvSanPham.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllProduct();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllProduct();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
