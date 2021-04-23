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
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);


        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LimeGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.PaleGreen;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtadress.Text == "" || txtcity.Text == "" || txtcompname.Text == "" || txtcontname.Text == "" || txtconttitle.Text == "" || txtcountry.Text == "" || txtfax.Text == "" || txtid.Text == "" || txtphone.Text == "" || txtpostalcode.Text == "" || txtregion.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtid.Text.Length < 5)
            {
                MessageBox.Show("CustomerID 5 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Şifreniz en az 5 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();
            SqlCommand controlcom = new SqlCommand("select CustomerID from Customers", connection);
            SqlDataReader cntreader = controlcom.ExecuteReader();
            while (cntreader.Read())
            {
                if (cntreader[0].ToString() == txtid.Text)
                {
                    MessageBox.Show("Bu ID zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cntreader.Close();
                    connection.Close();
                    return;
                }
            }
            cntreader.Close();
            connection.Close();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Customers values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", connection);
                command.Parameters.AddWithValue("@p1", txtid.Text);
                command.Parameters.AddWithValue("@p2", txtcompname.Text);
                command.Parameters.AddWithValue("@p3", txtcontname.Text);
                command.Parameters.AddWithValue("@p4", txtconttitle.Text);
                command.Parameters.AddWithValue("@p5", txtadress.Text);
                command.Parameters.AddWithValue("@p6", txtcity.Text);
                command.Parameters.AddWithValue("@p7", txtregion.Text);
                command.Parameters.AddWithValue("@p8", txtpostalcode.Text);
                command.Parameters.AddWithValue("@p9", txtcountry.Text);
                command.Parameters.AddWithValue("@p10", txtphone.Text);
                command.Parameters.AddWithValue("@p11", txtfax.Text);
                command.Parameters.AddWithValue("@p12", txtPassword.Text);
                command.Parameters.AddWithValue("@p13", "True");
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ID'niz ve şifreniz ile sisteme giriş yapabilirsiniz.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                connection.Close();
            }
        }

    }
}
