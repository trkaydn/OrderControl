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
    public partial class FrmUpUsr : Form
    {
        public FrmUpUsr()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        private void FrmUpUsr_Load(object sender, EventArgs e)
        {
            txtid.Text = FrmUserPanel._activatecustomer.ToString();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select CompanyName,ContactName,ContactTitle from Customers where customerID='" + FrmUserPanel._activatecustomer + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                txtcompname.Text = reader[0].ToString();
                txtcontname.Text = reader[1].ToString();
                txtconttitle.Text = reader[2].ToString();
                reader.Close();
            }
            
            catch (Exception error)
            { MessageBox.Show(error.Message); }
            
            connection.Close();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Customers set CompanyName=@p1,ContactName=@p2,ContactTitle=@p3 where customerID=@p4", connection);
                command.Parameters.AddWithValue("@p1", txtcompname.Text);
                command.Parameters.AddWithValue("@p2", txtcontname.Text);
                command.Parameters.AddWithValue("@p3", txtconttitle.Text);
                command.Parameters.AddWithValue("@p4", txtid.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
                connection.Close();
                this.Close();
            }
            catch (Exception err)
            { MessageBox.Show(err.Message); }
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
