using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class DetailBill
    {
        private int id;
        private int billId;
        private int productId;
        private string nameProduct;
        private decimal price;
        private int amount;
        private decimal total;

        public int Id { get => id; set => id = value; }
        public int BillId { get => billId; set => billId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public decimal Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public decimal Total { get => total; set => total = value; }

        public DetailBill(int id, int billID, int productID, string nameProduct, decimal price, int amount, decimal total)
        {
            this.Id = id;
            this.BillId = billID;
            this.ProductId = productID;
            this.NameProduct = nameProduct;
            this.Price = price;
            this.Amount = amount;
            this.Total = total;
        }

        public DetailBill()
        {

        }
    }
}
