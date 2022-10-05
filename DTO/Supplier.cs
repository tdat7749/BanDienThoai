using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appp11
{
    internal class Supplier
    {
        private int id;
        private string nameSupplier;
        private string addressSupplier;


        public Supplier() { }
        public Supplier(int id, string nameSupplier, string addressSupplier)
        {
            this.Id = id;
            this.NameSupplier = nameSupplier;
            this.AddressSupplier = addressSupplier;
        }

        public int Id { get => id; set => id = value; }
        public string NameSupplier { get => nameSupplier; set => nameSupplier = value; }
        public string AddressSupplier { get => addressSupplier; set => addressSupplier = value; }
    }
}
