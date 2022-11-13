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
        public DataTable GetAllDetailBill()
        {
            return DetailBillDAO.GetAllDetailBill();
        }

        public void CreateDetailBill(DetailBill detailBill )
        {
            DetailBillDAO.CreateDetailBill(detailBill);
        }

        public void UpdateDetailBill(DetailBill detailBill)
        {
            DetailBillDAO.UpdateDetailBill(detailBill);
        }

        public void DeleteDetailBill(int ma)
        {
            DetailBillDAO.DeleteDetailBill(ma);
        }
    }
}