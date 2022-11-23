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
    public partial class NhapHangGUI : Form
    {
        DataTable tbOrder = new DataTable();
        ImportBillBUS importBillBUS = new ImportBillBUS();
        DetailImportBillBUS detailImportBillBUS = new DetailImportBillBUS();
        ProductBUS productBUS = new ProductBUS();


        public NhapHangGUI()
        {
            InitializeComponent();
groupBox1.BackColor = SetTransparency(180, Color.White);
            groupBox2.BackColor = SetTransparency(180, Color.White);
            groupBox3.BackColor = SetTransparency(180, Color.White);
            label6.BackColor = SetTransparency(50, Color.White);
            label9.BackColor = SetTransparency(50, Color.White);
        }

static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            _3ChamSupplier form = new _3ChamSupplier();

            form.ShowDialog();

            txtIDNCC.Text = _3ChamSupplier.id;
            txtNhaCungCap.Text = _3ChamSupplier.tenNCC;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            _3ChamProduct form = new _3ChamProduct();
            form.ShowDialog();

            txtIDSanPham.Text = _3ChamProduct.id;
            txtTenSanPham.Text = _3ChamProduct.name;
            txtGiaTien.Text = _3ChamProduct.price;
        }

        private void NhapHangGUI_Load(object sender, EventArgs e)
        {
            tbOrder.Columns.Add("ID Sản Phẩm");
            tbOrder.Columns.Add("Sản Phẩm");
            tbOrder.Columns.Add("Giá Tiền");
            tbOrder.Columns.Add("Số Lượng");
            tbOrder.Columns.Add("Thành Tiền");
            dgvOrder.DataSource = tbOrder;
            txtTongTien.Text = "0";
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumber(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtSoLuong.Text) < 1)
            {
                MessageBox.Show("Số lượng không được bé hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRow row in tbOrder.Rows)
            {
                if (row["Sản Phẩm"].ToString().Equals(txtTenSanPham.Text))
                {
                    row["Số Lượng"] = int.Parse(txtSoLuong.Text) + int.Parse(row["Số Lượng"].ToString());
                    row["Thành Tiền"] = (double.Parse(row["Giá Tiền"].ToString()) * int.Parse(row["Số Lượng"].ToString()));
                    goto C1;
                }
            }

            if (IsNumber(txtSoLuong.Text))
            {
                DataRow r = tbOrder.NewRow();
                r["ID Sản Phẩm"] = txtIDSanPham.Text;
                r["Sản Phẩm"] = txtTenSanPham.Text;
                r["Giá Tiền"] = txtGiaTien.Text;
                r["Số Lượng"] = txtSoLuong.Text;
                r["Thành Tiền"] = (double.Parse(txtGiaTien.Text) * double.Parse(txtSoLuong.Text)).ToString();
                tbOrder.Rows.Add(r);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập ô số lượng là số > 0!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        C1: decimal sum = 0;
            foreach (DataRow row in tbOrder.Rows)
            {
                sum += decimal.Parse(row["Thành Tiền"].ToString());
            }
            txtTongTien.Text = sum.ToString();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if(txtIDNCC.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn nhà cung cấp !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtIDNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn người lập đơn nhập hàng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dgvOrder.RowCount <= 1)
            {
                MessageBox.Show("Chưa lựa chọn sản phẩm để nhập hàng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là bạn muốn nhập hàng chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ImportBill importBill = new ImportBill();
                importBill.StaffID = int.Parse(txtIDNhanVien.Text.Trim());
                importBill.SupplierID = int.Parse(txtIDNCC.Text.Trim());
                importBill.DateCreate = dtpNgayNhap.Value;
                importBill.Total = decimal.Parse(txtTongTien.Text);

                importBillBUS.CreateImportBill(importBill);


                foreach (DataRow row in tbOrder.Rows)
                {
                    DetailImportBill detailImportBill = new DetailImportBill();
                    detailImportBill.ImportID = importBillBUS.GetLastID();
                    detailImportBill.ProductID = int.Parse(row["ID Sản Phẩm"].ToString());
                    detailImportBill.NameProduct = row["Sản Phẩm"].ToString();
                    detailImportBill.Price = decimal.Parse(row["Giá Tiền"].ToString());
                    detailImportBill.Amount = int.Parse(row["Số lượng"].ToString());
                    detailImportBill.Total = decimal.Parse(row["Thành Tiền"].ToString());

                    detailImportBillBUS.CreateDetailImportBill(detailImportBill);
                    productBUS.UpdateStockProduct(detailImportBill.ProductID, detailImportBill.Amount);
                }

                MessageBox.Show("Nhập hàng thành công !!");
            }

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dgvOrder.CurrentRow.Index;

            if (i < 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumber(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtSoLuong.Text) < 1)
            {
                MessageBox.Show("Số lượng không được bé hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvOrder.Rows[i].Cells[3].Value = txtSoLuong.Text;
            MessageBox.Show("Sửa Thành Công !");


        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvOrder.CurrentRow.Index;
            if (i >= 0 && dgvOrder.Rows[i].Cells[0].Value.ToString() != "")
            {
                txtIDSanPham.Text = dgvOrder.Rows[i].Cells[0].Value.ToString();
                txtTenSanPham.Text = dgvOrder.Rows[i].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvOrder.Rows[i].Cells[3].Value.ToString();
                txtGiaTien.Text = dgvOrder.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            int i = dgvOrder.CurrentRow.Index;

            if (i<0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbOrder.Rows.RemoveAt(i);
            MessageBox.Show("Xóa Thành Công !");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDNCC.Text = "";
            txtNhaCungCap.Text = "";
            txtIDNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtTenSanPham.Text = "";
            txtGiaTien.Text = "";
            txtIDSanPham.Text = "";
            txtSoLuong.Text = "";
            tbOrder.Rows.Clear();
            txtTongTien.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3ChamNhanVien form = new _3ChamNhanVien();
            form.ShowDialog();

            txtIDNhanVien.Text = _3ChamNhanVien.id;
            txtTenNhanVien.Text = _3ChamNhanVien.ho + " " + _3ChamNhanVien.ten;
        }
    }
}
