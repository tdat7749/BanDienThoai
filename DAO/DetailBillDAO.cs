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
	internal class DetailBillDAO
	{
		public static DataTable GetAllDetailBill()
		{
			Connection.Conn.Open();
			string query = "Select * From DetailBill";
			SqlCommand command = new SqlCommand(query, Connection.Conn);
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = command;
			DataTable dt = new DataTable();
			dataAdapter.Fill(dt);
			Connection.Conn.Close();
			return dt;
		}

		public static void CreateDetailBill(DetailBill detailBill)
		{
			Connection.Conn.Open();
			string query = @"INSERT INTO DetailBill(BillId,ProductId,NameProduct,Price,Amount,Total)
                           VALUES (@BillId,@ProductId,@NameProduct,@Price,@Amount,@Total)";
			SqlCommand command = new SqlCommand(query, Connection.Conn);
			command.Parameters.Add("@BillId", SqlDbType.Int).Value = detailBill.BillId;
			command.Parameters.Add("@ProductId", SqlDbType.Int).Value = detailBill.ProductId;
			command.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = detailBill.NameProduct;
			command.Parameters.Add("@Price", SqlDbType.Money).Value = detailBill.Price;
			command.Parameters.Add("@Amount", SqlDbType.Int).Value = detailBill.Amount;
			command.Parameters.Add("@Total", SqlDbType.Money).Value = detailBill.Total;
			command.ExecuteNonQuery();
			Connection.Conn.Close();
		}

		public static void UpdateDetailBill(DetailBill detailBill)
		{
			Connection.Conn.Open();
			string query = @"Update DetailBill Set
                            BillId = @BillId,
                            ProductId = @ProductId,
                            NameProduct = @NameProduct,
                            Price = @Price,
                            Amount = @Amount,
                            Total = @Total
                            Where Id = @Id";
			SqlCommand command = new SqlCommand(query, Connection.Conn);
			command.Parameters.Add("@BillId", SqlDbType.Int).Value = detailBill.BillId;
			command.Parameters.Add("@ProductId", SqlDbType.Int).Value = detailBill.ProductId;
			command.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = detailBill.NameProduct;
			command.Parameters.Add("@Price", SqlDbType.Money).Value = detailBill.Price;
			command.Parameters.Add("@Amount", SqlDbType.Int).Value = detailBill.Amount;
			command.Parameters.Add("@Total", SqlDbType.Money).Value = detailBill.Total;
			command.Parameters.Add("@Id", SqlDbType.Int).Value = detailBill.Id;
			command.ExecuteNonQuery();
			Connection.Conn.Close();
		}

		public static void DeleteDetailBill(int ma)
		{
			Connection.Conn.Open();
			string query = "Delete From DetailBill Where Id = @Id";
			SqlCommand command = new SqlCommand(query, Connection.Conn);
			command.Parameters.Add("@Id", SqlDbType.Int).Value = ma;
			command.ExecuteNonQuery();
			Connection.Conn.Close();
		}
	}
}