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
    internal class PermissionDAO
    {
        public static DataTable GetAllPermiss()
        {
            Connection.Conn.Open();
            string query = "Select * From Permission";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        [Obsolete]
        public static void CreatePermiss(Permission per)
        {
            Connection.Conn.Open();
            string query = "INSERT INTO Permission(NamePermiss) VALUES (@NamePermiss)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NamePermiss", SqlDbType.NVarChar).Value = per.NamePermis;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdatePermiss(Permission per)
        {
            Connection.Conn.Open();
            string query = "Update Permiss Set NamePermiss = @NamePermiss Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NamePermiss", SqlDbType.NVarChar).Value = per.NamePermis;
            command.Parameters.Add("@NamePermiss", SqlDbType.Int).Value = per.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DetelePermiss(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Permission Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
