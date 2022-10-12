﻿using BanDienThoai.DTO;
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
            string query = "Select * From Product";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        [Obsolete]
        public static void CreateProduct(Product product)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Product(NameProduct,Price,Amount,Description,Image,CategoryId)
                           VALUES (@NameProduct,@Price,@Amount,@Description,@Image,@CategoryId)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = product.Name;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;
            command.Parameters.Add("@Amount", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = product.Description;
            command.Parameters.Add("@Image", SqlDbType.NVarChar).Value = product.Image;
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = product.CategoryID;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdateProduct(Product product)
        {
            Connection.Conn.Open();
            string query = @"Update Product Set
                            NameProduct = @NameProduct,
                            Price = @Price,
                            Amount = @Amount,
                            Description = @Description,
                            Email = @Email,
                            Image = @Image,
                            CategoryId = @CategoryId,
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = product.Name;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;
            command.Parameters.Add("@Amount", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = product.Description;
            command.Parameters.Add("@Image", SqlDbType.NVarChar).Value = product.Image;
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = product.CategoryID;
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
    }
}