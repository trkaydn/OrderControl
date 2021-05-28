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
    public partial class FrmUpPass : Form
    {
        public FrmUpPass()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        private void FrmUpPass_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select password from Customers where CustomerID='" + FrmUserPanel._activatecustomer + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                txtOldPss.Text = reader[0].ToString();
                reader.Close();
                connection.Close();
            }
            catch (Exception err)
            { MessageBox.Show(err.Message); }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtps1.Text != txtps2.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler aynı değil.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtps1.Text =="" || txtps2.Text=="")
            {
                MessageBox.Show("Lütfen bir şifre sağlayın.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Customers set password=@p1 where CustomerID=@p2", connection);
                command.Parameters.AddWithValue("@p1", txtps1.Text);
                command.Parameters.AddWithValue("@p2", FrmUserPanel._activatecustomer);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Şifreniz başarı ile değiştirildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnsave_MouseEnter(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.LightSeaGreen;
        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.PaleTurquoise;
        }
    }
}
