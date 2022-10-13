using BanDienThoai.DAO;
using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.BUS
{
    internal class StockBUS
    {
        [Obsolete]
        public static void CreateStock(Stock stock)
        {
            StockDAO.CreateStock(stock);
        }

        [Obsolete]
        public static void UpdateStock(Stock stock)
        {
            StockDAO.UpdateStock(stock);
        }
    }
}
