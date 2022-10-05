using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DAO
{
    internal class Connection
    {
        public static SqlConnection Conn = null;
        public Connection()
        {
            try
            {
                Conn = new SqlConnection("Data Source=localhost,1433;Initial Catalog=bandienthoai;User ID=sa;Password=Password123");
                Conn.Open();
            }
            catch
            {
                throw new Exception("Loi khong ket noi duoc toi sql server !!");
            }
        }
    }
}
