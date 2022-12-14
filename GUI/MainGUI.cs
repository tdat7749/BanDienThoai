using BanDienThoai.DAO;
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
    public partial class MainGUI : Form
    {
        private Form currentFormChild;
        public MainGUI()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            
        }

        private void ChangeFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new MuaHang());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new KhachHangGUI());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new HoaDonGUI());
        }

        private void btnHoaDonNH_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new HoaDonNhapHangGUI());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new NhanVienGUI());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new NhapHangGUI());
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new SaleGUI());
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            if(TaiKhoanDAO.NamePermiss == "Nhân Viên")
            {
                pnlQuanLy.Hide();
                ChangeFormChild(new MuaHang());
            }
            else
            {
                ChangeFormChild(new ThongKeGUI());
            }
            

        }

        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new ThongKeGUI());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new SanPhamGUI());

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
            DangNhapGUI form = new DangNhapGUI();
            form.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new SupplierGUI());

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ChangeFormChild(new DanhMucGUI());
        }
    }
}
