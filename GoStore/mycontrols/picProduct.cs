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

namespace GoStore.mycontrols
{
    public partial class picProduct : UserControl
    {
        public picProduct()
        {
            InitializeComponent();
        }

        private void picProduct_Load(object sender, EventArgs e)
        {
            string _name = "";
            int _price = 0;
            bool found;
            string GoStore = "server=DESKTOP-DN6FB2D\\SQLEXPRESS;database=GoStore;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(GoStore);
            SqlCommand com = new SqlCommand("SELECT * FROM tbProducts WHERE Name=@name and Price=@price", con);
            con.Open();
            com.Parameters.AddWithValue("@name", Name);
            com.Parameters.AddWithValue("@price", _price);
            SqlDataReader DR = com.ExecuteReader();
            DR.Read();
            mycontrols.picProduct picfrm = new mycontrols.picProduct();
            picfrm.lblNameProduct.Text = Name;
            picfrm.lblPriceProduct.Text = _price.ToString();
            picfrm.Show();
        }
    }
}
