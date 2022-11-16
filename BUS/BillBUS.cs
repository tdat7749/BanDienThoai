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
        public DataTable GetAllBill()
        {
            return BillDAO.GetAllBill();
        }

        public DataTable GetBillByID(string id)
        {
            return BillDAO.GetBillByID(id);
        }

        public DataTable GetBillByCustomerID(string id)
        {
            return BillDAO.GetBillByCustomerID(id);
        }

        public DataTable GetBillByCustomerName(string fullName)
        {
            return BillDAO.GetBillByCustomerName(fullName);
        }

        public DataTable GetBillByPrice(string priceFrom, string priceTo)
        {
            return BillDAO.GetBillByPrice(priceFrom,priceTo);
        }

        public DataTable GetBillByPriceFrom(string priceFrom)
        {
            return BillDAO.GetBillByPriceFrom(priceFrom);
        }

        public DataTable GetBillByPriceTo(string priceTo)
        {
            return BillDAO.GetBillByPriceTo(priceTo);
        }

        public DataTable GetBillByDateCreate(string dateFrom,string dateTo)
        {
            return BillDAO.GetBillByDateCreate(dateFrom, dateTo);
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