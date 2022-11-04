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
    }
}
