using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class Permission
    {
        private int id;
        private string namePermis;

        public int Id { get => id; set => id = value; }
        public string NamePermis { get => namePermis; set => namePermis = value; }

        public Permission(int id,string namePermis)
        {
            this.Id = id;
            this.NamePermis = namePermis;
        }

        public Permission()
        {

        }
    }
}
