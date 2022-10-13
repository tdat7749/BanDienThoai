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
    internal class DetailBillBUS
    {
        public static DataTable GetAllDetailBill()
        {
            return DetailBillDAO.GetAllDetailBill();
        }

        [Obsolete]
        public static void CreateDetailBill(DetailBill detailBill )
        {
            DetailBillDAO.CreateDetailBill(detailBill);
        }

        [Obsolete]
        public static void UpdateDetailBill(DetailBill detailBill)
        {
            DetailBillDAO.UpdateDetailBill(detailBill);
        }

        public static void DeleteDetailBill(int ma)
        {
            DetailBillDAO.DeleteDetailBill(ma);
        }
    }
}