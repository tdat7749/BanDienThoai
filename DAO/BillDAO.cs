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
    internal class BillDAO
    {
        public static DataTable GetAllBill()
        {
            Connection.Conn.Open();
            string query = "Select * From Bill";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        [Obsolete]
        public static void CreateBill(Bill bill)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Bill(UserId, StaffId, FullName, DateCreate, Total)
                           VALUES (@UserId, @StaffId, @FullName, @DateCreate, @Total)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = bill.UserId;
            command.Parameters.Add("@StaffId", SqlDbType.NVarChar).Value = bill.StaffId;
            command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = bill.FullName;
            command.Parameters.Add("@DateCreate", SqlDbType.Date).Value = bill.DateCreate;
            command.Parameters.Add("@Total", SqlDbType.Money).Value = bill.Total;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdateBill(Bill bill)
        {
            Connection.Conn.Open();
            string query = @"Update Bill Set
                            UserId = @UserId,
                            StaffId = @StaffId,
                            FullName = @UserName,
                            DateCreate = @DateCreate,
                            Total = @Total 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = bill.UserId;
            command.Parameters.Add("@StaffId", SqlDbType.NVarChar).Value = bill.StaffId;
            command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = bill.FullName;
            command.Parameters.Add("@DateCreate", SqlDbType.Date).Value = bill.DateCreate;
            command.Parameters.Add("@Total", SqlDbType.Money).Value = bill.Total;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = bill.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteBill(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Bill Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}