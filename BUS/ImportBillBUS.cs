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
        public static DataTable GetAllImportBill()
        {
            return ImportBillDAO.GetAllImportBill();
        }

        [Obsolete]
        public static void CreateImportBill(ImportBill importBill)
        {
            ImportBillDAO.CreateImportBill(importBill);
        }

        [Obsolete]
        public static void UpdateImportBill(ImportBill importBill)
        {
            ImportBillDAO.UpdateImportBill(importBill);
        }

        public static void DeleteImportBill(int ma)
        {
            ImportBillDAO.DeleteImportBill(ma);
        }
    }
}
