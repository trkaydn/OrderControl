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
    public partial class FrmUpdPrice : Form
    {
        public FrmUpdPrice()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static bool control = false;

        private void FrmUpdPrice_Load(object sender, EventArgs e)
        {
            control = false;
            connection.Open();
            SqlCommand command = new SqlCommand("select ProductName, UnitPrice,UnitsInStock from Products where ProductID=@p1", connection);
            command.Parameters.AddWithValue("@p1", FrmAdminPanel.__UpdatingProductID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                numericUpDown1.Value = Convert.ToDecimal(reader[1].ToString());
                numericUpDown2.Value =Convert.ToInt32(reader[2].ToString());

            }
            reader.Close();
            connection.Close();
        }

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
            BtnAccept.BackColor = Color.MediumSpringGreen;
        }

        private void btnAccpt_MouseEnter(object sender, EventArgs e)
        {
            BtnAccept.BackColor = Color.LimeGreen;

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            connection.Open();

            double a = Convert.ToDouble(numericUpDown1.Value.ToString());
            double b = Convert.ToDouble(numericUpDown2.Value.ToString());
            SqlCommand command = new SqlCommand("update Products set UnitPrice=@p1, UnitsInstock=@p2 where ProductID=@p3", connection);
            command.Parameters.AddWithValue("@p1", a);
            command.Parameters.AddWithValue("@p2", b);
            command.Parameters.AddWithValue("@p3", FrmAdminPanel.__UpdatingProductID);
            command.ExecuteNonQuery();
            control = true;
            connection.Close();
            MessageBox.Show("Fiyat ve stok bilgileri güncellendi.");
            this.Close();
        }
    }
}
