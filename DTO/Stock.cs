using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    internal class Stock
    {
        private int productId;
        private int quantity;
        private int detailImportId;

        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int DetailImportId { get => detailImportId; set => detailImportId = value; }

        public Stock(int productId, int quantity, int detailImportId)
        {
            this.ProductId = productId;
            this.Quantity = quantity;
            this.DetailImportId = detailImportId;
        }

        public Stock()
        {

        }
    }
}
