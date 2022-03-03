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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void txtRegisterPass_TextChange(object sender, EventArgs e)
        {
            txtRegisterPass.UseSystemPasswordChar = true;
        }

        private void txtRegisterPass2_TextChange(object sender, EventArgs e)
        {
            txtRegisterPass2.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into tbUser(Username ,Password ,Role) values('" + txtRegisterUser.Text + "', '" + txtRegisterPass.Text + "', '" + "client" + "');";
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Register Successfully");
                frmLogin login = new frmLogin();
                this.Hide();
                login.ShowDialog();
                this.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
