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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {

                int n;
                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = mySqlCommand.CommandText = "delete from tbUser where Id='" + txtUserIdToDelete.Text + "';";
                n = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete  " + n.ToString() + " Successfully");
                mySqlConnection.Close();
                txtUserIdToDelete.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Mytest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
