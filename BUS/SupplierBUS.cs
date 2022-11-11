using BanDienThoai.DAO;
using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.BUS
{
    internal class SupplierBUS
    {
        public  DataTable GetAllSupplier()
        {
            return SupplierDAO.GetAllSupplier();
        }

        public DataTable GetSupplierByName(string name)
        {
            return SupplierDAO.GetSupplierByName(name);
        }

        public void CreateSupplier(Supplier supplier)
        {
            SupplierDAO.CreateSupplier(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            SupplierDAO.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int ma)
        {
            SupplierDAO.DeleteSupplier(ma);
        }
    }
}
