namespace pizzaOrder_Project
{
    partial class frmMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelXd = new System.Windows.Forms.Panel();
            this.panelHomeButtons = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeAdress = new System.Windows.Forms.Button();
            this.btnChangePhone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.btnPlaceTheOrder = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelXd.SuspendLayout();
            this.panelHomeButtons.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelHomeButtons);
            this.panelSideMenu.Controls.Add(this.panelHome);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Controls.Add(this.btnAccountSettings);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 925);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelXd
            // 
            this.panelXd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelXd.Controls.Add(this.label1);
            this.panelXd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelXd.Location = new System.Drawing.Point(250, 873);
            this.panelXd.Name = "panelXd";
            this.panelXd.Size = new System.Drawing.Size(1544, 52);
            this.panelXd.TabIndex = 2;
            // 
            // panelHomeButtons
            // 
            this.panelHomeButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelHomeButtons.Controls.Add(this.btnAbout);
            this.panelHomeButtons.Controls.Add(this.btnRegister);
            this.panelHomeButtons.Controls.Add(this.btnLogin);
            this.panelHomeButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeButtons.Location = new System.Drawing.Point(0, 606);
            this.panelHomeButtons.Name = "panelHomeButtons";
            this.panelHomeButtons.Size = new System.Drawing.Size(250, 127);
            this.panelHomeButtons.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(250, 40);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegister.Location = new System.Drawing.Point(0, 40);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegister.Size = new System.Drawing.Size(250, 40);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.LightGray;
            this.btnAbout.Location = new System.Drawing.Point(0, 80);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 40);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 557);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(250, 49);
            this.panelHome.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 45);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.btnChangePhone);
            this.panel2.Controls.Add(this.btnChangeAdress);
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Controls.Add(this.btnChangeUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 162);
            this.panel2.TabIndex = 7;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeUsername.FlatAppearance.BorderSize = 0;
            this.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.ForeColor = System.Drawing.Color.LightGray;
            this.btnChangeUsername.Location = new System.Drawing.Point(0, 0);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChangeUsername.Size = new System.Drawing.Size(250, 40);
            this.btnChangeUsername.TabIndex = 7;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUsername.UseVisualStyleBackColor = true;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.LightGray;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 40);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(250, 40);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeAdress
            // 
            this.btnChangeAdress.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeAdress.FlatAppearance.BorderSize = 0;
            this.btnChangeAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAdress.ForeColor = System.Drawing.Color.LightGray;
            this.btnChangeAdress.Location = new System.Drawing.Point(0, 80);
            this.btnChangeAdress.Name = "btnChangeAdress";
            this.btnChangeAdress.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChangeAdress.Size = new System.Drawing.Size(250, 40);
            this.btnChangeAdress.TabIndex = 10;
            this.btnChangeAdress.Text = "Change Adress";
            this.btnChangeAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeAdress.UseVisualStyleBackColor = true;
            this.btnChangeAdress.Click += new System.EventHandler(this.btnChangeAdress_Click);
            // 
            // btnChangePhone
            // 
            this.btnChangePhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePhone.FlatAppearance.BorderSize = 0;
            this.btnChangePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhone.ForeColor = System.Drawing.Color.LightGray;
            this.btnChangePhone.Location = new System.Drawing.Point(0, 120);
            this.btnChangePhone.Name = "btnChangePhone";
            this.btnChangePhone.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChangePhone.Size = new System.Drawing.Size(250, 40);
            this.btnChangePhone.TabIndex = 11;
            this.btnChangePhone.Text = "Change Phone";
            this.btnChangePhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePhone.UseVisualStyleBackColor = true;
            this.btnChangePhone.Click += new System.EventHandler(this.btnChangePhone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnOrderHistory);
            this.panel1.Controls.Add(this.btnPlaceTheOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 121);
            this.panel1.TabIndex = 2;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccountSettings.Location = new System.Drawing.Point(0, 350);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccountSettings.Size = new System.Drawing.Size(250, 45);
            this.btnAccountSettings.TabIndex = 5;
            this.btnAccountSettings.Text = "Account";
            this.btnAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSettings.UseVisualStyleBackColor = true;
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // btnPlaceTheOrder
            // 
            this.btnPlaceTheOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaceTheOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceTheOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceTheOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlaceTheOrder.Location = new System.Drawing.Point(0, 0);
            this.btnPlaceTheOrder.Name = "btnPlaceTheOrder";
            this.btnPlaceTheOrder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPlaceTheOrder.Size = new System.Drawing.Size(250, 40);
            this.btnPlaceTheOrder.TabIndex = 1;
            this.btnPlaceTheOrder.Text = "Place the Order";
            this.btnPlaceTheOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceTheOrder.UseVisualStyleBackColor = true;
            this.btnPlaceTheOrder.Click += new System.EventHandler(this.btnPlaceTheOrder_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.ForeColor = System.Drawing.Color.LightGray;
            this.btnOrderHistory.Location = new System.Drawing.Point(0, 40);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOrderHistory.Size = new System.Drawing.Size(250, 40);
            this.btnOrderHistory.TabIndex = 2;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogOut.Location = new System.Drawing.Point(0, 80);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::pizzaOrder_Project.Properties.Resources.cc8986891211ee27433686b93a6329971;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 184);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
//            this.panelLogo.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.panelLogo_ChangeUICues);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.Location = new System.Drawing.Point(0, 184);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(250, 45);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Pizza";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1544, 873);
            this.panelChildForm.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelChildForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1544, 873);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Minanur Gündoğdu";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 925);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelXd);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Pizza Ordering System";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelXd.ResumeLayout(false);
            this.panelXd.PerformLayout();
            this.panelHomeButtons.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelHomeButtons;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelHome;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangePhone;
        private System.Windows.Forms.Button btnChangeAdress;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeUsername;
        public System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnPlaceTheOrder;
        public System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelXd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel3;
    }
}

