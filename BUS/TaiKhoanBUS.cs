using BanDienThoai.DAO;
using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.BUS
{
    public class TaiKhoanBUS
    {
        public DataTable GetAllTaiKhoan()
        {
            return TaiKhoanDAO.GetAllTaiKhoan();
        }

        public DataTable GetTaiKhoanBySDT(string sdt)
        {
            return TaiKhoanDAO.GetTaiKhoanBySDT(sdt);
        }
        public DataTable GetTaiKhoanByChucVu(string chucVu)
        {
            return TaiKhoanDAO.GetTaiKhoanByChucVu(chucVu);
        }
        public DataTable GetTaiKhoanByStaffName(string staffName)
        {
            return TaiKhoanDAO.GetTaiKhoanByStaffName(staffName);
        }

        public void CreateTaiKhoan(TaiKhoan taikhoan)
        {
            TaiKhoanDAO.CreateTaiKhoan(taikhoan);
        }

        public void UpdateTaiKhoan(TaiKhoan taikhoan)
        {
            TaiKhoanDAO.UpdateTaiKhoan(taikhoan);
        }

        public void DeleteTaiKhoan(int ma)
        {
            TaiKhoanDAO.DeleteTaiKhoan(ma);
        }
    }
}
