﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private decimal price;
        private int categoryID;
        private string image;

        public Product(int id, string name, string description, decimal price, int categoryID,string image)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.categoryID = categoryID;
            this.image = image;
        }

        public Product()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Image { get => image; set => image = value; }
    }
}