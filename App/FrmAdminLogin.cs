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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static string _activateAdminID = "";
        public static bool _AdminLogin = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select UserName,Password,EmployeeID from Employees where UserName=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtAdminUsrNm.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (txtAdminUsrNm.Text == reader[0].ToString() && TxtAdminPass.Text == reader[1].ToString())
                {
                    _activateAdminID = reader[2].ToString();
                    reader.Close();
                    connection.Close();
                    _AdminLogin = true;
                    FrmAdminPanel form = new FrmAdminPanel();
                    this.Hide();
                    form.Show();
                    return;
                }

            }
            MessageBox.Show("Admin ID veya şifre hatalı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
            connection.Close();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LimeGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.PaleGreen;

        }

        private void btnNewCst_MouseEnter(object sender, EventArgs e)
        {
            btnNewCst.BackColor = Color.LightSeaGreen;

        }

        private void btnNewCst_MouseLeave(object sender, EventArgs e)
        {
            btnNewCst.BackColor = Color.PaleTurquoise;
        }

        private void btnNewCst_Click(object sender, EventArgs e)
        {
            FrmNewAdmin form = new FrmNewAdmin();
            form.ShowDialog();
        }
    }
}
