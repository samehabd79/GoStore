using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoStore
{
    public partial class frmClient : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public frmClient()
        {
            InitializeComponent();
        }
        string pageName;

        private void btnFrmAdminClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //connect button with pages
        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            pageName = "All Products";
            pagesClient.SetPage(allProductsPage.Text);
            lblTitleClient.Text = "All Products";
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            pageName = "Apple Devices";
            pagesClient.SetPage(applePage.Text);
            lblTitleClient.Text = "Apple Devices";
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            pageName = "Samsung Devices";
            pagesClient.SetPage(samsungPage.Text);
            lblTitleClient.Text = "Samsung Devices";
        }

        private void btnXaiomi_Click(object sender, EventArgs e)
        {
            pageName = "Xaiomi Devices";
            pagesClient.SetPage(xaiomiPage.Text);
            lblTitleClient.Text = "Xaiomi Devices";
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            pagesClient.SetPage(settingClientPage.Text);
            lblTitleClient.Text = "Profile Setting";
           
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goStoreDataSet3.tbProducts' table. You can move, or remove it, as needed.
            this.tbProductsTableAdapter1.Fill(this.goStoreDataSet3.tbProducts);
            // TODO: This line of code loads data into the 'goStoreDataSet3.Apple' table. You can move, or remove it, as needed.
            this.appleTableAdapter1.Fill(this.goStoreDataSet3.Apple);
            // TODO: This line of code loads data into the 'goStoreDataSet3.Xaiomi' table. You can move, or remove it, as needed.
            this.xaiomiTableAdapter.Fill(this.goStoreDataSet3.Xaiomi);
            // TODO: This line of code loads data into the 'goStoreDataSet3.Samsung' table. You can move, or remove it, as needed.
            this.samsungTableAdapter.Fill(this.goStoreDataSet3.Samsung);
            // TODO: This line of code loads data into the 'goStoreDataSet2.Apple' table. You can move, or remove it, as needed.
            this.appleTableAdapter.Fill(this.goStoreDataSet2.Apple);
            // TODO: This line of code loads data into the 'goStoreDataSetProducts.tbProducts' table. You can move, or remove it, as needed.
            this.tbProductsTableAdapter.Fill(this.goStoreDataSetProducts.tbProducts);

        }
        //בדיקה ל חיפוש בכל חלון
        public void All()
        {
            if(pageName=="All Products")
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from tbProducts where Name LIKE'%" + txtSearch.Text + "%';", con);
                dt = new DataTable();
                adpt.Fill(dt);
                viewAll.DataSource = dt;
                con.Close();
            }
            else if (pageName == "Apple Devices")
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Apple where Name LIKE'%" + txtSearch.Text + "%';", con);
                dt = new DataTable();
                adpt.Fill(dt);
                viewApple.DataSource = dt;
                con.Close();
            }
            else if (pageName == "Samsung Devices")
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Samsung where Name LIKE'%" + txtSearch.Text + "%';", con);
                dt = new DataTable();
                adpt.Fill(dt);
                viewSamsung.DataSource = dt;
                con.Close();
            }
            else if (pageName == "Xaiomi Devices")
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from Xaiomi where Name LIKE'%" + txtSearch.Text + "%';", con);
                dt = new DataTable();
                adpt.Fill(dt);
                viewXaiomi.DataSource = dt;
                con.Close();
            }

        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            All();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            pagesClient.SetPage(viewCard.Text);
            lblTitleClient.Text = "Your Card";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {

                int n;
                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE tbUser SET NewPassword= '" + txtNewPass.Text + "' WHERE Password='" + txtOldPass.Text + "';";
                n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("updated  " + n.ToString() + " Successfully");
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "UpdateUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
