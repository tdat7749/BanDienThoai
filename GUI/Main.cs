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
    public partial class Main : Form
    {

        private Form currentFormChild;
        public Main()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(56, 60, 71);
            pnl_nav.BackColor = Color.FromArgb(39, 43, 52);
            //pnl_info1.BackColor = Color.FromArgb(245, 67, 81);
            //pnl_info2.BackColor = SetTransparency(250, Color.FromArgb(39, 43, 52));
            penal_main.BackColor = Color.FromArgb(39, 43, 52);
            //panel.BackColor = Color.FromArgb(39, 43, 52);

            ChangeFormChild(new MuaHang());
        }
        static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }

        private void ChangeFormChild(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            penal_main.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
