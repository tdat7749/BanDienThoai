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
    public partial class MainGUI : Form
    {
        private Form currentFormChild;
        public MainGUI()
        {
            InitializeComponent();
            ChangeFormChild(new HoaDonGUI());
        }

        private void ChangeFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
