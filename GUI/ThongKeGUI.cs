﻿using BanDienThoai.BUS;
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
    public partial class ThongKeGUI : Form
    {
        BillBUS billBUS = new BillBUS();
        ProductBUS productBUS = new ProductBUS();
        StaffBUS staffBUS = new StaffBUS();
        DetailBillBUS detailBillBUS = new DetailBillBUS();

        public ThongKeGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThongKeGUI_Load(object sender, EventArgs e)
        {
            lbHoaDon.Text = billBUS.GetSoLuongBill().ToString();
            lbNhanVien.Text = staffBUS.GetSoLuongStaff().ToString();
            lbSanPham.Text = productBUS.GetSoLuongProduct().ToString();


            // get nam hien tai
            string nowYear = DateTime.Now.Year.ToString();
            
            // set nam hien tai cho cbb
            cbbQuy.Text = nowYear;

            // lay gia tri cua cbb
            string year = cbbQuy.GetItemText(cbbQuy.SelectedItem);

            txtQuy1.Text = billBUS.TongQuy1(year).ToString() + " VND";
            txtQuy2.Text = billBUS.TongQuy2(year).ToString() + " VND";
            txtQuy3.Text = billBUS.TongQuy3(year).ToString() + " VND";
            txtQuy4.Text = billBUS.TongQuy4(year).ToString() + " VND";


            //set gia tri cho cbb san pham
            List<string> strings = new List<string>();
            strings = productBUS.SelectNameProduct();
            foreach(string item in strings)
            {
                cbbTenSanPham.Items.Add(item);
            }

        }

        private void cbbQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cbbQuy.GetItemText(cbbQuy.SelectedItem);

            txtQuy1.Text = billBUS.TongQuy1(year).ToString() + " VND";
            txtQuy2.Text = billBUS.TongQuy2(year).ToString() + " VND";
            txtQuy3.Text = billBUS.TongQuy3(year).ToString() + " VND";
            txtQuy4.Text = billBUS.TongQuy4(year).ToString() + " VND";
        }

        private void cbbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbbTenSanPham.GetItemText(cbbTenSanPham.SelectedItem);
            int id = productBUS.GetIdByName(name);
            lbTenSanPham.Text = name;
            lbTongTien.Text = detailBillBUS.GetTotalDetailBillByProductId(id) + "VND";
        }
    }
}