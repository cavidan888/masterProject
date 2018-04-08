using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Wide_App
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void adinSec_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {
            New_Customer nc = new New_Customer();
            nc.Show();
            this.Hide();
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
           
            rms.Show();
        }

        private void cstBtn_Click(object sender, EventArgs e)
        {
            Customers cstmrs = new Customers();
            cstmrs.Show();
        }
    }
}
