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
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(FrmUserLogin._conString);
        public static string _ActivateAdminID = FrmAdminLogin._activateAdminID;
        public static string _shippingOrder = "";
        public static string __UpdatingProductID = "";
        public static int selectedctg = 0;

        public void RefreshNewOrders()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT OrderID AS 'Sipariş No:', CustomerID AS 'Müşteri ID:', OrderDate as 'Sipariş Tarihi' FROM dbo.Orders where ShippedDate is NULL and EmployeeID='" + _ActivateAdminID + "' ORDER BY OrderDate Desc", connection);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            adapter.Dispose();
            connection.Close();
        }

        public void RefreshOldOrders()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT OrderID AS 'Sipariş No:', CustomerID AS 'Müşteri ID:', OrderDate as 'Sipariş Tarihi',ShippedDate as 'Gönderim Tarihi' FROM dbo.Orders where ShippedDate is not NULL and EmployeeID='" + _ActivateAdminID + "' ORDER BY OrderDate Desc", connection);
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            adapter.Dispose();
            connection.Close();
        }

        public void RefreshGridCustomers()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT CustomerID AS 'Müşteri ID', Contactname AS 'Müşteri Adı', CompanyName as 'Şirket Adı',Address as 'Adres',City as 'Şehir', PostalCode as 'Posta Kodu',Country as 'Ülke', Phone as 'Telefon',Activated as 'Durum'  FROM dbo.Customers", connection);
            adapter.Fill(ds);
            DataGridCustomers.DataSource = ds.Tables[0];
            adapter.Dispose();
            connection.Close();
        }


        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            RefreshNewOrders();
            RefreshOldOrders();
            RefreshGridCtg();
            RefreshCmbCategories();
            cmbCategories.SelectedIndex = 0;
            btnDelCtg.Enabled = false;
            btnDelShip.Enabled = false;
            btnUpdPrd.Enabled = false;
            btnUpdPrice.Enabled = false;
            btnDelPrd.Enabled = false;
            btnCstDel.Enabled = false;
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            RefreshGridShippers();
            RefreshGridCustomers();

            connection.Open();
            SqlCommand command = new SqlCommand("select Firstname,Lastname,Title from Employees where EmployeeID=@p1", connection);
            command.Parameters.AddWithValue("@p1", FrmAdminLogin._activateAdminID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                empName.Text = reader[0].ToString() + " " + reader[1].ToString();
                empTitle.Text = reader[2].ToString();
            }
            reader.Close();
            connection.Close();

        }

        private void FrmAdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnAcceptOrder_Click(object sender, EventArgs e)
        {
            _shippingOrder = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FrmSendOrder form = new FrmSendOrder();
            form.ShowDialog();
            if (FrmSendOrder.control)
            {
                RefreshNewOrders();
                RefreshOldOrders();
                ClearPage1();
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();

            }
        }

        private void btnCancelOrder_MouseEnter(object sender, EventArgs e)
        {
            btnCancelOrder.BackColor = Color.Firebrick;
            btnCancelOrder.ForeColor = Color.White;
        }

        private void btnCancelOrder_MauseLeave(object sender, EventArgs e)
        {
            btnCancelOrder.BackColor = Color.LightCoral;
            btnCancelOrder.ForeColor = Color.Black;
        }

        private void BtnAcceptOrder_MouseLeave(object sender, EventArgs e)
        {
            BtnAcceptOrder.BackColor = Color.MediumSpringGreen;
        }

        private void BtnAcceptOrder_MouseEnter(object sender, EventArgs e)
        {
            BtnAcceptOrder.BackColor = Color.LimeGreen;

        }

        private void btnDelCtg_MouseEnter(object sender, EventArgs e)
        {
            btnDelCtg.BackColor = Color.Gold;
        }

        private void btnDelCtg_MauseLeave(object sender, EventArgs e)
        {
            btnDelCtg.BackColor = Color.Khaki;
        }

        private void BtnAddCtg_MouseLeave(object sender, EventArgs e)
        {
            BtnAddCtg.BackColor = Color.MediumSpringGreen;
        }

        private void BtnAddCtg_MouseEnter(object sender, EventArgs e)
        {
            BtnAddCtg.BackColor = Color.LimeGreen;

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

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Firebrick;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.LightCoral;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (_shippingOrder == "")
            {
                MessageBox.Show("Önce bir sipariş seçin.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();
            SqlCommand delOrDt = new SqlCommand("delete from OrderDetails where OrderID=@p1", connection);
            delOrDt.Parameters.AddWithValue("@p1", _shippingOrder);
            delOrDt.ExecuteNonQuery();

            SqlCommand stock = new SqlCommand("update Products set UnitsInStock= UnitsInstock + @p1 where ProductName=@p2", connection);
            stock.Parameters.AddWithValue("@p1", textBox8.Text);
            stock.Parameters.AddWithValue("@p2", textBox7.Text);
            stock.ExecuteNonQuery();

            SqlCommand delOrDr = new SqlCommand("delete from Orders where OrderID=@p1", connection);
            delOrDr.Parameters.AddWithValue("@p1", _shippingOrder);
            delOrDr.ExecuteNonQuery();
            RefreshNewOrders();
            ClearPage1();
            connection.Close();
            MessageBox.Show("Müşteri siparişi iptal edildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void ClearPage1()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            string supplier = "";
            string category = "";
            string cnt = "";
            connection.Open();
            _shippingOrder = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            SqlCommand command1 = new SqlCommand("select CompanyName,ContactName from Customers where CustomerID=@p1", connection);
            command1.Parameters.AddWithValue("@p1", dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            SqlDataReader rd1 = command1.ExecuteReader();
            while (rd1.Read())
            {
                textBox2.Text = rd1[0].ToString();
                textBox1.Text = rd1[1].ToString();
            }
            rd1.Close();


            SqlCommand command2 = new SqlCommand("select ProductID,Quantity from OrderDetails where OrderID=@p1", connection);
            command2.Parameters.AddWithValue("@p1", _shippingOrder);
            SqlDataReader rdr2 = command2.ExecuteReader();
            rdr2.Read();
            string productid = rdr2[0].ToString();
            textBox8.Text = rdr2[1].ToString();
            rdr2.Close();

            SqlCommand commanddt = new SqlCommand("select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice from Products where ProductID=@p1", connection);
            commanddt.Parameters.AddWithValue("@p1", productid);
            SqlDataReader readerdt = commanddt.ExecuteReader();
            while (readerdt.Read())
            {
                textBox7.Text = readerdt[0].ToString();
                supplier = readerdt[1].ToString();
                category = readerdt[2].ToString();
                textBox9.Text = readerdt[3].ToString();
                cnt = readerdt[4].ToString();
                textBox10.Text = Math.Round(double.Parse(cnt), 2).ToString();
            }
            readerdt.Close();

            SqlCommand commandctg = new SqlCommand("select CategoryName,Description from Categories where CategoryID=@p1", connection);
            commandctg.Parameters.AddWithValue("@p1", category);
            SqlDataReader readerctg = commandctg.ExecuteReader();
            readerctg.Read();
            textBox13.Text = readerctg[0].ToString() + "-" + readerctg[1].ToString();
            readerctg.Close();

            SqlCommand commandsp = new SqlCommand("select CompanyName from Suppliers where SupplierID=@p1", connection);
            commandsp.Parameters.AddWithValue("@p1", supplier);
            SqlDataReader readersp = commandsp.ExecuteReader();
            readersp.Read();
            textBox12.Text = readersp[0].ToString();
            readersp.Close();
            readerdt.Close();

            SqlCommand cmdd = new SqlCommand("select Freight from orders where orderID=@p1", connection);
            cmdd.Parameters.AddWithValue("@p1", _shippingOrder);
            SqlDataReader cmtt = cmdd.ExecuteReader();
            cmtt.Read();
            textBox4.Text = Math.Round(double.Parse(cmtt[0].ToString()), 2).ToString();
            cmtt.Close();

            SqlCommand emp = new SqlCommand("select FirstName,LastName from Employees where EmployeeID=@p1", connection);
            emp.Parameters.AddWithValue("@p1", _ActivateAdminID);
            SqlDataReader empreader = emp.ExecuteReader();
            empreader.Read();
            textBox14.Text = empreader[0].ToString() + " " + empreader[1].ToString();
            empreader.Close();
            textBox11.Text = (double.Parse(textBox8.Text) * double.Parse(textBox10.Text) + double.Parse(textBox4.Text)).ToString();
            connection.Close();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count < 1)
                return;

            string supplier = "";
            string category = "";
            string cnt = "";
            connection.Open();
            string shippedOrder = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

            SqlCommand command1 = new SqlCommand("select CompanyName,ContactName from Customers where CustomerID=@p1", connection);
            command1.Parameters.AddWithValue("@p1", dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
            SqlDataReader rd1 = command1.ExecuteReader();
            while (rd1.Read())
            {
                textBox5.Text = rd1[0].ToString();
                textBox3.Text = rd1[1].ToString();
            }
            rd1.Close();


            SqlCommand command2 = new SqlCommand("select ProductID,Quantity from OrderDetails where OrderID=@p1", connection);
            command2.Parameters.AddWithValue("@p1", shippedOrder);
            SqlDataReader rdr2 = command2.ExecuteReader();
            rdr2.Read();
            string productid = rdr2[0].ToString();
            textBox17.Text = rdr2[1].ToString();
            rdr2.Close();

            SqlCommand commanddt = new SqlCommand("select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice from Products where ProductID=@p1", connection);
            commanddt.Parameters.AddWithValue("@p1", productid);
            SqlDataReader readerdt = commanddt.ExecuteReader();
            while (readerdt.Read())
            {
                textBox18.Text = readerdt[0].ToString();
                supplier = readerdt[1].ToString();
                category = readerdt[2].ToString();
                textBox21.Text = readerdt[3].ToString();
                cnt = readerdt[4].ToString();
                textBox16.Text = Math.Round(double.Parse(cnt), 2).ToString();
            }
            readerdt.Close();

            SqlCommand commandctg = new SqlCommand("select CategoryName,Description from Categories where CategoryID=@p1", connection);
            commandctg.Parameters.AddWithValue("@p1", category);
            SqlDataReader readerctg = commandctg.ExecuteReader();
            readerctg.Read();
            textBox22.Text = readerctg[0].ToString() + "-" + readerctg[1].ToString();
            readerctg.Close();

            SqlCommand commandsp = new SqlCommand("select CompanyName from Suppliers where SupplierID=@p1", connection);
            commandsp.Parameters.AddWithValue("@p1", supplier);
            SqlDataReader readersp = commandsp.ExecuteReader();
            readersp.Read();
            textBox20.Text = readersp[0].ToString();
            readersp.Close();
            readerdt.Close();

            SqlCommand cmdd = new SqlCommand("select Freight from orders where orderID=@p1", connection);
            cmdd.Parameters.AddWithValue("@p1", shippedOrder);
            SqlDataReader cmtt = cmdd.ExecuteReader();
            cmtt.Read();
            textBox15.Text = Math.Round(double.Parse(cmtt[0].ToString()), 2).ToString();
            cmtt.Close();

            SqlCommand emp = new SqlCommand("select FirstName,LastName from Employees where EmployeeID=@p1", connection);
            emp.Parameters.AddWithValue("@p1", _ActivateAdminID);
            SqlDataReader empreader = emp.ExecuteReader();
            empreader.Read();
            textBox19.Text = empreader[0].ToString() + " " + empreader[1].ToString();
            empreader.Close();
            textBox6.Text = (double.Parse(textBox17.Text) * double.Parse(textBox16.Text) + double.Parse(textBox15.Text)).ToString();
            connection.Close();
        }

        private void BtnAddCtg_Click(object sender, EventArgs e)
        {
            FrmAddCtg form = new FrmAddCtg();
            form.ShowDialog();
            if (FrmAddCtg.control)
            {
                RefreshGridCtg();
                RefreshCmbCategories();
            }
        }

        public void RefreshGridCtg()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select CategoryID as 'Kategori No',CategoryName as 'Kategori Adı', Description as 'Açıklama', Activated as 'Durum' from categories", connection);
            adapter.Fill(ds);
            dataGridCtg.DataSource = ds.Tables[0];
            adapter.Dispose();
            connection.Close();
            dataGridCtg.ClearSelection();


        }

        private void btnDelCtg_Click(object sender, EventArgs e)
        {
            if (dataGridCtg.SelectedRows.Count <= 0)
                return;

            string ctg = dataGridCtg.SelectedRows[0].Cells[0].Value.ToString();
            string control = dataGridCtg.SelectedRows[0].Cells[3].Value.ToString();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {

                if (control == "True")
                {
                    SqlCommand command = new SqlCommand("update categories set Activated='false' where categoryID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", ctg);
                    command.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand("update products set  Activated='false' where categoryID=@p1", connection);
                    command2.Parameters.AddWithValue("@p1", ctg);
                    command2.ExecuteNonQuery();

                    MessageBox.Show("Seçilen kategori etkisizleştirildi.");
                }

                else if (control == "False")
                {
                    SqlCommand command = new SqlCommand("update categories set Activated='true' where categoryID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", ctg);
                    command.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand("update products set  Activated='true' where categoryID=@p1", connection);
                    command2.Parameters.AddWithValue("@p1", ctg);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Seçilen kategori etkinleştirildi.");

                }
                RefreshCmbCategories();
                RefreshGridCtg();

                connection.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }

        public void RefreshCmbCategories()
        {
            cmbCategories.Items.Clear();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand cmbcommand = new SqlCommand("select Categoryname from Categories where Activated='true'", connection);
            SqlDataReader cmbreader = cmbcommand.ExecuteReader();
            while (cmbreader.Read())
            {
                cmbCategories.Items.Add(cmbreader[0]);
            }
            cmbreader.Close();
            connection.Close();
            cmbCategories.SelectedIndex = 0;
            RefreshGridProducts();

        }

        private void RefreshGridProducts()
        {
            if (cmbCategories.SelectedIndex < 0)
            {
                dataGridProducts.Rows.Clear();
                return;
            }

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlCommand cmd = new SqlCommand("select CategoryID from Categories where CategoryName=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", cmbCategories.SelectedItem.ToString());
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            var changed = rdr[0].ToString();
            rdr.Close();


            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select ProductID as 'Ürün No',ProductName as 'Ürün Adı', QuantityPerUnit as 'Ürün Detay',UnitPrice as 'Birim Fiyat',UnitsInStock as 'Stok',Activated as 'Durum' from products Where CategoryID='" + changed + "'", connection);
            adapter.Fill(ds);
            dataGridProducts.DataSource = ds.Tables[0];
            adapter.Dispose();
            connection.Close();
            dataGridProducts.ClearSelection();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex == -1)
                return;

            btnDelPrd.Enabled = true;
            btnUpdPrice.Enabled = true;
            btnUpdPrd.Enabled = true;
            selectedctg = cmbCategories.SelectedIndex;
            RefreshGridProducts();

        }

        private void dataGridCtg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnDelCtg.Enabled = false;
            if (dataGridCtg.SelectedRows.Count <= 0)
                return;

            string control = dataGridCtg.SelectedRows[0].Cells[3].Value.ToString();
            if (control == "True")
            {
                btnDelCtg.Text = "Devre Dışı Bırak";
                btnDelCtg.Enabled = true;
            }

            else if (control == "False")
            {
                btnDelCtg.Text = "Etkinleştir";
                btnDelCtg.Enabled = true;
            }
        }

        public void RefreshGridShippers()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select ShipperId as 'Şirket No',CompanyName as 'Şirket Adı', Phone as 'Telefon No', ShipPrice as 'Kargo Ücreti', Activated as 'Durum' from Shippers", connection);

            adapter.Fill(ds);
            dataGridShippers.DataSource = ds.Tables[0];
            adapter.Dispose();
            connection.Close();
            dataGridShippers.ClearSelection();


        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            FrmAddShpr form = new FrmAddShpr();
            form.ShowDialog();
            if (FrmAddShpr.control)
                RefreshGridShippers();
        }

        private void btnAddShipper_MouseEnter(object sender, EventArgs e)
        {
            btnAddShipper.BackColor = Color.LimeGreen;
        }

        private void btnAddShipper_MouseLeave(object sender, EventArgs e)
        {
            btnAddShipper.BackColor = Color.MediumSpringGreen;
        }

        private void btnDelShip_MouseEnter(object sender, EventArgs e)
        {
            btnDelShip.BackColor = Color.Gold;
        }

        private void btnDelShip_MouseLeave(object sender, EventArgs e)
        {
            btnDelShip.BackColor = Color.Khaki;
        }

        private void btnDelShip_Click(object sender, EventArgs e)
        {
            if (dataGridShippers.SelectedRows.Count <= 0)
                return;

            string shipid = dataGridShippers.SelectedRows[0].Cells[0].Value.ToString();
            string control = dataGridShippers.SelectedRows[0].Cells[3].Value.ToString();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {

                if (control == "True")
                {
                    SqlCommand command = new SqlCommand("update Shippers set Activated='false' where ShipperID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", shipid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seçilen şirket etkisizleştirildi.");
                }

                else if (control == "False")
                {
                    SqlCommand command = new SqlCommand("update Shippers set Activated='true' where ShipperID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", shipid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seçilen şirket etkinleştirildi.");

                }

                RefreshGridShippers();
                connection.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }

        private void dataGridShippers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnDelShip.Enabled = false;
            if (dataGridShippers.SelectedRows.Count <= 0)
                return;

            string control = dataGridShippers.SelectedRows[0].Cells[3].Value.ToString();
            if (control == "True")
            {
                btnDelShip.Text = "Devre Dışı Bırak";
                btnDelShip.Enabled = true;
            }

            else if (control == "False")
            {
                btnDelShip.Text = "Etkinleştir";
                btnDelShip.Enabled = true;
            }
        }


        private void btnDelPrd_MouseEnter(object sender, EventArgs e)
        {
            btnDelPrd.BackColor = Color.Gold;
        }

        private void btnDelPrd_MouseLeave(object sender, EventArgs e)
        {
            btnDelPrd.BackColor = Color.Khaki;
        }

        private void BtnAddPrdct_MouseEnter(object sender, EventArgs e)
        {
            BtnAddPrdct.BackColor = Color.LimeGreen;
        }

        private void BtnAddPrdct_MouseLeave(object sender, EventArgs e)
        {
            BtnAddPrdct.BackColor = Color.MediumSpringGreen;
        }

        private void btnUpdPrd_MouseEnter(object sender, EventArgs e)
        {
            btnUpdPrd.BackColor = Color.CadetBlue;
        }

        private void btnUpdPrd_MouseLeave(object sender, EventArgs e)
        {
            btnUpdPrd.BackColor = Color.SkyBlue;
        }

        private void btnUpdPrice_MouseLeave(object sender, EventArgs e)
        {
            btnUpdPrice.BackColor = Color.Pink;
        }

        private void btnUpdPrice_MouseEnter(object sender, EventArgs e)
        {
            btnUpdPrice.BackColor = Color.PaleVioletRed;
        }

        private void dataGridProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <= 0)
            {
                btnDelPrd.Enabled = false;
                btnUpdPrd.Enabled = false;
                btnUpdPrice.Enabled = false;
                return;
            }

            string control = dataGridProducts.SelectedRows[0].Cells[5].Value.ToString();
            __UpdatingProductID = dataGridProducts.SelectedRows[0].Cells[0].Value.ToString();
            if (control == "True")
            {
                btnDelPrd.Text = "Satıştan Kaldır";
                btnDelPrd.Enabled = true;
                btnUpdPrd.Enabled = true;
                btnUpdPrice.Enabled = true;
            }

            else if (control == "False")
            {
                btnDelPrd.Text = "Satışa Koy";
                btnDelPrd.Enabled = true;
                btnUpdPrd.Enabled = true;
                btnUpdPrice.Enabled = true;

            }
        }

        private void btnDelPrd_Click(object sender, EventArgs e)
        {

            if (dataGridProducts.SelectedRows.Count <= 0)
                return;

            string productid = dataGridProducts.SelectedRows[0].Cells[0].Value.ToString();
            string control = dataGridProducts.SelectedRows[0].Cells[5].Value.ToString();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {

                if (control == "True")
                {
                    SqlCommand command = new SqlCommand("update Products set Activated='false' where ProductID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", productid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seçilen ürün satıştan kaldırıldı.");
                }

                else if (control == "False")
                {
                    SqlCommand command = new SqlCommand("update Products set Activated='true' where ProductID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", productid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seçilen ürün satışa koyuldu.");

                }

                RefreshGridProducts();
                connection.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }

        private void btnUpdPrice_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <= 0)
                return;

            FrmUpdPrice form = new FrmUpdPrice();
            form.ShowDialog();

            if (FrmUpdPrice.control)
                RefreshGridProducts();

        }

        private void btnUpdPrd_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count <= 0)
                return;

            FrmUpdPrdct form = new FrmUpdPrdct();
            form.ShowDialog();

            if (FrmUpdPrdct.control)
                RefreshGridProducts();
        }

        private void BtnAddPrdct_Click(object sender, EventArgs e)
        {

            FrmAddProdct form = new FrmAddProdct();
            form.ShowDialog();

            if (FrmAddProdct.control)
                RefreshGridProducts();
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

        private void btnPass_Click(object sender, EventArgs e)
        {
            FrmUpAdminPass form = new FrmUpAdminPass();
            form.ShowDialog();
        }

        private void btnUsrinf_Click(object sender, EventArgs e)
        {
            FrmUpAdmin form = new FrmUpAdmin();
            form.ShowDialog();

            connection.Open();
            SqlCommand command = new SqlCommand("select Firstname,Lastname,Title from Employees where EmployeeID=@p1", connection);
            command.Parameters.AddWithValue("@p1", FrmAdminLogin._activateAdminID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                empName.Text = reader[0].ToString() + " " + reader[1].ToString();
                empTitle.Text = reader[2].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void btnCntinfo_Click(object sender, EventArgs e)
        {
            FrmUpAdminCnt form = new FrmUpAdminCnt();
            form.ShowDialog();
        }

        private void DataGridCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnCstDel.Enabled = false;
            if (DataGridCustomers.SelectedRows.Count <= 0)
                return;

            string control = DataGridCustomers.SelectedRows[0].Cells[8].Value.ToString();
            if (control == "True")
            {
                btnCstDel.Text = "Hesabı Engelle";
                btnCstDel.Enabled = true;
            }

            else if (control == "False")
            {
                btnCstDel.Text = "Hesabın Engelini Kaldır";
                btnCstDel.Enabled = true;
            }
        }

        private void btnCstDel_MouseEnter(object sender, EventArgs e)
        {
            btnCstDel.BackColor = Color.Gold;
        }

        private void btnCstDel_MouseLeave(object sender, EventArgs e)
        {
            btnCstDel.BackColor = Color.Khaki;
        }

        private void btnCstDel_Click(object sender, EventArgs e)
        {
            if (DataGridCustomers.SelectedRows.Count <= 0)
                return;

            string customerid = DataGridCustomers.SelectedRows[0].Cells[0].Value.ToString();
            string control = DataGridCustomers.SelectedRows[0].Cells[8].Value.ToString();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {

                if (control == "True")
                {
                    SqlCommand command = new SqlCommand("update Customers set Activated='false' where CustomerID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", customerid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seçilen hesap engellendi. \nArtık sisteme giriş yapamayacak.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (control == "False")
                {
                    SqlCommand command = new SqlCommand("update Customers set Activated='true' where CustomerID=@p1", connection);
                    command.Parameters.AddWithValue("@p1", customerid);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seçilen hesabın engeli açıldı. \nArtık sisteme giriş yapabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                connection.Close();
                RefreshGridCustomers();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }
    }

}
