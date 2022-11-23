using BanDienThoai.BUS;
using BanDienThoai.DAO;
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
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        DataTable tbTop5 = new DataTable();

        public ThongKeGUI()
        {
            InitializeComponent();
            label11.BackColor = SetTransparency(50,Color.White);
            label14.BackColor = SetTransparency(50, Color.White);
        }

	static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
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

            dgvTongChiTieu.DataSource = billBUS.TongChiTieu();

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

        private void btnBaoCaoQuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn in báo cáo này chứ ?", "Sản Phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InBaoCaoQuy();
            }
        }

        private void btnBaoCaoKH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn in báo cáo này chứ ?", "Sản Phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InBaoCaoTop5();
            }
        }

        public void InBaoCaoTop5()
        {
            pddBaoCaoTop5.Document = pdBaoCaoTop5;
            pddBaoCaoTop5.ShowDialog();
        }

        public void InBaoCaoQuy()
        {
            pddBaoCaoQuy.Document = pdBaoCaoQuy;
            pddBaoCaoQuy.ShowDialog();
        }

        private void pdBaoCaoTop5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var w = pdBaoCaoTop5.DefaultPageSettings.PaperSize.Width;


            tbTop5 = billBUS.TongChiTieu();

            //vẽ header của bill
            //1. tên cửa hàng 
            e.Graphics.DrawString("Nhóm 8 Bán Điện Thoại", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(30, 20));

            //2. địa chỉ và số điện thoại
            e.Graphics.DrawString(string.Format("{0} - {1}", "273 An Dương Vương, phường 2, quận 5, TP HCM", "0999999999"), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(30, 45));

            e.Graphics.DrawString("Top 5 Tổng Chi Tiêu Của Khách Hàng", new Font("Courier New", 18, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 270, 45 + 20));

            //định dạng bút vẽ
            Pen blackPen = new Pen(Color.Black, 1);
            var y = 70;
            

            //định nghĩa 2 điểm để vẽ đường thẳng
            //cách lề trái 10, lề phải 10
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            //kẻ đường thẳng thứ nhất
            //e.Graphics.DrawLine(blackPen, p1, p2);


            //y += 10;
            //e.Graphics.DrawString(String.Format("Ngày Lập Hóa Đơn: {0}", ((DateTime)dtHoaDon.Rows[0]["DateCreate"]).ToString("dd/MM/yyyy")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            //y += 20;

            //e.Graphics.DrawString(String.Format("Mã Khách Hàng: {0}", (dtHoaDon.Rows[0]["UserId"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            //y += 20;

            //e.Graphics.DrawString(String.Format("Tên Khách Hàng: {0}", (dtHoaDon.Rows[0]["FullName"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));

            //y += 20;
            //e.Graphics.DrawString(String.Format("Nhân Viên Lập Hóa Đơn: {0}", (dtHoaDon.Rows[0]["StaffFullName"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));

            //y += 10;



            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 2
            y += 40;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            e.Graphics.DrawString("STT", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Họ", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString("Tên", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(200, y));
            e.Graphics.DrawString("Số Điện Thoại", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(400, y));
            e.Graphics.DrawString("Tổng Chi Tiêu (VND)", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(650, y));



            int i = 1;
            y += 20;

            foreach (DataRow row in tbTop5.Rows)
            {
                e.Graphics.DrawString(string.Format("{0}", i++), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(row["FirstName"].ToString(), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(row["LastName"].ToString(), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(200, y));
                e.Graphics.DrawString(row["PhoneNumber"].ToString(), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(400, y));
                e.Graphics.DrawString(string.Format("{0:N0}", row["TongChiTieu"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(650, y));
                y += 20;
            }

            y += 40;
            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 3
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            //tổng tiền thanh toán
            //y += 20;
            //e.Graphics.DrawString(string.Format("Tổng tiền: {0:N0} VNĐ", dtHoaDon.Rows[0]["Total"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));

            //đọc số thành chữ
            y += 40;
            e.Graphics.DrawString("Quản trị viên lập báo cáo : " + TaiKhoanDAO.StaffName, new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
        }

        private void pdBaoCaoQuy_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var w = pdBaoCaoQuy.DefaultPageSettings.PaperSize.Width;
            string year = cbbQuy.GetItemText(cbbQuy.SelectedItem);

            //vẽ header của bill
            //1. tên cửa hàng 
            e.Graphics.DrawString("Nhóm 8 Bán Điện Thoại", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(30, 20));

            //2. địa chỉ và số điện thoại
            e.Graphics.DrawString(string.Format("{0} - {1}", "273 An Dương Vương, phường 2, quận 5, TP HCM", "0999999999"), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(30, 45));

            e.Graphics.DrawString("Báo Cáo Theo Quý Năm : " + year, new Font("Courier New", 18, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 235, 45 + 20));

            //định dạng bút vẽ
            Pen blackPen = new Pen(Color.Black, 1);
            var y = 70;


            //định nghĩa 2 điểm để vẽ đường thẳng
            //cách lề trái 10, lề phải 10
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            //kẻ đường thẳng thứ nhất
            //e.Graphics.DrawLine(blackPen, p1, p2);


            //y += 10;
            //e.Graphics.DrawString(String.Format("Ngày Lập Hóa Đơn: {0}", ((DateTime)dtHoaDon.Rows[0]["DateCreate"]).ToString("dd/MM/yyyy")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            //y += 20;

            //e.Graphics.DrawString(String.Format("Mã Khách Hàng: {0}", (dtHoaDon.Rows[0]["UserId"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            //y += 20;

            //e.Graphics.DrawString(String.Format("Tên Khách Hàng: {0}", (dtHoaDon.Rows[0]["FullName"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));

            //y += 20;
            //e.Graphics.DrawString(String.Format("Nhân Viên Lập Hóa Đơn: {0}", (dtHoaDon.Rows[0]["StaffFullName"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));

            //y += 10;



            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 2
            y += 40;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            e.Graphics.DrawString("Quý", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 150, y));
            e.Graphics.DrawString("Tổng Tiền", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 20, y));

     

            y += 20;

            e.Graphics.DrawString("1", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 150, y));
            e.Graphics.DrawString(billBUS.TongQuy1(year).ToString() + " VND", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 20, y));
            y += 20;

            e.Graphics.DrawString("2", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 150, y));
            e.Graphics.DrawString(billBUS.TongQuy2(year).ToString() + " VND", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 20, y));
            y += 20;

            e.Graphics.DrawString("3", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 150, y));
            e.Graphics.DrawString(billBUS.TongQuy3(year).ToString() + " VND", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 20, y));
            y += 20;

            e.Graphics.DrawString("4", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 150, y));
            e.Graphics.DrawString(billBUS.TongQuy4(year).ToString() + " VND", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 20, y));
            y += 20;



            y += 40;
            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 3
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            //tổng tiền thanh toán
            //y += 20;
            //e.Graphics.DrawString(string.Format("Tổng tiền: {0:N0} VNĐ", dtHoaDon.Rows[0]["Total"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));

            //đọc số thành chữ
            y += 40;
            e.Graphics.DrawString("Quản trị viên lập báo cáo : " + TaiKhoanDAO.StaffName, new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
        }
    }
}
