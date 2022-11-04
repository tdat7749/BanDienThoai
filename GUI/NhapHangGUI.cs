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
        public NhapHangGUI()
        {
            InitializeComponent();
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
    }
}
