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
    internal class ImportBillDAO
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

        [Obsolete]
        public static void CreateImportBill(ImportBill importBill)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO ImportBill(SupplierId,UserId,DateCreate,Total)
                           VALUES (@SupplierId,@UserId,@DateCreate,@Total)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = importBill.SupplierID
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = importBill.UserID;
            command.Parameters.Add("DateCreate", SqlDbType.DateTime).Value = importBill.CreateTime;
            command.Parameters.Add("@Total", SqlDbType.Decimal).Value = importBill.Total;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdateImportBill(ImportBill importBill)
        {
            Connection.Conn.Open();
            string query = @"Update ImportBill Set
                            SupplierId = @SupplierId,
                            UserId = @UserId,
                            DateCreate = @DateCreate,
                            Total = @Total,                          
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = importBill.SupplierID;
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = importBill.UserID;
            command.Parameters.Add("@DateCreate", SqlDbType.DateTime).Value = importBill.CreateDate;
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
    }
}
