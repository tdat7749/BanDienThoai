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
    public partial class MuaHang : Form
    {
        public MuaHang()
        {
            InitializeComponent();
            panel1.BackColor = SetTransparency(200, Color.FromArgb(39, 43, 52));
            panel2.BackColor = SetTransparency(200, Color.FromArgb(39, 43, 52));
            panel3.BackColor = SetTransparency(50, Color.FromArgb(255, 255, 255));
            label2.BackColor = SetTransparency(0, Color.FromArgb(255, 255, 255));
            panel4.BackColor = SetTransparency(200, Color.FromArgb(39, 43, 52)); 
            panel5.BackColor = SetTransparency(50, Color.FromArgb(255, 255, 255));
            label3.BackColor = SetTransparency(0, Color.FromArgb(255, 255, 255));

        }

        static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }
    }
}
