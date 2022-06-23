using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pizzaOrder_Project
{
    public partial class frmLogin : Form
    {
        SqlDataReader dr;
        SqlCommand cmd;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            Cmds cmds = new Cmds();
            cmd = new SqlCommand();

            cmds.con.Open();
            cmd.Connection = cmds.con;
            cmd.CommandText = "select * from Userss where Username='"+txtUsername.Text+
                "' and Password='"+txtPassword.Text+"'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                cmds.con.Close();
                cmds.con.Open();
                cmds.loginTheSystem(txtUsername.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user.");
            }
            cmds.con.Close();
        }
    }
}
