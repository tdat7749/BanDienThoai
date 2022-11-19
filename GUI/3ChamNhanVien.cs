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

namespace BanDienThoai.GUI
{
    public partial class _3ChamNhanVien : Form
    {

        StaffBUS StaffBUS = new StaffBUS();

        public static string id;
        public static string ho;
        public static string ten;

        public _3ChamNhanVien()
        {
            InitializeComponent();
            GetAllStaff();
        }

        public void GetAllStaff()
        {
            dgv3ChamStaff.DataSource = StaffBUS.GetAllStaff();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3ChamStaff.CurrentRow.Index;

            if (i >= 0)
            {
                id = dgv3ChamStaff.Rows[i].Cells[0].Value.ToString();
                ho = dgv3ChamStaff.Rows[i].Cells[1].Value.ToString();
                ten = dgv3ChamStaff.Rows[i].Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên ! ");
                return;
            }
        }
/*
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv3ChamStaff.DataSource = StaffBUS.GetStaffByName(txtSearch.Text.Trim());
            if (dgv3ChamStaff.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllStaff();
                return;
            }
        }
*/
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllStaff();
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv3ChamStaff.DataSource = StaffBUS.GetStaffByName(txtSearch.Text.Trim());
            if (dgv3ChamStaff.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllStaff();
                return;
            }
        }
    }
}
