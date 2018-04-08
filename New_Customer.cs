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
    public partial class New_Customer : Form
    {
        public New_Customer()
        {
            InitializeComponent();
            txtRoomNo.Enabled = false;
            txtPNo.MaxLength = 11;
            genderBox.Items.Add("Male");
            genderBox.Items.Add("Female");

        }


        SqlConnection connection = new SqlConnection("Data Source=CAVIDAN-PC\\SQLEXPRESS;Initial Catalog=miniHotel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "101";
        }

        private void room102_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "102";
        }

        private void room103_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "103";
        }

        private void room104_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "104";
        }

        private void room105_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "105";
        }

        private void room106_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "106";
        }

        private void room107_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "107";
        }

        private void room108_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "108";
        }

        private void room109_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "109";
        }

        private void butonExampleFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red Button Introduce to You Full Rooms");
        }

        private void butonExampleeMPTY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YellowGreen Button Introduce to You Empty Rooms");
            
        }



        public int calculateRoomPrice() {

            int totalPrice;
            int roomPrice = 50;
            DateTime customerEnterDate = Convert.ToDateTime(dtPickrEnter.Text);
            DateTime customerExitDate = DateTime.Parse(dtPickerExit.Text);

            TimeSpan Result;

            Result = customerExitDate - customerEnterDate;

            label8.Text = Result.TotalDays.ToString();


            totalPrice = int.Parse(label8.Text)*roomPrice;

            txtPrice.Text = totalPrice.ToString();

            return totalPrice;
            
        }

        private void dtPickerExit_ValueChanged(object sender, EventArgs e)
        {
            calculateRoomPrice();
        }


        public void addNewCustomerToDataBase()
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into AddCustomer (CusName,CusSurName,CusGender,CusPhone,CusMail,CusSVN,CusRoomNo,CusPrice,CusEnterDate,CusExitDate) values('" + txtName.Text + "','" + txtSurName.Text + "','" + genderBox.SelectedItem + "','" + mskTxTPhone.Text + "','" + txtMail.Text + "','" + txtPNo.Text + "','" + txtRoomNo.Text + "','" + txtPrice.Text + "','" + dtPickrEnter.Value.ToString("yyyy-MM-dd")+"','" + dtPickerExit.Value.ToString("yyyy-MM-dd")+"')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Complete Succesfuly");
        }


        private void saveCust_Click(object sender, EventArgs e)
        {
           
       

            addNewCustomerToDataBase();

            txtName.Text = "";
            txtSurName.Text = "";
            genderBox.Items.Clear();
            mskTxTPhone.Text = "";
            txtMail.Text = "";
            txtPNo.Text = "";
            txtRoomNo.Text = "";
            dtPickrEnter.ResetText();
            dtPickerExit.ResetText();
        }
    }
}

//Data Source=CAVIDAN-PC\SQLEXPRESS;Initial Catalog=miniHotel;Integrated Security=True