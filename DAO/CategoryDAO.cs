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
    internal class CategoryDAO
    {
        public static DataTable GetAllCategory()
        {
            Connection.Conn.Open();
            string query = "Select * From Category";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Connection.Conn.Close();
            return dt;
        }

        [Obsolete]
        public static void CreateCategory(Category category)
        {
            Connection.Conn.Open();
            string query = @"INSERT INTO Category(CategoryName)
                           VALUES (@CategoryName)";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = category.CategoryName;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        [Obsolete]
        public static void UpdateCategory(Category category)
        {
            Connection.Conn.Open();
            string query = @"Update Category Set
                            CategoryName = @CategoryName,
                            Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = category.CategoryName;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = category.Id;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }

        public static void DeleteCategory(int ma)
        {
            Connection.Conn.Open();
            string query = "Delete From Category Where Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection.Conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
            command.ExecuteNonQuery();
            Connection.Conn.Close();
        }
    }
}
