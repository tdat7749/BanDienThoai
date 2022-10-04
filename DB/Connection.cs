using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BanDienThoai.DB
{
    public class Connection
    {
        public Connection()
        {
            try
            {
                string sqlconnectStr = "Data Source=localhost,1433;Initial Catalog=webappapi;User ID=sa;Password=Password123";
                SqlConnection connection = new SqlConnection(sqlconnectStr);           
                connection.Open();

                using (var command = connection.CreateCommand())
                {

                    command.CommandText = "Select * From Product";

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var sUserId = reader["Id"].ToString();
                        var username = reader["Name"].ToString();
                        var password = reader["Price"].ToString();

                        Console.WriteLine("{0}=={1}=={2}", sUserId, username, password);
                    }
                }
            }
            catch
            {
                throw new Exception("Loi ket noi db");
            }
        }
    }
}
