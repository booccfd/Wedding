using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;

namespace Sales_Dasboard_Black_UI
{
    public partial class Login : Form
    {
        //string connectionString = @"Server=127.0.0.1;Database=bookdb;UserID=root;Password=";
        //private string connectionString = @"Server=localhost;Database=bookdb;UserID=root;Password=";
        private string pcUser;
        private string pcIp;
        private string pcLoged;
        private string pcLogging;

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Board boardfrm = new Board();
            MySqlConnection con = DbConnection.GetConnection();
            string username = txt_username.LabelText;
            con.Open();
            MySqlCommand mySqlCmd = new MySqlCommand("UserLogin", con);
            mySqlCmd.CommandType = CommandType.StoredProcedure;

            if (username == "")
            {
                txt_username_ipt.Show();
                username = txt_username_ipt.Text;
                // MessageBox.Show("Hello"+ username);
            }
            else {
                //MessageBox.Show(username);
            }

            mySqlCmd.Parameters.AddWithValue("_UserName", username);
            mySqlCmd.Parameters.AddWithValue("_Password", txt_password.Text.Trim());
            string output = mySqlCmd.ExecuteScalar().ToString();

            if (output == "1")
            {

                pcUser = Environment.MachineName;
                pcIp = Dns.GetHostAddresses(Environment.MachineName)[0].ToString();
                pcLoged = pcUser + " | " + pcIp;
                Properties.Settings.Default.PCLoged = pcLoged;
                Properties.Settings.Default.UserName = username;
                Properties.Settings.Default.Save();

                txt_password.Text = "";
                MessageBox.Show("Login is successfully!");
                this.Hide();
                boardfrm.Show();
            }
            else {
                lbl_error_log.Text = "Your login falied. Please provide the correct your login!";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Login_Load_1(object sender, EventArgs e)
        {


            txt_username_ipt.Text = "Enter username";
            txt_password.Text = "Enter password";

            pcUser = Environment.MachineName;
            pcIp = Dns.GetHostAddresses(Environment.MachineName)[0].ToString();
            //pcLogging = "12";
            //pcLoged = "123";
            pcLogging = pcUser + " | " + pcIp;
            pcLoged = Properties.Settings.Default.PCLoged;
            //MessageBox.Show(pcLogging);
            //MessageBox.Show(pcLoged);
            if (pcLoged==pcLogging) {
                txt_username.LabelText = Properties.Settings.Default.UserName;
            }
            else {
                txt_username.LabelText = "";
            }

            if (txt_username.LabelText != "") {
                txt_username_ipt.Hide();
               // MessageBox.Show(txt_username.LabelText);
            }else
            {
                txt_username.Hide();
                txt_username_ipt.Show();
            }

        }

        private void txt_username_ipt_Enter(object sender, EventArgs e)
        {
            if (txt_username_ipt.Text == "Enter username")
            {
                txt_username_ipt.Text = "";
            }
        }

        private void txt_username_ipt_Leave(object sender, EventArgs e)
        {
            if (txt_username_ipt.Text == "")
            {
                txt_username_ipt.Text = "Enter username";
                //txt_username_ipt.ForeColor = Color.Gray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Enter password")
            {
                txt_password.Text = "";
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Enter password";
                //txt_username_ipt.ForeColor = Color.Gray;
            }
        }
    }
}
