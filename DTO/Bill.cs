using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class Bill
    {
        private int id;
        private int userId;
        private string fullName;
        private DateTime dateCreate;
        private decimal total;
        private int staffId;

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public int StaffId { get => staffId; set => staffId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public decimal Total { get => total; set => total = value; }

        public Bill(int id, int userID, int staffId, string fullName, DateTime createTime, decimal total)
        {
            this.Id = id;
            this.UserId = userID;
            this.StaffId = staffId;
            this.FullName = fullName;
            this.DateCreate = createTime;
            this.Total = total;
        }

        public Bill()
        {

        }
    }
}
