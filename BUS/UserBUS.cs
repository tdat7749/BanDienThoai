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
    internal class UserBUS
    {
        public static DataTable GetAllUser()
        {
            return UserDAO.GetAllUser();
        }

        [Obsolete]
        public static void CreateUser(User user)
        {
            UserDAO.CreateUser(user);
        }

        [Obsolete]
        public static void UpdateUser(User user)
        {
            UserDAO.UpdateUser(user);
        }

        public static void DeleteSanPham(int ma)
        {
            UserDAO.DeleteUser(ma);
        }
    }
}
