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
        public  DataTable GetAllUser()
        {
            return UserDAO.GetAllUser();
        }

        public  void CreateUser(User user)
        {
            UserDAO.CreateUser(user);
        }

        public  void UpdateUser(User user)
        {
            UserDAO.UpdateUser(user);
        }

        public  void DeleteUser(int ma)
        {
            UserDAO.DeleteUser(ma);
        }
    }
}
