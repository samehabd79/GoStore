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
    public partial class frmLogin : Form
    {
        private string _pass;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtLoginPass_TextChange(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar=true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            mycontrols.picProduct pic = new mycontrols.picProduct();
            string _username = "", _role = "", _NewPassword;
            try
            {
                bool found;
                string GoStore = "server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;";
                SqlConnection con = new SqlConnection(GoStore);
                SqlCommand com = new SqlCommand("SELECT * FROM tbUser WHERE Username=@user and Password=@pw", con);
                con.Open();
                com.Parameters.AddWithValue("@user", txtLoginUser.Text);
                com.Parameters.AddWithValue("@pw", txtLoginPass.Text);
                SqlDataReader DR = com.ExecuteReader();
                DR.Read();


                if (DR.HasRows)
                {
                    found = true;
                    _username = DR["username"].ToString();
                    _pass = DR["password"].ToString();
                    _role = DR["role"].ToString();
                    _NewPassword = DR["Date"].ToString();

                }
                else
                {
                    found = false;
                }
                DR.Close();
                con.Close();
                if (_role == "admin")
                {
                    MessageBox.Show("Welcome " + _username + " ^_^", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoginUser.Clear();
                    txtLoginPass.Clear();
                    this.Hide();
                    frmAdmin admin = new frmAdmin();
                    admin.lblUsername.Text = _username;
                    admin.lblRole.Text = _role;
                    admin.ShowDialog();
                }
                else if (_role == "client")
                {
                    MessageBox.Show("Welcome " + _username + " ^_^", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoginUser.Clear();
                    txtLoginPass.Clear();
                    this.Hide();
                    frmClient client = new frmClient();
                    client.lblUsername.Text = _username;
                    client.lblRole.Text = _role;
                    client.ShowDialog();
                    



                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frmRegister frmreg = new frmRegister();
            this.Hide();
            frmreg.ShowDialog();
            this.Close();
        }
    }
}
