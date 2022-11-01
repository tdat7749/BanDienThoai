namespace BanDienThoai.GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.penal_main = new System.Windows.Forms.Panel();
            this.elipseControl1 = new BanDienThoai.GUI.ElipseControl();
            this.elipseControl4 = new BanDienThoai.GUI.ElipseControl();
            this.elipseControl5 = new BanDienThoai.GUI.ElipseControl();
            this.SuspendLayout();
            // 
            // pnl_nav
            // 
            this.pnl_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_nav.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_nav.Location = new System.Drawing.Point(12, 18);
            this.pnl_nav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(124, 533);
            this.pnl_nav.TabIndex = 0;
            // 
            // penal_main
            // 
            this.penal_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penal_main.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.penal_main.Location = new System.Drawing.Point(164, 18);
            this.penal_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penal_main.Name = "penal_main";
            this.penal_main.Size = new System.Drawing.Size(1023, 533);
            this.penal_main.TabIndex = 3;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this.pnl_nav;
            // 
            // elipseControl4
            // 
            this.elipseControl4.CornerRadius = 30;
            // 
            // elipseControl5
            // 
            this.elipseControl5.CornerRadius = 30;
            this.elipseControl5.TargetControl = this.penal_main;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.penal_main);
            this.Controls.Add(this.pnl_nav);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_nav;
        private Panel penal_main;
        private ElipseControl elipseControl1;
        private ElipseControl elipseControl4;
        private ElipseControl elipseControl5;
    }
}