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
    public partial class FrmUpdPrdct : Form
    {
        public FrmUpdPrdct()
        {
            InitializeComponent();
        }



        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static bool control = false;

        private void FrmUpdPrdct_Load(object sender, EventArgs e)
        {
            textBox3.Text = FrmAdminPanel.__UpdatingProductID;
            string SupplierID = "";
            control = false;

            connection.Open();
            SqlCommand command = new SqlCommand("select ProductName,SupplierID,QuantityPerUnit from Products where ProductID=@p1", connection);
            command.Parameters.AddWithValue("@p1", FrmAdminPanel.__UpdatingProductID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                SupplierID = reader[1].ToString();
                textBox2.Text = reader[2].ToString();

            }
            reader.Close();

            SqlCommand cmbcommand = new SqlCommand("select Categoryname from Categories", connection);
            SqlDataReader cmbreader = cmbcommand.ExecuteReader();
            while (cmbreader.Read())
            {
                cmbCategories.Items.Add(cmbreader[0]);
            }
            cmbreader.Close();
            
            
            SqlCommand command2 = new SqlCommand("select CompanyName from Suppliers", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbSuppliers.Items.Add(reader2[0]);
            }
            reader2.Close();

            cmbCategories.SelectedIndex = FrmAdminPanel.selectedctg;

            SqlCommand command3 = new SqlCommand("select CompanyName from suppliers where SupplierID='"+SupplierID+"'", connection);
            SqlDataReader rdr3 = command3.ExecuteReader();
            while (rdr3.Read())
            {
                cmbSuppliers.SelectedItem = rdr3[0].ToString();
            }
            rdr3.Close();
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

            SqlCommand ctgid = new SqlCommand("select categoryID from Categories where CategoryName=@p1", connection);
            ctgid.Parameters.AddWithValue("@p1", cmbCategories.SelectedItem.ToString());
            SqlDataReader ctrdr = ctgid.ExecuteReader();
            ctrdr.Read();
            string ctid = ctrdr[0].ToString();
            ctrdr.Close();

            SqlCommand sprid = new SqlCommand("select SupplierID from Suppliers where CompanyName=@p1", connection);
            sprid.Parameters.AddWithValue("@p1", cmbSuppliers.SelectedItem.ToString());
            SqlDataReader sprdr = sprid.ExecuteReader();
            sprdr.Read();
            string spid = sprdr[0].ToString();
            sprdr.Close();

            SqlCommand command = new SqlCommand("update Products set ProductName=@p1,QuantityPerUnit=@p2,CategoryID=@p3,SupplierID=@p4 where ProductID='"+FrmAdminPanel.__UpdatingProductID+"'", connection);
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", ctid);
            command.Parameters.AddWithValue("@p4", spid);
            command.ExecuteNonQuery();
            control = true;
            connection.Close();
            MessageBox.Show("Ürün bilgileri güncellendi.");
            this.Close();
        }


    }
}
