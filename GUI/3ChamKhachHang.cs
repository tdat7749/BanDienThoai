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
    public partial class _3ChamKhachHang : Form
    {
        UserBUS UserBUS = new UserBUS();

        public static string id;
        public static string ho;
        public static string ten;

        public _3ChamKhachHang()
        {
            InitializeComponent();
            GetAllUser();
        }

        public void GetAllUser()
        {
            dgv3ChamUser.DataSource = UserBUS.GetAllUser();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3ChamUser.CurrentRow.Index;

            if (i >= 0)
            {
                id = dgv3ChamUser.Rows[i].Cells[0].Value.ToString();
                ho = dgv3ChamUser.Rows[i].Cells[1].Value.ToString();
                ten = dgv3ChamUser.Rows[i].Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp ! ");
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

                    dgv3ChamUser.DataSource = UserBUS.GetUserByName(txtSearch.Text.Trim());
                    if (dgv3ChamUser.Rows.Count <= 1)
                    {
                        MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GetAllUser();
                        return;
                    }
                }
        */
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv3ChamUser.DataSource = UserBUS.GetUserByPhoneNumber(txtSearch.Text.Trim());
            if (dgv3ChamUser.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllUser();
                return;
            }
        }
    }
}
