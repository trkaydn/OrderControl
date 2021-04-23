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
    public partial class FrmUpAdmin : Form
    {
        public FrmUpAdmin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);

        private void FrmUpAdmin_Load(object sender, EventArgs e)
        {

            dateTimeBirth.Format = DateTimePickerFormat.Short;
            dateTimeHire.Format = DateTimePickerFormat.Short;

            txtid.Text = FrmAdminPanel._ActivateAdminID.ToString();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select FirstName,LastName,Title,BirthDate,HireDate,Notes,Username from Employees where EmployeeID='" + FrmAdminPanel._ActivateAdminID + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtfname.Text = reader[0].ToString();
                    txtlname.Text = reader[1].ToString();
                    txttitle.Text = reader[2].ToString();
                    dateTimeBirth.Value = Convert.ToDateTime(reader[3].ToString());
                    dateTimeHire.Value = Convert.ToDateTime(reader[4].ToString());
                    txtNotes.Text = reader[5].ToString();
                    txtUsername.Text = reader[6].ToString();

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }
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

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Employees set FirstName=@p1,LastName=@p2,BirthDate=@p3,HireDate=@p4,Notes=@p5,Title=@p6 where EmployeeID=@p7", connection);
                command.Parameters.AddWithValue("@p1", txtfname.Text);
                command.Parameters.AddWithValue("@p2", txtlname.Text);
                command.Parameters.AddWithValue("@p3", dateTimeBirth.Value);
                command.Parameters.AddWithValue("@p4", dateTimeHire.Value);
                command.Parameters.AddWithValue("@p5", txtNotes.Text);
                command.Parameters.AddWithValue("@p6", txttitle.Text);
                command.Parameters.AddWithValue("@p7", FrmAdminPanel._ActivateAdminID);
                command.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
                connection.Close();
                this.Close();
            }
            catch (Exception err)
            { MessageBox.Show(err.Message); }
        }
    }
}
