using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sales_Dasboard_Black_UI
{
    public partial class popAddNew01 : Form
    {
        MySqlConnection con = DbConnection.GetConnection();
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public popAddNew01()
        {
            InitializeComponent();
        }

        private void btn_clsadd_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosePopup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popAddNew01_Load(object sender, EventArgs e)
        {
            province_list.Hide();
            district_list.Hide();
            communce_list.Hide();
            village_list.Hide();

            /* System.Text.StringBuilder sb = new System.Text.StringBuilder();
             foreach (object item in province_list.Items)
             {
                 sb.Append(item.ToString());
                 sb.Append(" | ");
             }*/


            try {
                con.Open();
                command = new MySqlCommand("ProvinceViewAll", con);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = command.ExecuteReader();
 
                while (reader.Read())
                    //province_list.Items.Add(String.Format("ID","Name"));
                   // province_list.Items.Add(reader["titleKhmer"].ToString());
                    province_list.Items.AddRange(new object[] {
                        //reader["id"].ToString(), reader["titleKhmer"].ToString()
                        /*"Item 1, column 1",
                        "Item 2, column 1",
                        "Item 3, column 1",
                        "Item 4, column 1",
                        "Item 5, column 1",
                        "Item 1, column 2",
                        "Item 2, column 2",
                        "Item 3, column 2"*/
                    });
                reader.Close();
                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex);
            }

        }

        private void btnn_combo_province_Click(object sender, EventArgs e)
        {
            district_list.Hide();
            communce_list.Hide();
            village_list.Hide();
            province_list.Show();
            province_list.BringToFront();
        }

        private void up_province_Click(object sender, EventArgs e)
        {
            province_list.Hide();
        }

        private void down_district_Click(object sender, EventArgs e)
        {
            province_list.Hide();
            communce_list.Hide();
            village_list.Hide();
            district_list.Show();
            district_list.BringToFront();
        }

        private void communce_down_Click(object sender, EventArgs e)
        {
            province_list.Hide();
            district_list.Hide();
            village_list.Hide();
            communce_list.Show();
            communce_list.BringToFront();
        }

        private void village_down_Click(object sender, EventArgs e)
        {
            province_list.Hide();
            district_list.Hide();
            communce_list.Hide();
            village_list.Show();
            village_list.BringToFront();
        }

        private void up_district_Click(object sender, EventArgs e)
        {
            district_list.Hide();
        }

        private void communce_up_Click(object sender, EventArgs e)
        {
            communce_list.Hide();
        }

        private void village_up_Click(object sender, EventArgs e)
        {
            village_list.Hide();
        }

        private void province_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_province_value.Text = province_list.SelectedItem.ToString();
            province_list.SendToBack();



            //MessageBox.Show(province_list.SelectedItem.ToString());
        }

        private void lbl_province_value_Click(object sender, EventArgs e)
        {
            district_list.Hide();
            communce_list.Hide();
            village_list.Hide();
            province_list.Show();
            province_list.BringToFront();
        }
    }
}
