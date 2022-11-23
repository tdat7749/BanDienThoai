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
    public partial class NhanVienGUI : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        StaffBUS staffBUS = new StaffBUS();
        public NhanVienGUI()
        {
            InitializeComponent();
            GetAllStaff();
            label11.BackColor = SetTransparency(50, Color.White);
            groupBox1.BackColor = SetTransparency(180, Color.White);
            groupBox2.BackColor = SetTransparency(180, Color.White);
            groupBox3.BackColor = SetTransparency(180, Color.White);
        }
static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }

        public void GetAllStaff()
        {
            dgvNhanVien.DataSource = taiKhoanBUS.GetAllTaiKhoan();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
                txtTaiKhoan.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
                txtHoNhanVien.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
                cbbGioiTinh.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
                txtSoDienThoai.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
                cbbChucVu.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
                if(dgvNhanVien.Rows[i].Cells[8].Value.ToString() == "1")
                {
                    cbbTrangThai.Text = "Mở";
                }

                if (dgvNhanVien.Rows[i].Cells[8].Value.ToString() == "0")
                {
                    cbbTrangThai.Text = "Khóa";
                }
            }
        }

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{10})$").Success;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" ||
                txtMatKhau.Text.Trim() == "" ||
                txtHoNhanVien.Text.Trim() == "" ||
                txtHoNhanVien.Text.Trim() == "" ||
                txtTenNhanVien.Text.Trim() == "" ||
                txtSoDienThoai.Text.Trim() == "" ||
                cbbGioiTinh.Text.Trim() == "" ||
                cbbChucVu.Text.Trim() == "" ||
                cbbTrangThai.Text.Trim() == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*if (!IsPhoneNumber(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là thêm nhân viên này chứ ?", "Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Staff staff = new Staff();

                staff.FirstName = txtHoNhanVien.Text.Trim();
                staff.LastName = txtTenNhanVien.Text.Trim();
                staff.GioiTinh = cbbGioiTinh.GetItemText(cbbGioiTinh.SelectedItem);
                staff.PhoneNumber = txtSoDienThoai.Text.Trim();

                staffBUS.CreateStaff(staff);

                TaiKhoan taiKhoan = new TaiKhoan();

                taiKhoan.StaffId = staffBUS.GetLastID();
                taiKhoan.UserName = txtTaiKhoan.Text.Trim();
                taiKhoan.Password = txtMatKhau.Text.Trim();
                if (cbbChucVu.GetItemText(cbbChucVu.SelectedItem).Trim() == "Quản Trị Viên")
                {
                    taiKhoan.PermissId = 4;
                }
                if (cbbChucVu.GetItemText(cbbChucVu.SelectedItem).Trim() == "Nhân Viên")
                {
                    taiKhoan.PermissId = 3;
                }

                if (cbbTrangThai.GetItemText(cbbTrangThai.SelectedItem).Trim() == "Mở")
                {
                    taiKhoan.Status = 1;
                }
                if (cbbTrangThai.GetItemText(cbbTrangThai.SelectedItem).Trim() == "Khóa")
                {
                    taiKhoan.Status = 0;
                }

                taiKhoanBUS.CreateTaiKhoan(taiKhoan);

                MessageBox.Show("Thêm nhân viên thành công !!", "Nhân Viên", MessageBoxButtons.OK);

                GetAllStaff();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên trước khi sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTaiKhoan.Text.Trim() == "" ||
                txtMatKhau.Text.Trim() == "" ||
                txtHoNhanVien.Text.Trim() == "" ||
                txtHoNhanVien.Text.Trim() == "" ||
                txtTenNhanVien.Text.Trim() == "" ||
                txtSoDienThoai.Text.Trim() == "" ||
                cbbGioiTinh.Text.Trim() == "" ||
                cbbChucVu.Text.Trim() == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*if (!IsPhoneNumber(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là sửa thông tin nhân viên này chứ ?", "Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Staff staff = new Staff();
                staff.Id = int.Parse(txtMaNhanVien.Text.Trim());
                staff.FirstName = txtHoNhanVien.Text.Trim();
                staff.LastName = txtTenNhanVien.Text.Trim();
                staff.GioiTinh = cbbGioiTinh.GetItemText(cbbGioiTinh.SelectedItem);
                staff.PhoneNumber = txtSoDienThoai.Text.Trim();

                staffBUS.UpdateStaff(staff);

                TaiKhoan taiKhoan = new TaiKhoan();

                taiKhoan.StaffId = int.Parse(txtMaNhanVien.Text.Trim());
                taiKhoan.UserName = txtTaiKhoan.Text.Trim();
                taiKhoan.Password = txtMatKhau.Text.Trim();
                if (cbbChucVu.GetItemText(cbbChucVu.SelectedItem).Trim() == "Quản Trị Viên")
                {
                    taiKhoan.PermissId = 4;
                }
                if (cbbChucVu.GetItemText(cbbChucVu.SelectedItem).Trim() == "Nhân Viên")
                {
                    taiKhoan.PermissId = 3;
                }

                if (cbbTrangThai.GetItemText(cbbTrangThai.SelectedItem).Trim() == "Mở")
                {
                    taiKhoan.Status = 1;
                }
                if (cbbTrangThai.GetItemText(cbbTrangThai.SelectedItem).Trim() == "Khóa")
                {
                    taiKhoan.Status = 0;
                }

                taiKhoanBUS.UpdateTaiKhoan(taiKhoan);

                MessageBox.Show("Sửa nhân viên thành công !!", "Nhân Viên", MessageBoxButtons.OK);

                GetAllStaff();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên trước khi sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là xóa nhân viên này chứ ?", "Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                taiKhoanBUS.DeleteTaiKhoan(int.Parse(txtMaNhanVien.Text.Trim()));
                staffBUS.DeleteStaff(int.Parse(txtMaNhanVien.Text.Trim()));
                MessageBox.Show("Xóa nhân viên thành công !!", "Nhân Viên", MessageBoxButtons.OK);
                GetAllStaff();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string item = cbbLuaChon.GetItemText(cbbLuaChon.SelectedItem);
            string name = txtSearch.Text.Trim();

            if(item == "Tất Cả")
            {
                dgvNhanVien.DataSource = taiKhoanBUS.GetAllTaiKhoan();
            }
            else if(item == "Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = taiKhoanBUS.GetTaiKhoanByStaffName(name);

                if (dgvNhanVien.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllStaff();
                    return;
                }
            }
            else if(item == "Chức Vụ")
            {
                dgvNhanVien.DataSource = taiKhoanBUS.GetTaiKhoanByChucVu(name);

                if (dgvNhanVien.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllStaff();
                    return;
                }
            }
            else if(item == "Số Điện Thoại")
            {
                dgvNhanVien.DataSource = taiKhoanBUS.GetTaiKhoanBySDT(name);

                if (dgvNhanVien.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllStaff();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lựa chọn không hợp lệ !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtHoNhanVien.Text = "";
            txtMatKhau.Text = "";
            txtSoDienThoai.Text = "";
            txtTaiKhoan.Text = "";
            txtTenNhanVien.Text = "";
            txtSearch.Text = "";
            GetAllStaff();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
