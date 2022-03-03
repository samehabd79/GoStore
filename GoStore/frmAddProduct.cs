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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        public void InsertProduct(string tableName)
        {
            try
            {
                string GoStore = "server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;";
                SqlConnection con = new SqlConnection(GoStore);
                SqlCommand com = new SqlCommand("INSERT INTO "+tableName+"(Name ,Model ,Price) VALUES (@name, @model, @price)", con);
                con.Open();
                com.Parameters.AddWithValue("@name", txtProductName.Text);
                com.Parameters.AddWithValue("@model", txtProductModel.Text);
                com.Parameters.AddWithValue("@price", txtProductPrice.Text);
                SqlDataReader DR = com.ExecuteReader();
                DR.Read();
                MessageBox.Show("Product Was Added Sccessfully");
                //txtProductName.Text = "";
                //txtProductModel.Text = "";
                //txtProductPrice.Text = "";
                DR.Close();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "GoStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            InsertProduct("tbProducts");
            if(category.Text == "Apple")
            {
                InsertProduct("Apple");

            }
            else if (category.Text == "Samsung")
            {
                InsertProduct("Samsung");

            }
            else if (category.Text == "Xaiomi")
            {
                InsertProduct("Xaiomi");

            }
            txtProductName.Text = "";
            txtProductModel.Text = "";
            txtProductPrice.Text = "";


            //try
            //{
            //    string GoStore = "server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;";
            //    SqlConnection con = new SqlConnection(GoStore);
            //    SqlCommand com = new SqlCommand("INSERT INTO tbProducts(Name ,Model ,Price) VALUES (@name, @model, @price)", con);
            //    con.Open();
            //    com.Parameters.AddWithValue("@name", txtProductName.Text);
            //    com.Parameters.AddWithValue("@model", txtProductModel.Text);
            //    com.Parameters.AddWithValue("@price", txtProductPrice.Text);
            //    SqlDataReader DR = com.ExecuteReader();
            //    DR.Read();
            //    MessageBox.Show("Product Was Added Sccessfully");
            //    //txtProductId.Text = "";
            //    txtProductName.Text = "";
            //    txtProductModel.Text = "";
            //    txtProductPrice.Text = "";
            //    DR.Close();
            //    con.Close();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "GoStore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void picAddProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goStoreDataSet2.Apple' table. You can move, or remove it, as needed.
            this.appleTableAdapter.Fill(this.goStoreDataSet2.Apple);

        }
    }
}
