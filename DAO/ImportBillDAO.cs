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
    public class ImportBillDAO
    {
        public static DataTable GetAllImportBill()
        {
            Connection.Conn.Open();
            string query = "Select * From ImportBill";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static void CreateImportBill(ImportBill importBill)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO ImportBill(SupplierId,StaffId,DateCreate,Total)
                           VALUES (@SupplierId,@StaffId,@DateCreate,@Total)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = importBill.SupplierID;
            command.Parameters.Add("@StaffId", SqlDbType.Int).Value = importBill.StaffID;
            command.Parameters.Add("DateCreate", SqlDbType.DateTime).Value = importBill.DateCreate;
            command.Parameters.Add("@Total", SqlDbType.Decimal).Value = importBill.Total;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateImportBill(ImportBill importBill)
        {
            Connection.Conn.Open();
            string query = @"Update ImportBill Set
                            SupplierId = @SupplierId,
                            StaffId = @StaffId,
                            DateCreate = @DateCreate,
                            Total = @Total,                          
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = importBill.SupplierID;
            command.Parameters.Add("@StaffId", SqlDbType.Int).Value = importBill.StaffID;
            command.Parameters.Add("@DateCreate", SqlDbType.DateTime).Value = importBill.DateCreate;
            command.Parameters.Add("@Total", SqlDbType.Decimal).Value = importBill.Total;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = importBill.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteImportBill(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From ImportBill Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static int GetLastID()
        {
            Connection.Conn.Open();
            string query = "SELECT TOP 1 Id as LastID FROM ImportBill ORDER BY Id DESC";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataReader sr = null;
            sr = command.ExecuteReader();

            if (sr.Read())
            {
                int id = int.Parse(sr["LastID"].ToString());
                Connection.Conn.Close();
                return id;
            }
            Connection.Conn.Close();
            return -1;
        }
    }
}
