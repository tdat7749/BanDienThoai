using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class ImportBill
    {
        private int id;
        private int userID;
        private int supplierID;
        private DateTime createTime;
        private decimal total;

        public int Id { get => id; set => id = value; }
        public int UserID { get => userID; set => userID = value; }
        public int SupplierID { get => supplierID; set => supplierID = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }
        public decimal Total { get => total; set => total = value; }

        public ImportBill(int id, int userID, int supplierID, DateTime createTime, decimal total)
        {
            this.Id = id;
            this.UserID = userID;
            this.SupplierID = supplierID;
            this.CreateTime = createTime;
            this.Total = total;
        }

        public ImportBill()
        {

        }
    }
}