using BanDienThoai.BUS;
using System.Data;

namespace BanDienThoai.GUI
{
    public partial class HoaDonGUI : Form
    {
        BillBUS billBUS = new BillBUS();
        DetailBillBUS detailBillBUS = new DetailBillBUS();
        DataTable dtCTHoaDon = new DataTable();
        DataTable dtHoaDon = new DataTable();
        public HoaDonGUI()
        {
            InitializeComponent();
            GetAllBill();
groupBox1.BackColor = SetTransparency(180, Color.White);
            groupBox2.BackColor = SetTransparency(180, Color.White);
            groupBox3.BackColor = SetTransparency(180, Color.White);
            groupBox4.BackColor = SetTransparency(180, Color.White);
            groupBox5.BackColor = SetTransparency(180, Color.White);
            groupBox6.BackColor = SetTransparency(180, Color.White);
            label21.BackColor = SetTransparency(50, Color.White);
        }

static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoaDonGUI_Load(object sender, EventArgs e)
        {

        }

        public void GetAllBill()
        {
            dgvHoaDon.DataSource = billBUS.GetAllBill();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvHoaDon.CurrentRow.Index;
            if(i >= 0 && dgvHoaDon.Rows[i].Cells[0].Value.ToString() != "")
            {
                txtMaHoaDon.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                txtMaKhachHang.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                txtKhachHang.Text = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                dtpNgayLap.Value = (DateTime)dgvHoaDon.Rows[i].Cells[3].Value;
                txtTongTien.Text = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
                txtNhanVien.Text = dgvHoaDon.Rows[i].Cells[5].Value.ToString();

                dgvChiTietHoaDon.DataSource = detailBillBUS.GetDetailBillByID(txtMaHoaDon.Text.Trim());
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChiTietHoaDon.CurrentRow.Index;
            if(i >= 0 && dgvChiTietHoaDon.Rows[i].Cells[0].Value.ToString() != "")
            {
                txtMaHoaDonCT.Text = dgvChiTietHoaDon.Rows[i].Cells[0].Value.ToString();
                txtMaSanPham.Text = dgvChiTietHoaDon.Rows[i].Cells[1].Value.ToString();
                txtTenSanPham.Text = dgvChiTietHoaDon.Rows[i].Cells[2].Value.ToString();
                txtDonGia.Text = dgvChiTietHoaDon.Rows[i].Cells[3].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[i].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvChiTietHoaDon.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string item = cbbLuaChon.GetItemText(cbbLuaChon.SelectedItem);
            string textSearch = txtSearch.Text.Trim();

            if(item == "")
            {
                MessageBox.Show("Vui lòng chọn lựa chọn tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (item == "Tất Cả")
            {
                dgvHoaDon.DataSource = billBUS.GetAllBill();
                return;
            }

            if (item == "Mã Khách Hàng")
            {
                dgvHoaDon.DataSource = billBUS.GetBillByCustomerID(textSearch);

                if(dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllBill();
                    return;
                }
            }

            if (item == "Tên Khách Hàng")
            {
                dgvHoaDon.DataSource = billBUS.GetBillByCustomerName(textSearch);

                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllBill();
                    return;
                }
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnLocGia_Click(object sender, EventArgs e)
        {
            if(txtGiaTu.Text.Trim() == "" && txtGiaDen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập một trong hai ô !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumber(txtGiaTu.Text.Trim()) || !IsNumber(txtGiaDen.Text.Trim())){
                MessageBox.Show("Vui lòng nhập giá trị là số !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*if(txtGiaTu.Text.Trim() != "" && txtGiaDen.Text.Trim() != "")
            {
                if (double.Parse(txtGiaTu.Text.Trim()) > double.Parse(txtGiaDen.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập giá từ bé hơn giá đến !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }*/

            if(txtGiaTu.Text != "" && txtGiaDen.Text == "")
            {
                dgvHoaDon.DataSource = billBUS.GetBillByPriceFrom(txtGiaTu.Text.Trim());

                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllBill();
                    return;
                }
                return;
            }

            if (txtGiaTu.Text == "" && txtGiaDen.Text != "")
            {
                dgvHoaDon.DataSource = billBUS.GetBillByPriceTo(txtGiaDen.Text.Trim());

                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetAllBill();
                    return;
                }
                return;
            }

            dgvHoaDon.DataSource = billBUS.GetBillByPrice(txtGiaTu.Text.Trim(),txtGiaDen.Text.Trim());

            if (dgvHoaDon.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllBill();
                return;
            }
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {

            if(dtpNgayTu.Value > dtpNgayDen.Value)
            {
                MessageBox.Show("Vui lòng lựa chọn ngày từ nhỏ hơn ngày đến !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string []NgayTu = dtpNgayTu.Value.ToString().Split(" ");
            string[] NgayDen = dtpNgayDen.Value.ToString().Split(" ");

            dgvHoaDon.DataSource = billBUS.GetBillByDateCreate(NgayTu[0],NgayDen[0]);

            if (dgvHoaDon.Rows.Count <= 1)
            {
                MessageBox.Show("Không tìm thấy !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllBill();
                return;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if(txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là in hóa đơn này chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InHoaDon();
            }

        }

        public void InHoaDon()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }

        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var w = pdHoaDon.DefaultPageSettings.PaperSize.Width;
            
            
            dtCTHoaDon = detailBillBUS.GetDetailBillByID(txtMaHoaDon.Text.Trim());
            dtHoaDon = billBUS.GetBillByID(txtMaHoaDon.Text.Trim());

            //vẽ header của bill
            //1. tên cửa hàng 
            e.Graphics.DrawString("Nhóm 8 Bán Điện Thoại", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(30, 20));
            e.Graphics.DrawString(string.Format("Mã Hóa Đơn : {0}", txtMaHoaDon.Text.Trim()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 80, 20));

            //2. địa chỉ và số điện thoại
            e.Graphics.DrawString(string.Format("{0} - {1}", "273 An Dương Vương, phường 2, quận 5, TP HCM", "0999999999"), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(30, 45));
            e.Graphics.DrawString(string.Format("Ngày In Hóa Đơn :  {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 80, 45));



            //định dạng bút vẽ
            Pen blackPen = new Pen(Color.Black, 1);
            var y = 70;
            //định nghĩa 2 điểm để vẽ đường thẳng
            //cách lề trái 10, lề phải 10
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            //kẻ đường thẳng thứ nhất
            e.Graphics.DrawLine(blackPen, p1, p2);


             y += 10;
             e.Graphics.DrawString(String.Format("Ngày Lập Hóa Đơn: {0}", ((DateTime)dtHoaDon.Rows[0]["DateCreate"]).ToString("dd/MM/yyyy")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            y += 20;

            e.Graphics.DrawString(String.Format("Mã Khách Hàng: {0}", (dtHoaDon.Rows[0]["UserId"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            y += 20;

            e.Graphics.DrawString(String.Format("Tên Khách Hàng: {0}", (dtHoaDon.Rows[0]["FullName"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));

            y += 20;
            e.Graphics.DrawString(String.Format("Nhân Viên Lập Hóa Đơn: {0}", (dtHoaDon.Rows[0]["StaffFullName"]).ToString()), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));

            y += 10;



            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 2
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            e.Graphics.DrawString("STT", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString("Số Lượng", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            e.Graphics.DrawString("Đơn giá (VND)", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            e.Graphics.DrawString("Thành tiền (VND)", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));

            

            int i = 1;
            y += 20;

            foreach (DataRow row in dtCTHoaDon.Rows)
            {
                e.Graphics.DrawString(string.Format("{0}", i++), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(row["NameProduct"].ToString(), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(string.Format("{0:N0}", row["Amount"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
                e.Graphics.DrawString(string.Format("{0:N0}", row["Price"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
                e.Graphics.DrawString(string.Format("{0:N0}", row["Total"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));
                y += 20;
            }

            y += 40;
            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 3
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            //tổng tiền thanh toán
            y += 20;
            e.Graphics.DrawString(string.Format("Tổng tiền: {0:N0} VNĐ",dtHoaDon.Rows[0]["Total"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));

            //đọc số thành chữ
            y += 40;
            e.Graphics.DrawString("Xin chân thành cảm ơn sự ủng hộ của quý khách!", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
        }
    }
}
