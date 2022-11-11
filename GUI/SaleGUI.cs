﻿using BanDienThoai.BUS;
using BanDienThoai.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDienThoai.GUI
{
    public partial class SaleGUI : Form
    {
        SalesBUS salesBUS = new SalesBUS();
        public SaleGUI()
        {
            InitializeComponent();
            GetAllSales();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void GetAllSales()
        {
            dgvSale.DataSource = salesBUS.GetAllSales();
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSale.CurrentRow.Index;
            if (i >= 0)
            {
                txtID.Text = dgvSale.Rows[i].Cells[0].Value.ToString();
                txtTenKhuyenMai.Text = dgvSale.Rows[i].Cells[1].Value.ToString();
                txtKhuyenMai.Text = dgvSale.Rows[i].Cells[4].Value.ToString();
                dtpNgayBatDau.Value = (DateTime) dgvSale.Rows[i].Cells[2].Value;
                dtpNgayKetThuc.Value = (DateTime) dgvSale.Rows[i].Cells[3].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKhuyenMai.Text == "" && txtKhuyenMai.Text == "")
            {
                MessageBox.Show("Không được để trống", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Chọn sai ngày rồi kìa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sales sale = new Sales();
            sale.NameSale = txtTenKhuyenMai.Text.Trim();
            sale.SaleOff = int.Parse(txtKhuyenMai.Text.Trim());
            sale.TimeStart = (DateTime)dtpNgayBatDau.Value;
            sale.TimeEnd = (DateTime)dtpNgayKetThuc.Value;


            salesBUS.CreateSale(sale);

            GetAllSales();
            MessageBox.Show("Thêm Thành Công !");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khuyến mãi để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenKhuyenMai.Text == "" && txtKhuyenMai.Text == "")
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Chọn sai ngày rồi kìa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sales sale = new Sales();
            sale.Id = int.Parse(txtID.Text.Trim());
            sale.NameSale = txtTenKhuyenMai.Text.Trim();
            sale.SaleOff = int.Parse(txtKhuyenMai.Text.Trim());
            sale.TimeStart = (DateTime)dtpNgayBatDau.Value;
            sale.TimeEnd = (DateTime)dtpNgayKetThuc.Value;


            salesBUS.UpdateSale(sale);

            GetAllSales();
            MessageBox.Show("Sửa Thành Công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khuyến mãi để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            salesBUS.DeleteSale(int.Parse(txtID.Text.Trim()));

            GetAllSales();
            MessageBox.Show("Xóa Thành Công !");
        }
    }
}