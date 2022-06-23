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
    public partial class frmChangeAdress : Form
    {
        public frmChangeAdress()
        {
            InitializeComponent();
        }
        Cmds cmds = new Cmds();
        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            cmds.Update("Adress", txtNewAdress.Text,User.Adress);
            User.Adress = txtNewAdress.Text;
            MessageBox.Show("Adres başarıyla değiştirildi.");
        }
    }
}
