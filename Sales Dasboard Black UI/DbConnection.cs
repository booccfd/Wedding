using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sales_Dasboard_Black_UI
{
    class DbConnection
    {
        private static string connectionString = @"Server=localhost;Database=bookdb;UserID=root;Password=";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                //MessageBox.Show("Connection success !");
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Connection failed!" + error);
            }
            return con;
        }
    }
}
