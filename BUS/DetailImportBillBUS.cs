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
    internal class DetailImportBillBUS
    {
        public static DataTable GetAllDetailImportBill()
        {
            return DetailImportBillDAO.GetAllDetailImportBill();
        }

        [Obsolete]
        public static void CreateDetailImportBill(DetailImportBill detailImportBill)
        {
            DetailImportBillDAO.CreateDetailImportBill(detailImportBill);
        }

        [Obsolete]
        public static void UpdateDetailImportBill(DetailImportBill detailImportBill)
        {
            DetailImportBillDAO.UpdateDetailImportBill(detailImportBill);
        }

        public static void DeleteDetailImportBill(int ma)
        {
            DetailImportBillDAO.DeleteDetailImportBill(ma);
        }
    }
}
