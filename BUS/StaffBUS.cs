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
    internal class StaffBUS
    {
        public DataTable GetAllStaff()
        {
            return StaffDAO.GetAllStaff();
        }

        public int GetLastID()
        {
            return StaffDAO.GetLastID();
        }

        public void CreateStaff(Staff per)
        {
            StaffDAO.CreateStaff(per);
        }


        public void UpdateStaff(Staff per)
        {
            StaffDAO.UpdateStaff(per);
        }

        public void DeleteStaff(int ma)
        {
            StaffDAO.DeleteStaff(ma);
        }

        public int GetSoLuongStaff()
        {
            return StaffDAO.GetSoLuongStaff();
        }

        public DataTable GetStaffByName(string name)
        {
            return StaffDAO.GetStaffByName(name);
        }
    }
}
