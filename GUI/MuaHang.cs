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
        BillBUS billBUS = new BillBUS();
        DetailBillBUS detailBillBUS = new DetailBillBUS();
        public MuaHang()
        {
            InitializeComponent();
            GetAllProduct();
groupBox1.BackColor = SetTransparency(180, Color.White);
            groupBox2.BackColor = SetTransparency(180, Color.White);
            groupBox3.BackColor = SetTransparency(180, Color.White);
            label11.BackColor = SetTransparency(50,Color.White);
            label12.BackColor = SetTransparency(50, Color.White);
            label17.BackColor = SetTransparency(50, Color.White);
        }
static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }
        public void GetAllProduct()
        {
            dgvSanPham.DataSource = productBUS.GetAllProduct();
        }
        private void MuaHang_Load(object sender, EventArgs e)
        {
            tbGioHang.Columns.Add("Mã Sản Phẩm");
            tbGioHang.Columns.Add("Tên Sản Phẩm");
            tbGioHang.Columns.Add("Giá Tiền");
            tbGioHang.Columns.Add("Số Lượng");
            tbGioHang.Columns.Add("Thành Tiền");
            dgvGio.DataSource = tbGioHang;
            dgvGio.DefaultCellStyle.Font = new Font("Segoe UI", 10);
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

            if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng không được < 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (int.Parse(txtSoLuong.Text) > int.Parse(txtSoLuongConLai.Text))
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng còn lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            foreach (DataRow row in tbGioHang.Rows)
            {
                if (row["Tên Sản Phẩm"].ToString().Equals(txtTenSanPham.Text))
                {
                    row["Số Lượng"] = int.Parse(txtSoLuong.Text) + int.Parse(row["Số Lượng"].ToString());
                    row["Thành Tiền"] = (double.Parse(row["Giá Tiền"].ToString()) * int.Parse(row["Số Lượng"].ToString()));
                    goto C1;
                }
            }
            DataRow r = tbGioHang.NewRow();
            r["Mã Sản Phẩm"] = txtMaSanPham.Text;
            r["Tên Sản Phẩm"] = txtTenSanPham.Text;
            r["Giá Tiền"] = txtDonGia.Text;
            r["Số Lượng"] = txtSoLuong.Text;
            r["Thành Tiền"] = (double.Parse(txtDonGia.Text) * double.Parse(txtSoLuong.Text)).ToString();
            tbGioHang.Rows.Add(r);

        C1:    decimal sum = 0;
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
                    txtMaSanPham.Clear();
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
            if (i >= 0 && dgvSanPham.Rows[i].Cells[0].Value.ToString() != "")
            {
                txtMaSanPham.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                txtSoLuongConLai.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                txtMoTa.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                txtTenHang.Text = dgvSanPham.Rows[i].Cells[6].Value.ToString();

                string url = Application.StartupPath;
                url = Directory.GetParent(url).Parent.Parent.Parent.FullName;
                url += @"\imgProduct\pictureC#\";


                string urlImg = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                pbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap bm = new Bitmap(url + urlImg);
                pbSanPham.Image = bm;
            }
            else
            {
                MessageBox.Show("Hình như bạn chưa chọn sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dgvSanPham.Rows[i].Cells[1].Value.ToString().Equals(dgvGio.Rows[k].Cells[1].Value.ToString()))
                {
                    dgvSanPham.Rows[i].Cells[4].Value = int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString()) + int.Parse(dgvGio.Rows[k].Cells[3].Value.ToString());
                    decimal sum = decimal.Parse(txtTongTien.Text);
                    sum -= decimal.Parse(dgvGio.Rows[k].Cells[4].Value.ToString());
                    txtTongTien.Text = sum.ToString();
                    dgvGio.Rows.RemoveAt(k);
                    MessageBox.Show("Xóa Thành Công !");
                    return;
                }
            }
            
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if(txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên bán hàng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn khách hàng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là bạn mua hàng chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Bill bill = new Bill();
                bill.UserId = int.Parse(txtMaKhachHang.Text.Trim());
                bill.StaffId = int.Parse(txtMaNhanVien.Text.Trim());
                bill.FullName = txtKhachHang.Text.Trim();
                bill.DateCreate = (DateTime)dtpNgayTao.Value;
                bill.Total = decimal.Parse(txtTongTienKM.Text.Trim());

                billBUS.CreateBill(bill);

                foreach (DataRow row in tbGioHang.Rows)
                {
                    DetailBill detailBill = new DetailBill();
                    detailBill.BillId = billBUS.GetLastID();
                    detailBill.ProductId = int.Parse(row["Mã Sản Phẩm"].ToString().Trim());
                    detailBill.NameProduct = row["Tên Sản Phẩm"].ToString().Trim();
                    detailBill.Price = decimal.Parse(row["Giá Tiền"].ToString().Trim());
                    detailBill.Amount = int.Parse(row["Số Lượng"].ToString().Trim());
                    detailBill.Total = decimal.Parse(row["Thành Tiền"].ToString().Trim());

                    detailBillBUS.CreateDetailBill(detailBill);

                    productBUS.MinusStockProduct(detailBill.ProductId, detailBill.Amount);

                }
                MessageBox.Show("Mua Hàng Thành Công !!");
            }
            else
            {
                MessageBox.Show("Hủy Mua Thành Công !!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            if(dgvGio.RowCount <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng trước khi chọn khuyến mãi !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _3ChamKhuyenMai form = new _3ChamKhuyenMai();
            form.ShowDialog();

            txtKhuyenMai.Text = _3ChamKhuyenMai.SaleOff;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if(txtKhuyenMai.Text == "")
            {
                txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim())).ToString();
            }

            if (txtKhuyenMai.Text != "")
            {
                txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim()) - double.Parse(txtTongTien.Text.Trim()) * (double.Parse(txtKhuyenMai.Text) / 100)).ToString();
            }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {


            if (txtTongTien.Text != "")
            {
                txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim()) - double.Parse(txtTongTien.Text.Trim()) * (double.Parse(txtKhuyenMai.Text) / 100)).ToString();
            }
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string item = cbbLoc.GetItemText(cbbLoc.SelectedItem);
            string name = txtNameSearch.Text.Trim();

            if(item == "Tên Sản Phẩm")
            {
                dgvSanPham.DataSource = productBUS.GetProductByName(name);
            }
            else if(item == "Danh Mục"){
                dgvSanPham.DataSource = productBUS.GetProductByCategory(name);
            }
            else if(item == "Tất Cả")
            {
                dgvSanPham.DataSource = productBUS.GetAllProduct();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            _3ChamNhanVien form = new _3ChamNhanVien();
            form.ShowDialog();
            txtMaNhanVien.Text = _3ChamNhanVien.id;
            txtNhanVien.Text = _3ChamNhanVien.ho + " " + _3ChamNhanVien.ten;

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            _3ChamKhachHang form = new _3ChamKhachHang();
            form.ShowDialog();
            txtMaKhachHang.Text = _3ChamKhachHang.id;
            txtKhachHang.Text = _3ChamKhachHang.ho + " " + _3ChamKhachHang.ten;
        }

 
    }
}
