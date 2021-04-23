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
    public partial class FrmNewAdmin : Form
    {
        public FrmNewAdmin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtlname.Text == "" || txtUserName.Text == "" || txttitle.Text == "" || TxtNotes.Text == "" || txtcountry.Text == "" || TxtNotes.Text == "" || txtadress.Text == "" || txtcity.Text == "" || txtphone.Text == "" || txtpostalcode.Text == "" || txtregion.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Şifreniz en az 5 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                SqlCommand controlcom = new SqlCommand("select UserName from Employees", connection);
                SqlDataReader cntreader = controlcom.ExecuteReader();
                while (cntreader.Read())
                {
                    if (cntreader[0].ToString() == txtUserName.Text)
                    {
                        MessageBox.Show("Bu ID zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cntreader.Close();
                        connection.Close();
                        return;
                    }
                }
                cntreader.Close();


                SqlCommand command = new SqlCommand("insert into Employees(LastName,FirstName,Title,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Notes,UserName,Password) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", connection);
                command.Parameters.AddWithValue("@p1", txtlname.Text);
                command.Parameters.AddWithValue("@p2", txtfname.Text);
                command.Parameters.AddWithValue("@p3", txttitle.Text);
                command.Parameters.AddWithValue("@p4", dateTimeBirth.Value);
                command.Parameters.AddWithValue("@p5", dateTimeHire.Value);
                command.Parameters.AddWithValue("@p6", txtadress.Text);
                command.Parameters.AddWithValue("@p7", txtcity.Text);
                command.Parameters.AddWithValue("@p8", txtregion.Text);
                command.Parameters.AddWithValue("@p9", txtpostalcode.Text);
                command.Parameters.AddWithValue("@p10", txtcountry.Text);
                command.Parameters.AddWithValue("@p11", txtphone.Text);
                command.Parameters.AddWithValue("@p12", TxtNotes.Text);
                command.Parameters.AddWithValue("@p13", txtUserName.Text);
                command.Parameters.AddWithValue("@p14", txtPassword.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı adınız ve şifreniz ile sisteme giriş yapabilirsiniz.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            connection.Close();
        }

        private void FrmNewAdmin_Load(object sender, EventArgs e)
        {
            dateTimeBirth.Format = DateTimePickerFormat.Short;
            dateTimeHire.Format = DateTimePickerFormat.Short;
        }


        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LimeGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.PaleGreen;

        }


    }
}
