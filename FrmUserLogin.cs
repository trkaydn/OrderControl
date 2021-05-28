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
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        public static string _conString = "Data Source=TARIK-PC;Initial Catalog = Northwind; Integrated Security = True";
        SqlConnection connection = new SqlConnection(_conString);
        public static bool _userLogin = false;

        public static string _customerid;

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnUserLogin.BackColor = Color.LimeGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnUserLogin.BackColor = Color.PaleGreen;

        }

        private void btnNewCst_MouseEnter(object sender, EventArgs e)
        {
            btnNewCst.BackColor = Color.LightSeaGreen;

        }

        private void btnNewCst_MouseLeave(object sender, EventArgs e)
        {
            btnNewCst.BackColor = Color.PaleTurquoise;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select CustomerID,Password,Activated from Customers", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((reader[0].ToString() == textBox1.Text && reader[1].ToString() == textBox2.Text) && reader[2].ToString()=="True")
                {
                    _customerid = textBox1.Text;
                    this.Hide();
                    _userLogin = true;
                    FrmUserPanel form = new FrmUserPanel();
                    form.Show();
                    reader.Close();
                    connection.Close();
                    return;
                }

                else if ((reader[0].ToString() == textBox1.Text && reader[1].ToString() == textBox2.Text) && reader[2].ToString() == "False")
                {
                    MessageBox.Show("Hesabınız yönetici tarafından engellenmiştir. \n Sisteme giriş yapamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    connection.Close();
                    return;
                }

            }

            MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
            connection.Close();

        }

        private void btnNewCst_Click(object sender, EventArgs e)
        {
            FrmNewCustomer form = new FrmNewCustomer();
            form.ShowDialog();
        }

       
    }
}