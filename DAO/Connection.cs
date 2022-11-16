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
                Conn = new SqlConnection("Data Source=LAPTOP-ED3BE250; Initial Catalog=bandienthoai1; Integrated Security=True");
                //Conn = new SqlConnection("Data Source=cai cho nay vao sql server xem; Initial Catalog=bandienthoai; Integrated Security=True");
                // Dinh Thinh: LAPTOP-L8E8SO4G\\CYRUS
            }
            catch
            {
                throw new Exception("Loi khong ket noi duoc toi sql server !!");
            }
        }
    }
}
