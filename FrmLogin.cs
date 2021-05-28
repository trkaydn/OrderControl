using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindTest2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LimeGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.PaleGreen;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSeaGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.PaleTurquoise;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Firebrick;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCoral;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUserLogin form = new FrmUserLogin();
             form.ShowDialog();

            if (FrmUserLogin._userLogin)
                this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminLogin form = new FrmAdminLogin();
            form.ShowDialog();

            if (FrmAdminLogin._AdminLogin)
                this.Hide();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2021 Tarık A, All Rights Reserved.", "OrderControl v1.0 by Tarık A.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
