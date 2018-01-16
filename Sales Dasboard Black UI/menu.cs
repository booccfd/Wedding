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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;

            // Add this for the real edge of the screen:
            x = 0; // for Left Border or Get the screen Dimension to set it on the Right

            this.Location = new Point(x, y-10);
        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shutdown");
        }
    }
}
