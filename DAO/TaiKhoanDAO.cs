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
        public static DataTable GetAllTaiKhoan()
        {
            Connection.Conn.Open();
            string query = @"select * from TaiKhoan";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static void CreateTaiKhoan(TaiKhoan taikhoan)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO TaiKhoan(StaffId,UserName,Password,PermissId)
                           VALUES (@StaffId,@UserName,@Password,@PermissId)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@StaffId", SqlDbType.NVarChar).Value = taikhoan.StaffId;
            command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = taikhoan.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = taikhoan.Password;
            command.Parameters.Add("@PermissId", SqlDbType.Int).Value = 2;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateTaiKhoan(TaiKhoan taikhoan)
        {
            Connection.Conn.Open();
            string query = @"Update Product Set
                            StaffId = @StaffId,
                            UserName = @UserName,
                            Password = @Password,
                            PermissId = @PermissId
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@StaffId", SqlDbType.NVarChar).Value = taikhoan.StaffId;
            command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = taikhoan.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = taikhoan.Password;
            command.Parameters.Add("@PermissId", SqlDbType.NVarChar).Value = taikhoan.PermissId;
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
