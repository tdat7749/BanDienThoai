using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class DetailBillDTO
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ProDuctID { get; set; }
        public string NameProduct{ get; set; }
        public int Price{ get; set; }
        public int Amount{ get; set; }
        public int Total { get; set; }
        
    }
}
