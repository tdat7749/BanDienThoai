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
    internal class ProductDAO
    {
        public static DataTable GetAllProduct()
        {
            Connection.Conn.Open();
            string query = @"select Product.Id,Product.NameProduct,Product.Price,Product.Description,Product.Stock,Image ,Category.CategoryName, Category.Id , Status
from Product 
INNER JOIN Category on Product.CategoryId = Category.Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetAllProductStatus()
        {
            Connection.Conn.Open();
            string query = @"select Product.Id,Product.NameProduct,Product.Price,Product.Description,Product.Stock,Image ,Category.CategoryName, Category.Id, Product.Status
                            from Product 
                            INNER JOIN Category on Product.CategoryId = Category.Id
                            WHERE Status = 1";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetProductByName(string name)
        {
            Connection.Conn.Open();
            string query = @$"select Product.Id,Product.NameProduct,Product.Price,Product.Description,Product.Stock,Category.CategoryName 
                            from Product 
                            INNER JOIN Category on Product.CategoryId = Category.Id 
                            where NameProduct LIKE '%{name}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        public static DataTable GetProductByCategory(string name)
        {
            Connection.Conn.Open();
            string query = @$"select Product.Id,Product.NameProduct,Product.Price,Product.Description,Product.Stock,Category.CategoryName 
                            from Product 
                            INNER JOIN Category on Product.CategoryId = Category.Id 
                            where CategoryName LIKE '%{name}%'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }


        public static void CreateProduct(Product product)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Product(NameProduct,Price,Stock,Description,Image,CategoryId,Status)
                           VALUES (@NameProduct,@Price,@Stock,@Description,@Image,@CategoryId,@Status)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = product.Name;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;
            command.Parameters.Add("@Stock", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = product.Description;
            command.Parameters.Add("@Image", SqlDbType.NVarChar).Value = product.Image;
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = product.CategoryID;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = product.Status;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateProduct(Product product)
        {
            //                            Amount = @Amount,

            Connection.Conn.Open();
            string query = @"Update Product Set
                            NameProduct = @NameProduct,
                            Price = @Price,
                            Description = @Description,
                            Image = @Image,
                            CategoryId = @CategoryId,
                            Status = @Status 
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = product.Name;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;
            //command.Parameters.Add("@Amount", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = product.Description;
            command.Parameters.Add("@Image", SqlDbType.NVarChar).Value = product.Image;
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = product.CategoryID;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = product.Status;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteProduct(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Product Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void UpdateStockProduct(int ma,int stock)
        {
            Connection.Conn.Open();
            string query = $"UPDATE Product SET Stock = Stock + @Stock WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.Parameters.Add("@Stock", SqlDbType.Int).Value = stock;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void MinusStockProduct(int ma, int stock)
        {
            Connection.Conn.Open();
            string query = $"UPDATE Product SET Stock = Stock - @Stock WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.Parameters.Add("@Stock", SqlDbType.Int).Value = stock;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static int GetSoLuongProduct()
        {
            Connection.Conn.Open();
            string query = "SELECT COUNT(Id) as SoLuong from Product";
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

        public static List<string> SelectNameProduct()
        {
            try
            {
                Connection.Conn.Open();
                string query = "SELECT NameProduct from Product";
                SqlCommand command = new SqlCommand(query, Connection.Conn);
                SqlDataReader sr = null;
                sr = command.ExecuteReader();

                List<string> list = new List<string>();

                while (sr.Read())
                {
                    list.Add(sr["NameProduct"].ToString());
                }
                Connection.Conn.Close();
                return list;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                Connection.Conn.Close();;
                return null;
            }
        }

        public static int GetIdByName(string name)
        {
            Connection.Conn.Open();
            string query = $"SELECT Id from Product WHERE NameProduct = '{name}'";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataReader sr = null;
            sr = command.ExecuteReader();

            if (sr.Read())
            {
                int Id = int.Parse(sr["Id"].ToString());
                Connection.Conn.Close();
                return Id;
            }
            Connection.Conn.Close();
            return -1;
        }
    }
}
