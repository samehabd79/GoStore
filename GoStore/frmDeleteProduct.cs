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
    public partial class frmDeleteProduct : Form
    {
        public frmDeleteProduct()
        {
            InitializeComponent();
        }

        private void picDeleteProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteProdect_Click(object sender, EventArgs e)
        {
            try
            {

                int n;
                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = mySqlCommand.CommandText = "delete from tbProducts where Id='" + txtProductIdToDelete.Text + "';";
                n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete  " + n.ToString() + " Successfully");
                mySqlConnection.Close();
                txtProductIdToDelete.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Mytest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}