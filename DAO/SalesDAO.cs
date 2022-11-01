using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DAO
{
    public class SalesDAO
    {
        public static DataTable GetAllSales()
        {
            Connection.Conn.Open();
            string query = "Select NameSale, TimeStart, TimeEnd From Sale";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static void CreateSale(Sales sale)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Sale(NameSale,TimeStart,TimeEnd)
                           VALUES (@NameSale,@TimeStart,@TimeEnd)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameSale", SqlDbType.NVarChar).Value = sale.NameSale;
            command.Parameters.Add("@TimeStart", SqlDbType.DateTime).Value = sale.TimeStart;
            command.Parameters.Add("@TimeEnd", SqlDbType.DateTime).Value = sale.TimeEnd;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateSale(Sales sale)
        {
            Connection.Conn.Open();
            string query = @"Update Sale Set
                            NameSale = @NameSale,
                            TimeStart = @TimeStart,
                            TimeEnd = @TimeEnd  
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameSale", SqlDbType.NVarChar).Value = sale.NameSale;
            command.Parameters.Add("@TimeStart", SqlDbType.DateTime).Value = sale.TimeStart;
            command.Parameters.Add("@TimeEnd", SqlDbType.DateTime).Value = sale.TimeEnd;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteSale(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Sale Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
