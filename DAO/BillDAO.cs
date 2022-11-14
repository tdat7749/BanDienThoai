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
            string query = @"  select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByCustomerID(string id)
        {
            Connection.Conn.Open();
            string query = @$"  select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE UserId = {id}";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByCustomerName(string fullName)
        {
            Connection.Conn.Open();
            string query = @$"  select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.FullName LIKE N'%{fullName}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByPrice(string priceFrom, string priceTo)
        {
            Connection.Conn.Open();
            string query = @$"select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.Total BETWEEN {priceFrom} AND {priceTo}";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByPriceFrom(string priceFrom)
        {
            Connection.Conn.Open();
            string query = @$"select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.Total >= {priceFrom}";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByPriceTo(string priceTo)
        {
            Connection.Conn.Open();
            string query = @$"select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.Total <= {priceTo}";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByDateCreate(string dateFrom, string dateTo)
        {
            Connection.Conn.Open();
            string query = @$"select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.DateCreate BETWEEN '{dateFrom}' AND '{dateTo}'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetBillByDateFrom(string dateFrom)
        {
            Connection.Conn.Open();
            string query = @$"select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.DateCreate >= {dateFrom}";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }
        public static DataTable GetBillByDateTo(string dateTo)
        {
            Connection.Conn.Open();
            string query = @$"select Bill.Id, Bill.UserId, Bill.FullName, Bill.DateCreate,Bill.Total, CONCAT(Staff.FirstName,' ',Staff.LastName) As StaffFullName from Bill
  INNER JOIN dbo.Staff on Bill.StaffId = Staff.Id WHERE Bill.DateCreate <= {dateTo}";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

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
        public static int GetLastID()
        {
            Connection.Conn.Open();
            string query = "SELECT TOP 1 Id as LastID FROM Bill ORDER BY Id DESC";
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