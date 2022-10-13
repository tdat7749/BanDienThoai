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
    internal class UserDAO
    {
        public static DataTable GetAllUser()
        {
            Connection.Conn.Open();
            string query = "Select * From Account";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        [Obsolete]
        public static void CreateUser(User user)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Account(FirstName,LastName,UserName,Password,Email,PhoneNumber,Address,PermissId)
                           VALUES (@FirstName,@LastName,@UserName,@Password,@Email,@PhoneNumber,@Address,@PermissId)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.LastName;
            command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = user.PhoneNumber;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@PermissId", SqlDbType.Int).Value = 1;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdateUser(User user)
        {
            Connection.Conn.Open();
            string query = @"Update Account Set
                            FirstName = @FirstName,
                            LastName = @LastName,
                            UserName = @UserName,
                            Password = @Password,
                            Email = @Email,
                            PhoneNumber = @PhoneNumber,
                            Address = @Address,
                            PermissId = @PermissId 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.LastName;
            command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = user.PhoneNumber;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@PermissId", SqlDbType.Int).Value = user.PermissId;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteUser(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Account Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
