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

        public DataTable GetProductByName(string name)
        {
            return ProductDAO.GetProductByName(name);
        }
        public DataTable GetProductByCategory(string name)
        {
            return ProductDAO.GetProductByCategory(name);
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

        public void UpdateStockProduct(int ma,int stock)
        {
            ProductDAO.UpdateStockProduct(ma, stock);
        }

        public void MinusStockProduct(int ma, int stock)
        {
            ProductDAO.MinusStockProduct(ma, stock);
        }
    }
}
