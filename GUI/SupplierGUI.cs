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

        private SupplierBUS supplierBUS = new SupplierBUS();
        public SupplierGUI()
        {
            InitializeComponent();
            GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void GetAll()
        {
            dgvSupplier.DataSource = supplierBUS.GetAllSupplier();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text.Trim() == "" && txtNameSupplier.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống các ô", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supplier supplier = new Supplier();
            supplier.NameSupplier = txtNameSupplier.Text.Trim();
            supplier.AddressSupplier = txtAddress.Text.Trim();

            supplierBUS.CreateSupplier(supplier);

            GetAll();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSupplier.CurrentRow.Index;
                txtID.Text = dgvSupplier.Rows[i].Cells[0].Value.ToString();
                txtNameSupplier.Text = dgvSupplier.Rows[i].Cells[1].Value.ToString();
                txtAddress.Text = dgvSupplier.Rows[i].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Trim() == "")
            {
                MessageBox.Show("Hình như bạn chưa chọn nhà cung cấp để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            supplierBUS.DeleteSupplier(int.Parse(txtID.Text));
            GetAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Hình như bạn chưa chọn nhà cung cấp để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtAddress.Text.Trim() == "" && txtNameSupplier.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống các ô", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supplier supplier = new Supplier();
            supplier.Id = int.Parse(txtID.Text.Trim());
            supplier.NameSupplier = txtNameSupplier.Text.Trim();
            supplier.AddressSupplier = txtAddress.Text.Trim();

            supplierBUS.UpdateSupplier(supplier);

            GetAll();
        }
    }
}
