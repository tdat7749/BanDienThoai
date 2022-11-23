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
            panel1.BackColor = SetTransparency(180,Color.FromArgb(214,207,249));
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

        }
        static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
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
                MessageBox.Show("Tài khoản này không tồn tại hoặc đã bị khóa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
