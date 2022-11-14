using BanDienThoai.BUS;
using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDienThoai.GUI
{
    public partial class KhachHangGUI : Form
    {
        UserBUS userBUS = new UserBUS();
        public KhachHangGUI()
        {
            InitializeComponent();
            GetAllCustomer();
        }

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }

        public void GetAllCustomer()
        {
            dgvKhachHang.DataSource = userBUS.GetAllUser();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentRow.Index;
            if(i >= 0)
            {
                txtMaKhachHang.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                txtHo.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                txtTen.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
                txtSoDienThoai.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtHo.Text == "" || txtTen.Text == "" || txtSoDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPhoneNumber(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            user.FirstName = txtHo.Text.Trim();
            user.LastName = txtTen.Text.Trim();
            user.Address = txtDiaChi.Text.Trim();
            user.PhoneNumber = txtSoDienThoai.Text.Trim();

            userBUS.CreateUser(user);
            MessageBox.Show("Thêm khách hàng thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            GetAllCustomer();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtHo.Text == "" || txtTen.Text == "" || txtSoDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPhoneNumber(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            user.Id = int.Parse(txtMaKhachHang.Text.Trim());
            user.FirstName = txtHo.Text.Trim();
            user.LastName = txtTen.Text.Trim();
            user.Address = txtDiaChi.Text.Trim();
            user.PhoneNumber = txtSoDienThoai.Text.Trim();

            userBUS.UpdateUser(user);
            MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
            GetAllCustomer();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userBUS.DeleteUser(int.Parse(txtMaKhachHang.Text.Trim()));
            MessageBox.Show("Xóa thành công", "Thành Công", MessageBoxButtons.OK);
            GetAllCustomer();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách hàng muốn tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvKhachHang.DataSource = userBUS.GetUserByPhoneNumber(txtSearch.Text.Trim());
            if (dgvKhachHang.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllCustomer();
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllCustomer();
        }
    }
}
