using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NorthwindTest2
{
    public partial class FrmAddCtg : Form
    {
        public FrmAddCtg()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static bool control = false;


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.ForeColor = Color.White;
        }

        private void btnCancel_MauseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.ForeColor = Color.Black;
        }

        private void BtnAccept_MouseLeave(object sender, EventArgs e)
        {
            BtnAccept.BackColor = Color.MediumSpringGreen;
        }

        private void BtnAccept_MouseEnter(object sender, EventArgs e)
        {
            BtnAccept.BackColor = Color.LimeGreen;

        }

     

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            connection.Open();
            var activated = checkBox1.Checked;
           
            SqlCommand command = new SqlCommand("insert into Categories(CategoryName,Description,Activated) values (@p1,@p2,@p3) ", connection);
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", activated);
            command.ExecuteNonQuery();
            control = true;
            connection.Close();
            MessageBox.Show("Kategori başarıyla eklendi.");
            this.Close();
        }

        private void FrmAddCtg_Load(object sender, EventArgs e)
        {
            control = false;
        }
    }
}
