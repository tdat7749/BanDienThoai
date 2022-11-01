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
    public partial class Sale : Form
    {
        private SalesBUS salesBUS = new SalesBUS();
        public Sale()
        {
            InitializeComponent();
            getAllSale();
        }

        public void getAllSale()
        {
            dgvSales.DataSource = salesBUS.GetAllSales();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKhuyenMai.Text == "" || txtTimeEnd.Text == "" || txtTimeStart.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các ô", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sales sale = new Sales();
            sale.NameSale = txtTenKhuyenMai.Text;
            sale.TimeStart = DateTime.Parse(txtTimeStart.Text);
            sale.TimeEnd = DateTime.Parse(txtTimeEnd.Text);

            salesBUS.CreateSale(sale);
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSales.CurrentRow.Index;
            if(i > 0)
            {
                txtTenKhuyenMai.Text = dgvSales.Rows[i].Cells[0].Value.ToString();
                txtTimeStart.Text = dgvSales.Rows[i].Cells[1].Value.ToString();
                txtTimeEnd.Text = dgvSales.Rows[i].Cells[2].Value.ToString();
            }
        }
    }
}
