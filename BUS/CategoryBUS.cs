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
    internal class CategoryBUS
    {
        public static DataTable GetAllCategory()
        {
            return CategoryDAO.GetAllCategory();
        }

        [Obsolete]
        public static void CreateCategory(Category per)
        {
            CategoryDAO.CreateCategory(per);
        }

        [Obsolete]
        public static void UpdateCategory(Category per)
        {
            CategoryDAO.UpdateCategory(per);
        }

        public static void DeleteCategory(int ma)
        {
            CategoryDAO.DeleteCategory(ma);
        }
    }
}
