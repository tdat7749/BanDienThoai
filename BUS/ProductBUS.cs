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
        public DataTable GetAllProduct()
        {
            return ProductDAO.GetAllProduct();
        }

        public void CreateProduct(Product Product)
        {
            ProductDAO.CreateProduct(Product);
        }

        public void UpdateProduct(Product Product)
        {
            ProductDAO.UpdateProduct(Product);
        }

        public void DeleteProduct(int ma)
        {
            ProductDAO.DeleteProduct(ma);
        }
    }
}
