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
        public DataTable GetAllCategory()
        {
            return CategoryDAO.GetAllCategory();
        }

        public void CreateCategory(Category per)
        {
            CategoryDAO.CreateCategory(per);
        }

        public void UpdateCategory(Category per)
        {
            CategoryDAO.UpdateCategory(per);
        }

        public void DeleteCategory(int ma)
        {
            CategoryDAO.DeleteCategory(ma);
        }
    }
}
