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

namespace pizzaOrder_Project
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        Cmds cmds = new Cmds();
        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            if(txtOldPassword.Text == User.Password)
            {
                if(txtNewPassword.Text == txtNewPasswordAgain.Text)
                {
                    if(txtNewPassword.Text != User.Password)
                    {
                        cmds.Update("Password", txtNewPassword.Text, User.Password);
                        User.Password = txtNewPassword.Text;
                        MessageBox.Show("Şifre başarıyla değiştirildi.");
                    }
                    else
                        MessageBox.Show("yeni şifre eskisiyle aynı olamaz.");
                }
                else
                    MessageBox.Show("password are not same");
            }
            else
                MessageBox.Show("Wrong password");
        }
    }
}
