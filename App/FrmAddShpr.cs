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
    public partial class FrmAddShpr : Form
    {
        public FrmAddShpr()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static bool control = false;


        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancell_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.ForeColor = Color.White;
        }

        private void btnCancell_MauseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.ForeColor = Color.Black;
        }

        private void BtnAcceptt_MouseLeave(object sender, EventArgs e)
        {
            BtnAccept.BackColor = Color.MediumSpringGreen;
        }

        private void BtnAcceptt_MouseEnter(object sender, EventArgs e)
        {
            BtnAccept.BackColor = Color.LimeGreen;

        }



        private void FrmAddShpr_Load(object sender, EventArgs e)
        {
            control = false;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            connection.Open();
            var activated = checkBox1.Checked;

            SqlCommand command = new SqlCommand("insert into Shippers(CompanyName,Phone,Activated,ShipPrice) values (@p1,@p2,@p3,@p4) ", connection);
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", activated);
            command.Parameters.AddWithValue("@p4", numericUpDown1.Value);
            command.ExecuteNonQuery();
            control = true;
            connection.Close();
            MessageBox.Show("Kategori başarıyla eklendi.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
