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
    public partial class frmEditProduct : Form
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }

        private void picDeleteProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {

                int n;
                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE tbProducts SET Name= '" + txtNameUpdateProduct.Text + "',Model= '" + txtModelUpdateProduct.Text + "',Price= '" + txtPriceUpdateProduct.Text + "' WHERE Id='" + txtidforupdate.Text + "';";
                n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("updated  " + n.ToString() + " Successfully");
                txtidforupdate.Text = "";
                txtNameUpdateProduct.Text = "";
                txtModelUpdateProduct.Text = "";
                txtModelUpdateProduct.Text = "";
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Mytest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
