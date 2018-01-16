using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Dasboard_Black_UI
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;

            // Add this for the real edge of the screen:
            x = 0; // for Left Border or Get the screen Dimension to set it on the Right

            this.Location = new Point(x, y);
            txt_search.Text = "Search";

            loadHomeView();
        }


        private void btn_employee_Click(object sender, EventArgs e)
        {
            //container.Controls.Clear();
            app01 view01 = new app01();
            view01.TopLevel = false;
            container.Controls.Add(view01);
            view01.Show();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            popAddNew01 popadd = new popAddNew01();
            popadd.Show();
        }

        private void txt_search_Enter_1(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search")
            {
                txt_search.Text = "";
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search";
                //txt_username_ipt.ForeColor = Color.Gray;
            }
        }

        private void btn_window_Click(object sender, EventArgs e)
        {
            // clear all views
            //container.Controls.Clear();
            menu menuView = new menu();
            //menuView.TopLevel = false;
            //container.Controls.Add(menuView);
            menuView.Show();
            //Login login = new Login();
            //login.Show();
            //this.Hide();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            //container.Controls.Clear();
            app02 view02 = new app02();
            view02.TopLevel = false;
            container.Controls.Add(view02);
            view02.Show();
        }

        private void btn_viewExplore_Click(object sender, EventArgs e)
        {
            loadHomeView();
        }
        void loadHomeView() {
            homeView homeview = new homeView();
            homeview.TopLevel = false;
            container.Controls.Add(homeview);
            homeview.Show();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
