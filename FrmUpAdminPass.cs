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
    public partial class FrmUpAdminPass : Form
    {
        public FrmUpAdminPass()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        private void FrmUpAdminPass_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select password from Employees where EmployeeID='" + FrmAdminLogin._activateAdminID + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                txtOldPss.Text = reader[0].ToString();
                reader.Close();
                connection.Close();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtps1.Text != txtps2.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler aynı değil.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtps1.Text == "" || txtps2.Text == "")
            {
                MessageBox.Show("Lütfen bir şifre sağlayın.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Employees set password=@p1 where EmployeeID=@p2", connection);
                command.Parameters.AddWithValue("@p1", txtps1.Text);
                command.Parameters.AddWithValue("@p2", FrmAdminPanel._ActivateAdminID);
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
    }
}
