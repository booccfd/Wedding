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
    public partial class app01 : Form
    {
        private ListBox listBox1;
        public app01()
        {
            InitializeComponent();

            InitializeComponent1();
        }

        [STAThread]


        private void InitializeComponent1()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Items.AddRange(new object[] {
            "Item 1, column 1",
            "Item 2, column 1",
            "Item 3, column 1",
            "Item 4, column 1",
            "Item 5, column 1",
            "Item 1, column 2",
            "Item 2, column 2",
            "Item 3, column 2"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.ColumnWidth = 85;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void app01_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;

            // Add this for the real edge of the screen:
            x = 0; // for Left Border or Get the screen Dimension to set it on the Right

            this.Location = new Point(x, y);




        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            popAddNew01 pop01 = new popAddNew01();
            pop01.Show(); 
        }
    }
}
