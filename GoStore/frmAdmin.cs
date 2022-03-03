using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoStore
{
    public partial class frmAdmin : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        private object sqlDB;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnFrmAdminClose_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goStoreDataSet3.tbProducts' table. You can move, or remove it, as needed.
            this.tbProductsTableAdapter1.Fill(this.goStoreDataSet3.tbProducts);
            // TODO: This line of code loads data into the 'goStoreDataSet3.tbUser' table. You can move, or remove it, as needed.
            this.tbUserTableAdapter2.Fill(this.goStoreDataSet3.tbUser);
            // TODO: This line of code loads data into the 'goStoreDataSetProducts.tbProducts' table. You can move, or remove it, as needed.
            this.tbProductsTableAdapter.Fill(this.goStoreDataSetProducts.tbProducts);
            // TODO: This line of code loads data into the 'goStoreDataSet1.tbUser' table. You can move, or remove it, as needed.
            this.tbUserTableAdapter1.Fill(this.goStoreDataSet1.tbUser);
            // TODO: This line of code loads data into the 'goStoreDataSet.tbUser' table. You can move, or remove it, as needed.
           // this.tbUserTableAdapter.Fill(this.goStoreDataSet.tbUser);

        }
        byte[] convertimage(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image convertByteToArryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            pages.SetPage(productsPage.Text);
            lbltitleAdmin.Text = "Products";
            //Image img = Image.FromFile("images/ax.png");
            //DataTable dt = productsDataView.DataSource as DataTable;


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pages.SetPage(dashboardPage.Text);
            lbltitleAdmin.Text = "Dashboard";
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            pages.SetPage(ordersPage.Text);
            lbltitleAdmin.Text = "Orders";
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            pages.SetPage(customersPage.Text);
            lbltitleAdmin.Text = "Customers";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            pages.SetPage(settingPage.Text);
            lbltitleAdmin.Text = "Setting";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAdd = new frmAddProduct();
            frmAdd.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frmDeleteProduct frmDel = new frmDeleteProduct();
            frmDel.ShowDialog();
        }

        private void picRefreshProduct_Click(object sender, EventArgs e)
        {
            SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            SqlDataAdapter sqlDB = new SqlDataAdapter("SELECT Id ,Name ,Model ,Price FROM tbProducts", mySqlConnection);
            mySqlConnection.Open();
            DataTable dbtl = new DataTable();
            sqlDB.Fill(dbtl);
            productsDataView.DataSource = dbtl;

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmEditProduct frmEdit = new frmEditProduct();
            frmEdit.ShowDialog();
        }

        private void txtSearchAdmin_TextChange(object sender, EventArgs e)
        {

            con.Open();
            adpt = new SqlDataAdapter("select * from tbProducts where Name LIKE'%" + txtSearchAdmin.Text + "%';", con);
            dt = new DataTable();
            adpt.Fill(dt);
            productsDataView.DataSource=dt;
            con.Close();

        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frmEdit = new frmEditUser();
            frmEdit.ShowDialog();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            SqlDataAdapter sqlDB = new SqlDataAdapter("SELECT Id ,Username ,Password,Role FROM tbUser", mySqlConnection);
            mySqlConnection.Open();
            DataTable dbtl = new DataTable();
            sqlDB.Fill(dbtl);
            CustomerDataView.DataSource = dbtl;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmDeleteUser frmDel = new frmDeleteUser();
            frmDel.ShowDialog();
        }
    }
}
