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
    internal class PermissionBUS
    {
        public static DataTable GetAllUser()
        {
            return PermissionDAO.GetAllPermiss();
        }

        [Obsolete]
        public static void CreateUser(Permission per)
        {
            PermissionDAO.CreatePermiss(per);
        }

        [Obsolete]
        public static void UpdateUser(Permission per)
        {
            PermissionDAO.UpdatePermiss(per);
        }

        public static void DeletePermiss(int ma)
        {
            PermissionDAO.DetelePermiss(ma);
        }
    }
}
