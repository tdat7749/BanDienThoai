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
    public partial class _3ChamKhuyenMai : Form
    {
        public static string SaleOff;
        public static DateTime TimeStart;
        public static DateTime TimeEnd;

        SalesBUS saleBUS = new SalesBUS();
        
        public _3ChamKhuyenMai()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgvKhuyenMai.CurrentRow.Index;

            if (i >= 0)
            {
                TimeStart = (DateTime)dgvKhuyenMai.Rows[i].Cells[2].Value;
                TimeEnd = (DateTime)dgvKhuyenMai.Rows[i].Cells[3].Value;

                if(TimeStart > DateTime.Now)
                {
                    MessageBox.Show("Khuyến mãi này chưa bắt đầu !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(DateTime.Now > TimeEnd)
                {
                    MessageBox.Show("Khuyến mãi này đã kết thúc !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaleOff = dgvKhuyenMai.Rows[i].Cells[4].Value.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi ! ");
                return;
            }
        }

        private void _3ChamKhuyenMai_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.DataSource = saleBUS.GetAllSales();
        }

        public void GetAllSale()
        {
            dgvKhuyenMai.DataSource = saleBUS.GetAllSales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvKhuyenMai.DataSource = saleBUS.GetSaleByName(txtSearch.Text.Trim());
            if (dgvKhuyenMai.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllSale();
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllSale();

        }
    }
}
