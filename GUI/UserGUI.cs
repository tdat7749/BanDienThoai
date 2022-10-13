using BanDienThoai.BUS;
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
    public partial class UserGUI : Form
    {
        public UserGUI()
        {
            InitializeComponent();
            GetAllUser();
        }

        public void GetAllUser()
        {
            dgvUser.DataSource = UserBUS.GetAllUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //hàm click vào row của table sẽ hiện lên text field
            int i = dgvUser.CurrentRow.Index;
            txtTest.Text = dgvUser.Rows[i].Cells[0].Value.ToString();

        }
    }
}
