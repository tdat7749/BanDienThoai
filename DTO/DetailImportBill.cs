using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class DetaiImportlBill
    {
        private int id;
        private int importID;
        private int productID;
        private string nameProduct;
        private decimal price;
        private int amount;
        private decimal total;

        public int Id { get => id; set => id = value; }
        public int ImportID { get => importID; set => importID = value; }   
        public int ProductID { get => productID; set => productID = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public decimal Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public decimal Total { get => total; set => total = value; }

        public DetaiImportlBill(int id, int importID, int productID, string nameProduct, decimal price, int amount, decimal total)
        {
            this.Id = id;
            this.importID = importID;
            this.ProductID = productID;
            this.NameProduct = nameProduct;
            this.Price = price;
            this.Amount = amount;
            this.Total = total;
        }

        public DetaiImportlBill()
        {

        }
    }
}
