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
    public partial class HoaDonNhapHangGUI : Form
    {
        ImportBillBUS importBillBUS = new ImportBillBUS();
        DetailImportBillBUS detailImportBillBUS = new DetailImportBillBUS();

        public HoaDonNhapHangGUI()
        {
            InitializeComponent();
            GetAllImportBill();
        }

        public void GetAllImportBill()
        {
            dgvHoaDon.DataSource = importBillBUS.GetAllImportBill();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvHoaDon.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaHoaDon.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                txtMaNhanVien.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                dtpNgayLap.Value = (DateTime)dgvHoaDon.Rows[i].Cells[2].Value;
                txtTongTien.Text = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                txtNhaCungCap.Text = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
                txtNhanVien.Text = dgvHoaDon.Rows[i].Cells[5].Value.ToString();


                dgvChiTietHoaDon.DataSource = detailImportBillBUS.GetDetailImportBillByID(txtMaHoaDon.Text.Trim());
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChiTietHoaDon.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaHoaDonCT.Text = dgvChiTietHoaDon.Rows[i].Cells[0].Value.ToString();
                txtMaSanPham.Text = dgvChiTietHoaDon.Rows[i].Cells[1].Value.ToString();
                txtTenSanPham.Text = dgvChiTietHoaDon.Rows[i].Cells[2].Value.ToString();
                txtDonGia.Text = dgvChiTietHoaDon.Rows[i].Cells[3].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[i].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvChiTietHoaDon.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string item = cbbLuaChon.GetItemText(cbbLuaChon.SelectedItem);
            string textSearch = txtSearch.Text.Trim();

            if (item == "")
            {
                MessageBox.Show("Vui lòng chọn lựa chọn tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (item == "Tất Cả")
            {
                dgvHoaDon.DataSource = importBillBUS.GetAllImportBill();
                return;
            }

            if (item == "Mã Nhân Viên")
            {
                dgvHoaDon.DataSource = importBillBUS.GetImportBillByStaffID(textSearch);

                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllImportBill();
                    return;
                }
            }
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

        private void btnLocGia_Click(object sender, EventArgs e)
        {
            if (txtGiaTu.Text.Trim() == "" && txtGiaDen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập một trong hai ô !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumber(txtGiaTu.Text.Trim()) || !IsNumber(txtGiaDen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập giá trị là số !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.Parse(txtGiaTu.Text.Trim()) > double.Parse(txtGiaDen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập giá từ bé hơn giá đến !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGiaTu.Text != "" && txtGiaDen.Text == "")
            {
                dgvHoaDon.DataSource = importBillBUS.GetImportBillByPriceFrom(txtGiaTu.Text.Trim());

                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllImportBill();
                    return;
                }
                return;
            }

            if (txtGiaTu.Text == "" && txtGiaDen.Text != "")
            {
                dgvHoaDon.DataSource = importBillBUS.GetImportBillByPriceTo(txtGiaDen.Text.Trim());

                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllImportBill();
                    return;
                }
                return;
            }

            dgvHoaDon.DataSource = importBillBUS.GetImportBillByPrice(txtGiaTu.Text.Trim(), txtGiaDen.Text.Trim());

            if (dgvHoaDon.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllImportBill();
                return;
            }
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            if (dtpNgayTu.Value > dtpNgayDen.Value)
            {
                MessageBox.Show("Vui lòng lựa chọn ngày từ nhỏ hơn ngày đến !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] NgayTu = dtpNgayTu.Value.ToString().Split(" ");
            string[] NgayDen = dtpNgayDen.Value.ToString().Split(" ");

            dgvHoaDon.DataSource = importBillBUS.GetImportBillByDateCreate(NgayTu[0], NgayDen[0]);

            if (dgvHoaDon.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllImportBill();
                return;
            }
        }

        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
