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
    internal class StaffDAO
    {
        public static DataTable GetAllStaff()
        {
            Connection.Conn.Open();
            string query = @"select Staff.Id, 
                            Staff.FirstName,
                            Staff.LastName,
                            Staff.GioiTinh,
                            Staff.PhoneNumber
                            from Staff inner join TaiKhoan on Staff.Id = TaiKhoan.StaffId where TaiKhoan.Status = 1";
            ;
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetStaffByName(string name)
        {
            Connection.Conn.Open();
            string query = $@"select Staff.Id, 
                            Staff.FirstName,
                            Staff.LastName,
                            Staff.GioiTinh,
                            Staff.PhoneNumber
                            from Staff
                            WHERE Staff.LastName = N'{name}' OR Staff.LastName = '{name}'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static void CreateStaff(Staff Staff)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Staff(FirstName,LastName,GioiTinh,PhoneNumber)
                           VALUES (@FirstName,@LastName,@GioiTinh,@PhoneNumber)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = Staff.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = Staff.LastName;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = Staff.GioiTinh;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = Staff.PhoneNumber;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateStaff(Staff Staff)
        {
            Connection.Conn.Open();
            string query = @"Update Staff Set
                            FirstName = @FirstName,
                            LastName = @LastName,
                            GioiTinh = @GioiTinh,
                            PhoneNumber = @PhoneNumber 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = Staff.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = Staff.LastName;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = Staff.GioiTinh;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = Staff.PhoneNumber;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Staff.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteStaff(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Staff Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static int GetLastID()
        {
            Connection.Conn.Open();
            string query = "SELECT TOP 1 Id as LastID FROM Staff ORDER BY Id DESC";
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

        public static int GetSoLuongStaff()
        {
            Connection.Conn.Open();
            string query = "SELECT COUNT(Id) as SoLuong from Staff";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataReader sr = null;
            sr = command.ExecuteReader();

            if (sr.Read())
            {
                int soLuong = int.Parse(sr["SoLuong"].ToString());
                Connection.Conn.Close();
                return soLuong;
            }
            Connection.Conn.Close();
            return -1;
        }
    }
}
