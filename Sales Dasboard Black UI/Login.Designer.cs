namespace Sales_Dasboard_Black_UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_username = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_error_log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_username_ipt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 464);
            this.panel2.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txt_password.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txt_password.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txt_password.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txt_password.BorderThickness = 3;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_password.isPassword = true;
            this.txt_password.Location = new System.Drawing.Point(83, 253);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(324, 42);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.SeaGreen;
            this.txt_username.color = System.Drawing.Color.SeaGreen;
            this.txt_username.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Image = ((System.Drawing.Image)(resources.GetObject("txt_username.Image")));
            this.txt_username.ImagePosition = 20;
            this.txt_username.ImageZoom = 50;
            this.txt_username.LabelPosition = 41;
            this.txt_username.LabelText = "";
            this.txt_username.Location = new System.Drawing.Point(189, 107);
            this.txt_username.Margin = new System.Windows.Forms.Padding(6);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(128, 129);
            this.txt_username.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 0;
            this.btn_login.ButtonText = "";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_login.Iconimage")));
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(407, 253);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(44, 43);
            this.btn_login.TabIndex = 5;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderRadius = 0;
            this.btn_close.ButtonText = "X";
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DisabledColor = System.Drawing.Color.Gray;
            this.btn_close.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_close.Iconimage = null;
            this.btn_close.Iconimage_right = null;
            this.btn_close.Iconimage_right_Selected = null;
            this.btn_close.Iconimage_Selected = null;
            this.btn_close.IconMarginLeft = 0;
            this.btn_close.IconMarginRight = 0;
            this.btn_close.IconRightVisible = true;
            this.btn_close.IconRightZoom = 0D;
            this.btn_close.IconVisible = true;
            this.btn_close.IconZoom = 90D;
            this.btn_close.IsTab = false;
            this.btn_close.Location = new System.Drawing.Point(517, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.btn_close.OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(26, 26);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "X";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Textcolor = System.Drawing.Color.Red;
            this.btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_error_log
            // 
            this.lbl_error_log.AutoSize = true;
            this.lbl_error_log.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_error_log.Location = new System.Drawing.Point(80, 301);
            this.lbl_error_log.Name = "lbl_error_log";
            this.lbl_error_log.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_log.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.panel3.Controls.Add(this.txt_username_ipt);
            this.panel3.Controls.Add(this.lbl_error_log);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_login);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(202, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 464);
            this.panel3.TabIndex = 2;
            // 
            // txt_username_ipt
            // 
            this.txt_username_ipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txt_username_ipt.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txt_username_ipt.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txt_username_ipt.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txt_username_ipt.BorderThickness = 3;
            this.txt_username_ipt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username_ipt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_username_ipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_username_ipt.isPassword = false;
            this.txt_username_ipt.Location = new System.Drawing.Point(82, 179);
            this.txt_username_ipt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username_ipt.Name = "txt_username_ipt";
            this.txt_username_ipt.Size = new System.Drawing.Size(369, 42);
            this.txt_username_ipt.TabIndex = 8;
            this.txt_username_ipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username_ipt.Enter += new System.EventHandler(this.txt_username_ipt_Enter);
            this.txt_username_ipt.Leave += new System.EventHandler(this.txt_username_ipt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 464);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_password;
        private Bunifu.Framework.UI.BunifuTileButton txt_username;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_error_log;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_username_ipt;
    }
}

