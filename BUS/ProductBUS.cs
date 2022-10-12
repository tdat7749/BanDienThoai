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
    internal class ProductBUS
    {
        public static DataTable GetAllProduct()
        {
            return ProductDAO.GetAllProduct();
        }

        [Obsolete]
        public static void CreateProduct(Product Product)
        {
            ProductDAO.CreateProduct(Product);
        }

        [Obsolete]
        public static void UpdateProduct(Product Product)
        {
            ProductDAO.UpdateProduct(Product);
        }

        public static void DeleteProduct(int ma)
        {
            ProductDAO.DeleteProduct(ma);
        }
    }
}
