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
    public partial class FrmUserPanel : Form
    {
        public FrmUserPanel()
        {
            InitializeComponent();
        }

        public static string _activatecustomer;
        public static string shipperid = "";
        public static double shipperprice = 0;
        public static string productid = "";
        public static string categoryid = "";
        
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);


        private void FrmUserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Firebrick;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.LightCoral;
        }

        private void FrmUserPanel_Load(object sender, EventArgs e)
        {
            _activatecustomer = FrmUserLogin._customerid;

            cmbproducts.Enabled = false;
            cmbshipvia.Enabled = false;
            cmbemp.Enabled = false;
            numeric.Enabled = false;
            btnCancel.Enabled = false;

            RefreshOrders();


            connection.Open();
            SqlCommand command = new SqlCommand("select CompanyName,ContactName from Customers where CustomerID='" + _activatecustomer + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            cmpName.Text = reader[0].ToString();
            cstName.Text = reader[1].ToString();
            reader.Close();

            //Marketplace combobox
            SqlCommand cmbcommand = new SqlCommand("select Categoryname from Categories where Activated='true'", connection);
            SqlDataReader cmbreader = cmbcommand.ExecuteReader();
            while (cmbreader.Read())
            {
                cmbCategories.Items.Add(cmbreader[0]);
            }
            cmbreader.Close();

            SqlCommand shpcommand = new SqlCommand("select CompanyName from Shippers where Activated='true'", connection);
            SqlDataReader shpreader = shpcommand.ExecuteReader();
            while (shpreader.Read())
            {
                cmbshipvia.Items.Add(shpreader[0].ToString());

            }
            shpreader.Close();

            SqlCommand embcommand = new SqlCommand("select Firstname,LastName from Employees", connection);
            SqlDataReader embread = embcommand.ExecuteReader();
            while (embread.Read())
            {
                cmbemp.Items.Add(embread[0].ToString() + " " + embread[1].ToString());
            }
            embread.Close();
            connection.Close();
        }

        private void btnPass_MouseLeave(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.Khaki;
        }

        private void btnPass_MouseEnter(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.Gold;
        }

        private void btnUsrinf_MouseEnter(object sender, EventArgs e)
        {
            btnUsrinf.BackColor = Color.LimeGreen;
        }

        private void btnUsrinf_MouseLeave(object sender, EventArgs e)
        {
            btnUsrinf.BackColor = Color.PaleGreen;

        }

        private void btnCntinfo_MouseEnter(object sender, EventArgs e)
        {
            btnCntinfo.BackColor = Color.LightSeaGreen;
        }

        private void btnCntinfo_MouseLeave(object sender, EventArgs e)
        {
            btnCntinfo.BackColor = Color.PaleTurquoise;
        }

        private void btnUsrinf_Click(object sender, EventArgs e)
        {
            FrmUpUsr form = new FrmUpUsr();
            form.ShowDialog();

            if (connection.State==ConnectionState.Closed)
            connection.Open();
            SqlCommand command = new SqlCommand("select CompanyName,ContactName from Customers where CustomerID='" + _activatecustomer + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            cmpName.Text = reader[0].ToString();
            cstName.Text = reader[1].ToString();
            reader.Close();
        }

        private void btnCntinfo_Click(object sender, EventArgs e)
        {
            FrmUpCnt form = new FrmUpCnt();
            form.ShowDialog();


        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            FrmUpPass form = new FrmUpPass();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Oturum Sonlandırılacak", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                connection.Close();
                this.Hide();
                FrmLogin form = new FrmLogin();
                form.Show();
            }

        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrders.Text == "")
                return;
            btnCancel.Enabled = true;
            string order = cmbOrders.Text;
            string product = "";
            string freightid = "";
            string supplier = "";
            string category = "";
            string employeeid = "";

            if (connection.State==ConnectionState.Closed)
            connection.Open();
            SqlCommand command = new SqlCommand("select OrderDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry,EmployeeID from Orders where OrderID=@p1", connection);
            command.Parameters.AddWithValue("@p1", order);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                freightid = reader[2].ToString();
                string txt4 = reader[3].ToString();
                textBox4.Text = Math.Round(double.Parse(txt4), 2).ToString();
                textBox5.Text = reader[4].ToString();
                textBox6.Text = reader[5].ToString() + " " + reader[6].ToString() + " " + reader[7].ToString() + " " + reader[8].ToString() + " " + reader[9].ToString();
                employeeid = reader[10].ToString();
            }
            reader.Close();
            if (textBox2.Text == "")
                textBox2.Text = "Henüz kargoya verilmedi.";

            SqlCommand emp = new SqlCommand("select FirstName,LastName from Employees where EmployeeID=@p1", connection);
            emp.Parameters.AddWithValue("@p1", employeeid);
            SqlDataReader empreader = emp.ExecuteReader();
            empreader.Read();
            textBox14.Text = empreader[0].ToString() + " " + empreader[1].ToString();
            empreader.Close();

            SqlCommand commandfre = new SqlCommand("select CompanyName from shippers where ShipperID=@p1", connection);
            commandfre.Parameters.AddWithValue("@p1", freightid);
            SqlDataReader readerfre = commandfre.ExecuteReader();
            readerfre.Read();
            textBox3.Text = readerfre[0].ToString();
            readerfre.Close();


            SqlCommand commandpr = new SqlCommand("select ProductID,Quantity from OrderDetails where OrderID=@p1", connection);
            commandpr.Parameters.AddWithValue("@p1", order);
            SqlDataReader readerpr = commandpr.ExecuteReader();
            while (readerpr.Read())
            {
                product = readerpr[0].ToString();
                textBox8.Text = readerpr[1].ToString();
            }
            readerpr.Close();


            SqlCommand commanddt = new SqlCommand("select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice from Products where ProductID=@p1", connection);
            commanddt.Parameters.AddWithValue("@p1", product);
            SqlDataReader readerdt = commanddt.ExecuteReader();
            while (readerdt.Read())
            {
                textBox7.Text = readerdt[0].ToString();
                supplier = readerdt[1].ToString();
                category = readerdt[2].ToString();
                textBox9.Text = readerdt[3].ToString();
                string cnt = readerdt[4].ToString();
                textBox10.Text = Math.Round(double.Parse(cnt), 2).ToString();
            }
            readerdt.Close();
            textBox11.Text = (double.Parse(textBox8.Text) * double.Parse(textBox10.Text) + double.Parse(textBox4.Text)).ToString();

            SqlCommand commandsp = new SqlCommand("select CompanyName from Suppliers where SupplierID=@p1", connection);
            commandsp.Parameters.AddWithValue("@p1", supplier);
            SqlDataReader readersp = commandsp.ExecuteReader();
            readersp.Read();
            textBox12.Text = readersp[0].ToString();
            readersp.Close();

            SqlCommand commandctg = new SqlCommand("select CategoryName,Description from Categories where CategoryID=@p1", connection);
            commandctg.Parameters.AddWithValue("@p1", category);
            SqlDataReader readerctg = commandctg.ExecuteReader();
            readerctg.Read();
            textBox13.Text = readerctg[0].ToString() + "-" + readerctg[1].ToString();
            readerctg.Close();

            connection.Close();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMarket();
            cmbproducts.Enabled = true;
            cmbshipvia.Enabled = false;
            cmbemp.Enabled = false;
            numeric.Enabled = false;
            if (cmbCategories.SelectedIndex == -1)
                return;

            connection.Open();
            SqlCommand findctgid = new SqlCommand("select CategoryID from Categories where CategoryName=@p1", connection);
            findctgid.Parameters.AddWithValue("@p1", cmbCategories.Text);
            SqlDataReader findreader = findctgid.ExecuteReader();
            findreader.Read();
            categoryid = findreader[0].ToString();
            findreader.Close();

            cmbproducts.Items.Clear();
            SqlCommand prdcommand = new SqlCommand("select productName from Products where CategoryID=@p1 and Activated='true'", connection);
            prdcommand.Parameters.AddWithValue("@p1", categoryid);
            SqlDataReader prdreader = prdcommand.ExecuteReader();
            while (prdreader.Read())
            {
                cmbproducts.Items.Add(prdreader[0]);

            }
            prdreader.Close();
            connection.Close();

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex == -1 || cmbproducts.SelectedIndex == -1 || cmbshipvia.SelectedIndex == -1 || txtbrprc.Text == "" || numeric.Value <= 0 || txtcrgpr.Text == "" || ttlprice.Text == "" || cmbemp.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm seçimleri eksiksiz yapınız.", "Sipariş Oluşturulamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();

            var tarih = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            SqlCommand cstinf = new SqlCommand("select ContactName,Address,City,Region,PostalCode,Country from Customers where CustomerID='" + _activatecustomer + "'", connection);
            SqlDataReader cstreader = cstinf.ExecuteReader();
            cstreader.Read();

            SqlCommand buycommand = new SqlCommand("insert into Orders(CustomerID,OrderDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry,EmployeeID,OrderStatus) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", connection);
            buycommand.Parameters.AddWithValue("@p1", _activatecustomer);
            buycommand.Parameters.AddWithValue("@p2", tarih);
            buycommand.Parameters.AddWithValue("@p3", shipperid);
            buycommand.Parameters.AddWithValue("@p4", Convert.ToDouble(txtcrgpr.Text));
            buycommand.Parameters.AddWithValue("@p5", cstreader[0].ToString());
            buycommand.Parameters.AddWithValue("@p6", cstreader[1].ToString());
            buycommand.Parameters.AddWithValue("@p7", cstreader[2].ToString());
            buycommand.Parameters.AddWithValue("@p8", cstreader[3].ToString());
            buycommand.Parameters.AddWithValue("@p9", cstreader[4].ToString());
            buycommand.Parameters.AddWithValue("@p10", cstreader[5].ToString());
            buycommand.Parameters.AddWithValue("@p11", cmbemp.SelectedIndex + 1);
            buycommand.Parameters.AddWithValue("@p12", true);
            cstreader.Close();
            int control = buycommand.ExecuteNonQuery();

            SqlCommand ordrid = new SqlCommand("select OrderID from Orders where OrderDate='" + tarih + "'", connection);
            SqlDataReader ordrd = ordrid.ExecuteReader();
            ordrd.Read();
            string oid = ordrd[0].ToString();
            ordrd.Close();
            SqlCommand buydetail = new SqlCommand("insert into OrderDetails values (@p1,@p2,@p3,@p4,@p5)", connection);
            buydetail.Parameters.AddWithValue("@p1", oid);
            buydetail.Parameters.AddWithValue("@p2", productid);
            buydetail.Parameters.AddWithValue("@p3", Convert.ToDouble(txtbrprc.Text));
            buydetail.Parameters.AddWithValue("@p4", numeric.Value);
            buydetail.Parameters.AddWithValue("@p5", 0);
            buydetail.ExecuteNonQuery();

            SqlCommand stock = new SqlCommand("update Products set UnitsInStock= UnitsInstock - @p1, UnitsOnOrder= UnitsOnOrder + @p1 where ProductID=@p2", connection);
            stock.Parameters.AddWithValue("@p1", numeric.Value);
            stock.Parameters.AddWithValue("@p2", productid);
            stock.ExecuteNonQuery();


            if (control > 0)
                MessageBox.Show("Siparişinizin durumunu 'Siparişlerim' ekranından takip edebilirsiniz.", "Siparişiniz alındı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            ClearMarket();
            RefreshOrders();
            cmbCategories.SelectedIndex = -1;
            cmbproducts.SelectedIndex = -1;
            cmbproducts.Enabled = false;
        }

        private void cmbshipvia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbshipvia.SelectedIndex == -1)
                return;

            if (connection.State==ConnectionState.Closed)
            connection.Open();
            SqlCommand command = new SqlCommand("select ShipperID,ShipPrice from Shippers where CompanyName='" + cmbshipvia.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            shipperid = reader[0].ToString();
            shipperprice = Convert.ToDouble(reader[1].ToString());
            
            reader.Close();
            connection.Close();

            txtcrgpr.Text = shipperprice.ToString();

            if (numeric.Value != 0)
                ttlprice.Text = ((Convert.ToDouble(txtbrprc.Text) * Convert.ToInt32(numeric.Value)) + shipperprice).ToString();
        }

        private void cmbproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproducts.SelectedIndex == -1)
                return;

            ClearMarket();
            numeric.Enabled = true;


            connection.Open();
            SqlCommand commandpr = new SqlCommand("select ProductID,UnitPrice,UnitsInStock from Products where ProductName='" + cmbproducts.Text + "'", connection);
            SqlDataReader readerpr = commandpr.ExecuteReader();
            readerpr.Read();
            productid = readerpr[0].ToString();
            double price = Convert.ToDouble(readerpr[1].ToString());
            txtbrprc.Text = Math.Round(price, 2).ToString();
            numeric.Maximum = Convert.ToInt32(readerpr[2].ToString());
            readerpr.Close();
            connection.Close();
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            if (numeric.Value == 0 || txtbrprc.Text == "")
            {
                ttlprice.Text = "";
                cmbemp.Enabled = false;
                cmbshipvia.Enabled = false;
                cmbemp.SelectedIndex = -1;
                cmbshipvia.SelectedIndex = -1;
                txtcrgpr.Text = "";
            }

            else if (txtcrgpr.Text == "" && txtbrprc.Text != "")
            {
                ttlprice.Text = (Convert.ToDouble(txtbrprc.Text) * Convert.ToInt32(numeric.Value)).ToString();
                cmbemp.Enabled = true;
            }

            else
            {
                ttlprice.Text = (shipperprice + (Convert.ToDouble(txtbrprc.Text) * Convert.ToInt32(numeric.Value))).ToString();
                cmbemp.Enabled = true;
            }
        }

        public void ClearMarket()
        {
            cmbshipvia.SelectedIndex = -1;
            cmbemp.SelectedIndex = -1;
            txtcrgpr.Text = "";
            txtbrprc.Text = "";
            numeric.Value = 0;
            ttlprice.Text = "";
        }

        private void btnBuy_MouseLeave(object sender, EventArgs e)
        {
            btnBuy.BackColor = Color.MediumSpringGreen;
        }

        private void btnBuy_MouseEnter(object sender, EventArgs e)
        {
            btnBuy.BackColor = Color.LimeGreen;

        }

        public void RefreshOrders()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            cmbOrders.Items.Clear();
            SqlCommand command1 = new SqlCommand("select OrderID from orders where CustomerID='" + _activatecustomer + "'", connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                cmbOrders.Items.Add(reader1[0]);
            }
            reader1.Close();
            connection.Close();
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.ForeColor = Color.Black;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.ForeColor = Color.White;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cmbOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir sipariş seçmelisiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                connection.Open();
                SqlCommand delOrDt = new SqlCommand("delete from OrderDetails where OrderID=@p1", connection);
                delOrDt.Parameters.AddWithValue("@p1", cmbOrders.Text);
                delOrDt.ExecuteNonQuery();

                SqlCommand delOrDr = new SqlCommand("delete from Orders where OrderID=@p1", connection);
                delOrDr.Parameters.AddWithValue("@p1", cmbOrders.Text);
                delOrDr.ExecuteNonQuery();

                SqlCommand stock = new SqlCommand("update Products set UnitsInStock= UnitsInstock + @p1 where ProductName=@p2", connection);
                stock.Parameters.AddWithValue("@p1", textBox8.Text);
                stock.Parameters.AddWithValue("@p2", textBox7.Text);
                stock.ExecuteNonQuery();

                RefreshOrders();
                ClearOrdersPage();
                btnCancel.Enabled = false;
                connection.Close();
                MessageBox.Show("Siparişiniz iptal edildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception err)
            { MessageBox.Show(err.Message); }
        }

        private void ClearOrdersPage()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        private void cmbemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbemp.SelectedIndex == -1)
                return;

            cmbshipvia.Enabled = true;
        }

        
    }
}
