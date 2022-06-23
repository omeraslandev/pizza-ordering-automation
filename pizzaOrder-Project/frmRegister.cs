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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        Cmds cmds = new Cmds();
        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text != "" && txtPassword.Text != "" && txtPasswordAgain.Text != "" && txtAdress.Text != "" && msktxtPhone.Text != "")
                {
                    if (cmds.RepeatControl(txtUsername.Text) == true)
                    {
                        cmds.con.Open();

                        string registermessage = "insert into Userss (Username,Password,Adress,Phone,Date) values(@Username,@Password,@Adress,@Phone,@Date)";

                        SqlCommand cmd = new SqlCommand(registermessage, cmds.con);

                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Adress", txtAdress.Text);
                        cmd.Parameters.AddWithValue("@Phone", msktxtPhone.Text);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());

                        if (txtPassword.Text == txtPasswordAgain.Text)
                        {
                            cmd.ExecuteNonQuery();

                            cmds.loginTheSystem(txtUsername.Text);//login the system.

                            MessageBox.Show("Başarıyla kayıt olundu.");

                            cmds.con.Close();

                            this.Close();
                        }
                        else
                            MessageBox.Show("the passwords are not the same!");
                    }
                    else
                        MessageBox.Show("this username already exists.");
                }
                else
                    MessageBox.Show("Kaydınızı eksiksiz girdiğinizden emin olun..");
            }
            catch(Exception error)
            {
                MessageBox.Show("Database Error! : " + error.Message);
            }
        }
    }
}
