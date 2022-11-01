using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class Category
    {
        private int id;
        private string categoryName;

        public Category()
        {

        }
        public Category(int id, string categoryName)
        {
            this.Id = id;
            this.CategoryName = categoryName;
        }

        public int Id { get => id; set => id = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
