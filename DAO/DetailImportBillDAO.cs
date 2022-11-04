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
    public class DetailImportBillDAO
    {
        public static DataTable GetAllDetailImportBill()
        {
            Connection.Conn.Open();
            string query = "Select * From DetailImportBill";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static void CreateDetailImportBill(DetailImportBill detailImportBill)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO DetailImportBill(ImportId,ProductId,NameProduct,Amount,Price,Total)
                           VALUES (@ImportId,@ProductId,@NameProduct,@Amount,@Price,@Total)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@ImportId", SqlDbType.Int).Value = detailImportBill.ImportID;
            command.Parameters.Add("@ProductId", SqlDbType.Int).Value = detailImportBill.ProductID;
            command.Parameters.Add("NameProduct", SqlDbType.NVarChar).Value = detailImportBill.NameProduct;
            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = detailImportBill.Amount;
            command.Parameters.Add("@Price", SqlDbType.Int).Value = detailImportBill.Price;
            command.Parameters.Add("@Total", SqlDbType.Decimal).Value = detailImportBill.Total;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateDetailImportBill(DetailImportBill detailImportBill)
        {
            Connection.Conn.Open();
            string query = @"Update DetailImportBill Set
                            ImportId = @ImportId,
                            ProductId = @ProductId,
                            NameProduct = @NameProduct,
                            Amount = @Amount,
                            Price = @Price,
                            Total = @Total 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@ImportId", SqlDbType.Int).Value = detailImportBill.ImportID;
            command.Parameters.Add("@ProductId", SqlDbType.Int).Value = detailImportBill.ProductID;
            command.Parameters.Add("NameProduct", SqlDbType.NVarChar).Value = detailImportBill.NameProduct;
            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = detailImportBill.Price;
            command.Parameters.Add("@Price", SqlDbType.Int).Value = detailImportBill.Amount;
            command.Parameters.Add("@Total", SqlDbType.Decimal).Value = detailImportBill.Total;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = detailImportBill.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteDetailImportBill(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From DetailImportBill Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
