using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaOrder_Project
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void customizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Pizza
        private void btnAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmPlaceTheOrder());
            hideSubMenu();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmOrderHistory());
            hideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            User.Username = "";
            User.Password = "";
            User.Adress = "";
            User.Phone = "";
            User.AccountDate = "";
            User.ID = 0;
            
            
            hideSubMenu();
            btnAccount.Visible = false;
            btnAccountSettings.Visible = false;
            btnHome.Visible = true;
            panelHomeButtons.Visible = true;

            activeForm.Close();
        }
        #endregion
        #region Account
        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmChangeUsername());
            //..
            //my codes.
            //..
            hideSubMenu();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmChangePassword());
            //..
            //my codes.
            //..
            hideSubMenu();
        }

        private void btnChangeCreditCard_Click(object sender, EventArgs e)
        {
            //..
            //my codes.
            //..
            hideSubMenu();
        }

        private void btnChangeAdress_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmChangeAdress());
            //..
            //my codes.
            //..
            hideSubMenu();
        }

        private void btnChangePhone_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmChangePhone());
            //..
            //my codes.
            //..
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (User.Username != "")
                openChildFormInPanel(new frmCustomerStats());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            btnAccount.Visible = false;
            btnAccountSettings.Visible = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin LoginTheme = new frmLogin();
            LoginTheme.ShowDialog();

            if (User.Username != "")
            {
                btnAccount.Visible = true;
                btnAccountSettings.Visible = true;
                btnHome.Visible = false;
                panelHomeButtons.Visible = false;
                openChildFormInPanel(new frmCustomerStats());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister RegisterTheme = new frmRegister();
            RegisterTheme.ShowDialog();


            if (User.Username != "")
            {
                btnAccount.Visible = true;
                btnAccountSettings.Visible = true;
                btnHome.Visible = false;
                panelHomeButtons.Visible = false;
                openChildFormInPanel(new frmCustomerStats());
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Minanur Gündoğdu");
        }
    }
}
