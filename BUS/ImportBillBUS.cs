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
    internal class ImportBillBUS
    {
        public DataTable GetAllImportBill()
        {
            return ImportBillDAO.GetAllImportBill();
        }
        public DataTable GetImportBillByStaffID(string id)
        {
            return ImportBillDAO.GetImportBillByStaffID(id);
        }

        public DataTable GetImportBillByPrice(string priceFrom, string priceTo)
        {
            return ImportBillDAO.GetImportBillByPrice(priceFrom, priceTo);
        }

        public DataTable GetImportBillByPriceFrom(string priceFrom)
        {
            return ImportBillDAO.GetImportBillByPriceFrom(priceFrom);
        }

        public DataTable GetImportBillByPriceTo(string priceTo)
        {
            return ImportBillDAO.GetImportBillByPriceTo(priceTo);
        }

        public DataTable GetImportBillByDateCreate(string dateFrom, string dateTo)
        {
            return ImportBillDAO.GetImportBillByDateCreate(dateFrom, dateTo);
        }

        public void CreateImportBill(ImportBill importBill)
        {
            ImportBillDAO.CreateImportBill(importBill);
        }

        public void UpdateImportBill(ImportBill importBill)
        {
            ImportBillDAO.UpdateImportBill(importBill);
        }

        public  void DeleteImportBill(int ma)
        {
            ImportBillDAO.DeleteImportBill(ma);
        }

        public int GetLastID()
        {
            return ImportBillDAO.GetLastID();
        }
    }
}
