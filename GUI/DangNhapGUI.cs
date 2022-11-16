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
    public partial class DangNhapGUI : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (taiKhoanBUS.CheckLogin(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim()) == true)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Hide();
                MainGUI form = new MainGUI();
                form.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
