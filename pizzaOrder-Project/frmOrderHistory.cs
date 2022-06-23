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
    public partial class frmOrderHistory : Form
    {
        public frmOrderHistory()
        {
            InitializeComponent();
        }
        Cmds cmds = new Cmds();
        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cmds.OrderHistory();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
    }
}
