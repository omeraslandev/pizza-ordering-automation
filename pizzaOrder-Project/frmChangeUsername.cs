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
    public partial class frmChangeUsername : Form
    {
        public frmChangeUsername()
        {
            InitializeComponent();
        }
        Cmds cmds = new Cmds();
        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            if(cmds.RepeatControl(txtNewUsername.Text) == true)
            {
                cmds.Update("Username", txtNewUsername.Text,User.Username);
                User.Username = txtNewUsername.Text;
                MessageBox.Show("Kullanıcı adı başarıyla değiştirildi.");
            }
            else
                MessageBox.Show("this username already exists.");
        }
    }
}
