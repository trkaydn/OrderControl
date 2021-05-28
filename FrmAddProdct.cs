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
    public partial class FrmAddProdct : Form
    {
        public FrmAddProdct()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static bool control = false;
        private void FrmAddProdct_Load(object sender, EventArgs e)
        {
            control = false;
            connection.Open();

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (txtprdName.Text=="" ||txtprdDetail.Text=="" || cmbCategories.SelectedIndex==-1 || cmbSuppliers.SelectedIndex==-1 || numericPrice.Value==0 || numericStock.Value==0)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            double price = Convert.ToDouble(numericPrice.Value.ToString());
            double stock = Convert.ToDouble(numericStock.Value.ToString());
            bool activated = checkBox1.Checked;
            SqlCommand addcommand = new SqlCommand("insert into Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,Unitprice,UnitsInStock,Activated) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
            addcommand.Parameters.AddWithValue("@p1", txtprdName.Text);
            addcommand.Parameters.AddWithValue("@p2",spid);
            addcommand.Parameters.AddWithValue("@p3",ctid);
            addcommand.Parameters.AddWithValue("@p4", txtprdDetail.Text);
            addcommand.Parameters.AddWithValue("@p5",price);
            addcommand.Parameters.AddWithValue("@p6",stock);
            addcommand.Parameters.AddWithValue("@p7", activated);
            addcommand.ExecuteNonQuery();
            connection.Close();
            control = true;
            MessageBox.Show("Yeni ürün kaydı tamamlandı.");
            this.Close();
        }
    }
}
