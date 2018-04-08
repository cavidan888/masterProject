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
using System.Data.Sql;

namespace C_Sharp_Wide_App
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            txtUserPass.UseSystemPasswordChar = true;
        }

        SqlConnection connectionForAdmin = new SqlConnection(@"Data Source=CAVIDAN-PC\SQLEXPRESS;Initial Catalog=miniHotel;Integrated Security=True");
        private void entryBtn_Click(object sender, EventArgs e)
        {
            checkAdmin();
        }


        public void checkAdmin()
        {



            if (txtUserName.Text == "Admin" && txtUserPass.Text == "123456")
            {
                MainPage mp = new MainPage();
                this.Hide();
                mp.Show();
            }
            else
            {
                MessageBox.Show("You Are Not Admin!!!");
            }
        }
    }
}
