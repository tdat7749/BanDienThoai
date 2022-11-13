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
                            Staff.ChucVu
                            from Staff";
            ;
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
            string query = @"INSERT INTO Staff(FirstName,LastName,GioiTinh,ChucVu)
                           VALUES (@FirstName,@LastName,@GioiTinh,@ChucVu)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = Staff.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = Staff.LastName;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = Staff.GioiTinh;
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = Staff.ChucVu;
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
                            ChucVu = @ChucVu 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = Staff.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = Staff.LastName;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = Staff.GioiTinh;
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = Staff.ChucVu;
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
    }
}
