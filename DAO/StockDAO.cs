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
    internal class StockDAO
    {
        [Obsolete]
        public static void CreateStock(Stock stock)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Stock(ProductId,Quantity,DetailImportId)
                           VALUES (@ProductId,@Quantity,@DetailImportId)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@ProductId", SqlDbType.Int).Value = stock.ProductId;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = stock.Quantity;
            command.Parameters.Add("@DetailImportId", SqlDbType.Int).Value = stock.DetailImportId;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdateStock(Stock stock)
        {
            Connection.Conn.Open();
            string query = @"Update Stock Set
                            Quantity = @Quantity
                            Where DetailImportId = @DetailImportId";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = stock.Quantity;
            command.Parameters.Add("@Price", SqlDbType.Int).Value = stock.DetailImportId;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
