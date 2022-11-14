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
    public class DetailImportBillBUS
    {
        public DataTable GetDetailImportBillByID(string id)
        {
            return DetailImportBillDAO.GetDetailImportBillByID(id);
        }

        public void CreateDetailImportBill(DetailImportBill detailImportBill)
        {
            DetailImportBillDAO.CreateDetailImportBill(detailImportBill);
        }

        public void UpdateDetailImportBill(DetailImportBill detailImportBill)
        {
            DetailImportBillDAO.UpdateDetailImportBill(detailImportBill);
        }

        public void DeleteDetailImportBill(int ma)
        {
            DetailImportBillDAO.DeleteDetailImportBill(ma);
        }
    }
}
