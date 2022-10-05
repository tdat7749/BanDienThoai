using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appp11
{
    internal class Sales
    {
        private int id;
        private string nameSale;
        private DateTime timeStart;
        private DateTime timeEnd;


        public Sales() { }

        public Sales(int id, string nameSale, DateTime timeStart, DateTime timeEnd)
        {
            this.Id = id;
            this.NameSale = nameSale;
            this.TimeStart = timeStart;
            this.TimeEnd = timeEnd;
        }

        public int Id { get => id; set => id = value; }
        public string NameSale { get => nameSale; set => nameSale = value; }
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }
        public DateTime TimeEnd { get => timeEnd; set => timeEnd = value; }
    }
}
