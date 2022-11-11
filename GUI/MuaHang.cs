using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanDienThoai.BUS;
using BanDienThoai.DTO;


namespace BanDienThoai.GUI
{
    public partial class MuaHang : Form
    {
        DataTable tbGioHang = new DataTable();
        ProductBUS productBUS = new ProductBUS();
        public MuaHang()
        {
            InitializeComponent();
            GetAllProduct();
        }
        public void GetAllProduct()
        {
            dgvSanPham.DataSource = productBUS.GetAllProduct();
        }
        private void MuaHang_Load(object sender, EventArgs e)
        {
            tbGioHang.Columns.Add("Tên Sản Phẩm");
            tbGioHang.Columns.Add("Giá Tiền");
            tbGioHang.Columns.Add("Số Lượng");
            tbGioHang.Columns.Add("Thành Tiền");
            dgvGio.DataSource = tbGioHang;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in tbGioHang.Rows)
            {
                if (row["Tên Sản Phẩm"].ToString().Equals(txtTenSanPham.Text))
                {
                    MessageBox.Show("Sản phẩm đã có trong giỏ hàng");
                    return;
                }
            }

            if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm");
                return;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Nhập số lượng!");
                return;
            }
            else if (int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng không được < 0");
                return;
            }
            else if (int.Parse(txtSoLuong.Text) > int.Parse(txtSoLuongConLai.Text))
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng còn lại");
                return;
            }
            else
            {
                DataRow r = tbGioHang.NewRow();
                r["Tên Sản Phẩm"] = txtTenSanPham.Text;
                r["Giá Tiền"] = txtDonGia.Text;
                r["Số Lượng"] = txtSoLuong.Text;
                r["Thành Tiền"] = (double.Parse(txtDonGia.Text) * double.Parse(txtSoLuong.Text)).ToString();
                tbGioHang.Rows.Add(r);
                
            }

            decimal sum = 0;
            foreach (DataRow row in tbGioHang.Rows)
            {
                sum += decimal.Parse(row["Thành Tiền"].ToString());
            }
            txtTongTien.Text = sum.ToString();


            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                if (dgvSanPham.Rows[i].Cells[1].Value.ToString().Equals(txtTenSanPham.Text))
                {
                    dgvSanPham.Rows[i].Cells[4].Value = int.Parse(txtSoLuongConLai.Text) - int.Parse(txtSoLuong.Text);
                    txtTenSanPham.Clear();
                    txtDonGia.Clear();
                    txtSoLuong.Clear();
                    txtSoLuongConLai.Clear();
                    txtMoTa.Clear();
                    txtTenHang.Clear();                 
                    return;
                }
            }
            
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            if (i >= 0)
            {
                txtTenSanPham.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                txtSoLuongConLai.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                txtMoTa.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                txtTenHang.Text = dgvSanPham.Rows[i].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Hình như bạn chưa chọn sản phẩm");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            int k = dgvGio.CurrentRow.Index;
            if (k < 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                if (dgvSanPham.Rows[i].Cells[1].Value.ToString().Equals(dgvGio.Rows[k].Cells[0].Value.ToString()))
                {
                    dgvSanPham.Rows[i].Cells[4].Value = int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString()) + int.Parse(dgvGio.Rows[k].Cells[2].Value.ToString());
                    decimal sum = decimal.Parse(txtTongTien.Text);
                    sum -= decimal.Parse(dgvGio.Rows[k].Cells[3].Value.ToString());
                    txtTongTien.Text = sum.ToString();
                    dgvGio.Rows.RemoveAt(k);
                    MessageBox.Show("Xóa Thành Công !");
                    return;
                }
            }
            
        }
    }
}
