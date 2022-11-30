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
    public class TaiKhoanDAO
    {
        public static string StaffId;
        public static string NamePermiss;
        public static string StaffName;
        public static DataTable GetAllTaiKhoan()
        {
            Connection.Conn.Open();
            string query = @"select StaffId,UserName,Password,Staff.FirstName,Staff.LastName,Staff.GioiTinh,Staff.PhoneNumber,Permission.NamePermiss,Status from TaiKhoan
                             INNER JOIN Staff on StaffId = Staff.Id
                             INNER JOIN Permission on PermissId = Permission.Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetTaiKhoanBySDT(string sdt)
        {
            Connection.Conn.Open();
            string query = $@"select StaffId,UserName,Password,Staff.FirstName,Staff.LastName,Staff.GioiTinh,Staff.PhoneNumber,Permission.NamePermiss,Status from TaiKhoan
                             INNER JOIN Staff on StaffId = Staff.Id
                             INNER JOIN Permission on PermissId = Permission.Id 
                             WHERE Staff.PhoneNumber LIKE '%{sdt}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetTaiKhoanByChucVu(string chucVu)
        {
            Connection.Conn.Open();
            string query = $@"select StaffId,UserName,Password,Staff.FirstName,Staff.LastName,Staff.GioiTinh,Staff.PhoneNumber,Permission.NamePermiss,Status from TaiKhoan
                             INNER JOIN Staff on StaffId = Staff.Id
                             INNER JOIN Permission on PermissId = Permission.Id 
                             WHERE Permission.NamePermiss LIKE N'%{chucVu}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetTaiKhoanByStaffName(string staffName)
        {
            Connection.Conn.Open();
            string query = $@"select StaffId,UserName,Password,Staff.FirstName,Staff.LastName,Staff.GioiTinh,Staff.PhoneNumber,Permission.NamePermiss,Status from TaiKhoan
                             INNER JOIN Staff on StaffId = Staff.Id
                             INNER JOIN Permission on PermissId = Permission.Id 
                             WHERE Staff.LastName LIKE N'%{staffName}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static bool CheckLogin(string userName,string password)
        {
            Connection.Conn.Open();
            string query = $@"select StaffId,Permission.NamePermiss,CONCAT(Staff.FirstName,' ',Staff.LastName) AS StaffName from TaiKhoan
                             INNER JOIN Staff on StaffId = Staff.Id
                             INNER JOIN Permission on PermissId = Permission.Id
                            WHERE UserName = '{userName}' AND Password = '{password}' AND Status = 1";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataReader sqlData = null;
            sqlData = command.ExecuteReader();
            if (sqlData.Read())
            {
                NamePermiss = sqlData["NamePermiss"].ToString();
                StaffId = sqlData["StaffId"].ToString();
                StaffName = sqlData["StaffName"].ToString();
                Connection.Conn.Close();
                return true;
            }
            Connection.Conn.Close();
            return false;
        }

        public static void CreateTaiKhoan(TaiKhoan taikhoan)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO TaiKhoan(StaffId,UserName,Password,PermissId,Status)
                           VALUES (@StaffId,@UserName,@Password,@PermissId,@Status)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@StaffId", SqlDbType.NVarChar).Value = taikhoan.StaffId;
            command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = taikhoan.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = taikhoan.Password;
            command.Parameters.Add("@PermissId", SqlDbType.Int).Value = taikhoan.PermissId;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = taikhoan.Status;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateTaiKhoan(TaiKhoan taikhoan)
        {
            Connection.Conn.Open();
            string query = @"Update TaiKhoan Set
                            UserName = @UserName,
                            Password = @Password,
                            PermissId = @PermissId,
                            Status = @Status 
                            Where StaffId = @StaffId";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = taikhoan.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = taikhoan.Password;
            command.Parameters.Add("@PermissId", SqlDbType.NVarChar).Value = taikhoan.PermissId;
            command.Parameters.Add("@StaffId", SqlDbType.NVarChar).Value = taikhoan.StaffId;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = taikhoan.Status;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteTaiKhoan(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From TaiKhoan Where StaffId = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
