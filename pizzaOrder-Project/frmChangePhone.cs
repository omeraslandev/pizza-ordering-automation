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
    public partial class frmChangePhone : Form
    {
        public frmChangePhone()
        {
            InitializeComponent();
        }
        Cmds cmds = new Cmds();
        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            cmds.Update("Phone", msktxtNewPhone.Text,User.Phone);
            User.Phone = msktxtNewPhone.Text;
            MessageBox.Show("Telefon numarası başarıyla değiştirildi.");
        }
    }
}
