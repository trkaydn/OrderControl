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
    public partial class FrmUpCnt : Form
    {
        public FrmUpCnt()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);

        private void FrmUpCnt_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Address,City,Region,PostalCode,Country,Phone,Fax from Customers where customerID='" + FrmUserPanel._activatecustomer + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                txtupcaddress.Text = reader[0].ToString();
                txtupcity.Text = reader[1].ToString();
                txtupregion.Text = reader[2].ToString();
                txtuppostalcode.Text = reader[3].ToString();
                txtupcountry.Text = reader[4].ToString();
                txtupphone.Text = reader[5].ToString();
                txtupfax.Text = reader[6].ToString();
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }
            connection.Close();

        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.PaleTurquoise;
        }

        private void btnsave_MouseEnter(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.LightSeaGreen;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Customers set Address=@p1,City=@p2,Region=@p3,PostalCode=@p4,Country=@p5,Phone=@p6,Fax=@p7 where customerID=@p8", connection);
                command.Parameters.AddWithValue("@p1", txtupcaddress.Text);
                command.Parameters.AddWithValue("@p2", txtupcity.Text);
                command.Parameters.AddWithValue("@p3", txtupregion.Text);
                command.Parameters.AddWithValue("@p4", txtuppostalcode.Text);
                command.Parameters.AddWithValue("@p5", txtupcountry.Text);
                command.Parameters.AddWithValue("@p6", txtupphone.Text);
                command.Parameters.AddWithValue("@p7", txtupfax.Text);
                command.Parameters.AddWithValue("@p8", FrmUserPanel._activatecustomer);
                command.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
                this.Close();
            }
            catch (Exception err)
            { MessageBox.Show(err.Message); }
            connection.Close();

        }


    }
}
