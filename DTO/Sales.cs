using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class Sales
    {
        private int id;
        private string nameSale;
        private DateTime timeStart;
        private DateTime timeEnd;
        private int saleOff;

        public Sales() { }

        public Sales(int id, string nameSale, DateTime timeStart, DateTime timeEnd,int saleOff)
        {
            this.Id = id;
            this.NameSale = nameSale;
            this.TimeStart = timeStart;
            this.TimeEnd = timeEnd;
            this.SaleOff = saleOff;
        }

        public int Id { get => id; set => id = value; }
        public int SaleOff { get => saleOff; set => saleOff = value; }
        public string NameSale { get => nameSale; set => nameSale = value; }
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }
        public DateTime TimeEnd { get => timeEnd; set => timeEnd = value; }
    }
}
