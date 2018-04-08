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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=CAVIDAN-PC\SQLEXPRESS;Initial Catalog=miniHotel;Integrated Security=True");


        public void ShowCustomersList()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer",connection);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["CustomerId"].ToString();
                add.SubItems.Add(reader["CusName"].ToString());
                add.SubItems.Add(reader["CusSurName"].ToString());
                add.SubItems.Add(reader["CusGender"].ToString());
                add.SubItems.Add(reader["CusPhone"].ToString());
                add.SubItems.Add(reader["CusMail"].ToString());
                add.SubItems.Add(reader["CusSVN"].ToString());
                add.SubItems.Add(reader["CusRoomNo"].ToString());
                add.SubItems.Add(reader["CusPrice"].ToString());
                add.SubItems.Add(reader["CusEnterDate"].ToString());
                add.SubItems.Add(reader["CusExitDate"].ToString());

                listView1.Items.Add(add);
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ShowCustomersList();
        }
    }
}
