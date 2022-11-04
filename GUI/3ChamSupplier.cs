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
    public partial class _3ChamSupplier : Form
    {

        SupplierBUS supplierBUS = new SupplierBUS();

        public static string id;
        public static string tenNCC;
        public _3ChamSupplier()
        {
            InitializeComponent();
            GetAllSupplier();
        }

        public void GetAllSupplier()
        {
            dgv3ChamSupplier.DataSource = supplierBUS.GetAllSupplier();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3ChamSupplier.CurrentRow.Index;

            if(i >= 0)
            {
                id = dgv3ChamSupplier.Rows[i].Cells[0].Value.ToString();
                tenNCC = dgv3ChamSupplier.Rows[i].Cells[1].Value.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp ! ");
                return;
            }
        }
    }
}
