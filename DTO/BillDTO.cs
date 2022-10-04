using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class BillDTO
    {
        private int id;
        private int userID;
        private string userName;
        private string fullName;
        private DateTime createTime;
        private decimal total;

        public int Id { get => id; set => id = value; }
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }
        public decimal Total { get => total; set => total = value; }

        public BillDTO(int id, int userID, string userName, string fullName, DateTime createTime, decimal total)
        {
            this.Id = id;
            this.UserID = userID;
            this.UserName = userName;
            this.FullName = fullName;
            this.CreateTime = createTime;
            this.Total = total;
        }

        public BillDTO()
        {

        }
    }
}
