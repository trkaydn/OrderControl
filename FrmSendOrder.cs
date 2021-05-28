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
    public partial class FrmSendOrder : Form
    {
        public FrmSendOrder()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static string CustomerID = "", ShipViaID = "";
        public static bool control = false;

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.ForeColor = Color.White;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.ForeColor = Color.Black;
        }

        private void btnAccpt_MouseLeave(object sender, EventArgs e)
        {
            btnAccpt.BackColor = Color.MediumSpringGreen;
        }

        private void btnAccpt_MouseEnter(object sender, EventArgs e)
        {
            btnAccpt.BackColor = Color.LimeGreen;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccpt_Click(object sender, EventArgs e)
        {
            var tarih = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            connection.Open();
            SqlCommand command = new SqlCommand("update Orders set ShippedDate=@p1 where OrderID=@p2", connection);
            command.Parameters.AddWithValue("@p1", tarih);
            command.Parameters.AddWithValue("@p2", FrmAdminPanel._shippingOrder);
            command.ExecuteNonQuery();
            connection.Close();
             MessageBox.Show("Sipariş kargoya verildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            control = true;
            Close();
        }

        private void FrmSendOrder_Load(object sender, EventArgs e)
        {
            connection.Open();
            control = false;
            SqlCommand command1 = new SqlCommand("select ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry,CustomerID,Shipvia from Orders where OrderID=@p1", connection);
            command1.Parameters.AddWithValue("@p1", FrmAdminPanel._shippingOrder);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                textBox3.Text = reader1[0].ToString();
                textBox4.Text = reader1[1].ToString();
                textBox5.Text = reader1[2].ToString();
                textBox6.Text = reader1[3].ToString();
                textBox7.Text = reader1[4].ToString();
                textBox8.Text = reader1[5].ToString();
                CustomerID = reader1[6].ToString();
                ShipViaID = reader1[7].ToString();
            }
            reader1.Close();

            SqlCommand command3 = new SqlCommand("select CompanyName from shippers where ShipperID=@p1", connection);
            command3.Parameters.AddWithValue("@p1", ShipViaID);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                textBox2.Text = reader3[0].ToString();
            }
            reader3.Close();
          
            connection.Close();
        }
    }
}
