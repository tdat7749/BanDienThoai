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
    internal class BillBUS
    {
        public static DataTable GetAllBill()
        {
            return BillDAO.GetAllBill();
        }

        public void CreateBill(Bill bill)
        {
            BillDAO.CreateBill(bill);
        }

        public  void UpdateBill(Bill bill)
        {
            BillDAO.UpdateBill(bill);
        }

        public  void DeleteBill(int ma)
        {
            BillDAO.DeleteBill(ma);
        }

        public int GetLastID()
        {
            return BillDAO.GetLastID();
        }
    }
}