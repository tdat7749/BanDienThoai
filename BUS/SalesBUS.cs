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
    public class SalesBUS
    {
        public DataTable GetAllSales()
        {
            return SalesDAO.GetAllSales();
        }

        public DataTable GetSaleByName(string name)
        {
            return SalesDAO.GetSaleByName(name);
        }

        public void CreateSale(Sales sales)
        {
            SalesDAO.CreateSale(sales);
        }

        public void UpdateSale(Sales sales)
        {
            SalesDAO.UpdateSale(sales);
        }

        public void DeleteSale(int ma)
        {
            SalesDAO.DeleteSale(ma);
        }
    }
}
