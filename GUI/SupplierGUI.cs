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
    public partial class SupplierGUI : Form
    {
        SupplierBUS supplierBUS = new SupplierBUS();
        public SupplierGUI()
        {
            InitializeComponent();
            GetAllSupplier();
        }

        public void GetAllSupplier()
        {
            dgvNhaCungCap.DataSource = supplierBUS.GetAllSupplier();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNCC.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là bạn muốn thêm nhà cung cấp này chứ ?", "Nhà Cung Cấp", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Supplier supplier = new Supplier();
                supplier.NameSupplier = txtNCC.Text.Trim();
                supplier.AddressSupplier = txtDiaChi.Text.Trim();


                supplierBUS.CreateSupplier(supplier);

                GetAllSupplier();
                MessageBox.Show("Thêm Thành Công !");
                txtNCC.Text = "";
                txtDiaChi.Text = "";
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNCC.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là bạn muốn sửa nhà cung cấp này chứ ?", "Nhà Cung Cấp", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Supplier supplier = new Supplier();
                supplier.Id = int.Parse(txtMaNCC.Text.Trim());
                supplier.NameSupplier = txtNCC.Text.Trim();
                supplier.AddressSupplier = txtDiaChi.Text.Trim();


                supplierBUS.UpdateSupplier(supplier);

                GetAllSupplier();
                MessageBox.Show("Sửa Thành Công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là bạn muốn xóa nhà cung cấp này chứ ?", "Nhà Cung Cấp", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                supplierBUS.DeleteSupplier(int.Parse(txtMaNCC.Text.Trim()));

                GetAllSupplier();
                MessageBox.Show("Xóa Thành Công !");
                txtNCC.Text = "";
                txtDiaChi.Text = "";
                txtMaNCC.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtMaNCC.Text = "";
            txtNCC.Text = "";
            GetAllSupplier();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvNhaCungCap.DataSource = supplierBUS.GetSupplierByName(txtSearch.Text.Trim());
            if (dgvNhaCungCap.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllSupplier();
                return;
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhaCungCap.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaNCC.Text = dgvNhaCungCap.Rows[i].Cells[0].Value.ToString();
                txtNCC.Text = dgvNhaCungCap.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCungCap.Rows[i].Cells[2].Value.ToString();
            }
        }
    }
}
