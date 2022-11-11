using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DAO
{
    internal class SupplierDAO
    {
        public static DataTable GetAllSupplier()
        {
            Connection.Conn.Open();
            string query = "Select * From Supplier";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetSupplierByName(string name)
        {
            Connection.Conn.Open();
            string query = @$"select Id, NameSupplier, AddressSupplier from dbo.Supplier where NameSupplier LIKE '%{name}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static void CreateSupplier(Supplier supplier)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Supplier(NameSupplier,AddressSupplier)
                           VALUES (@NameSupplier,@AddressSupplier)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameSupplier", SqlDbType.NVarChar).Value = supplier.NameSupplier;
            command.Parameters.Add("@AddressSupplier", SqlDbType.NVarChar).Value = supplier.AddressSupplier;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateSupplier(Supplier Supplier)
        {
            Connection.Conn.Open();
            string query = @"Update Supplier Set
                            NameSupplier = @NameSupplier,
                            AddressSupplier = @AddressSupplier 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameSupplier", SqlDbType.NVarChar).Value = Supplier.NameSupplier;
            command.Parameters.Add("@AddressSupplier", SqlDbType.NVarChar).Value = Supplier.AddressSupplier;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Supplier.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteSupplier(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Supplier Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
