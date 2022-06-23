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
    public partial class frmCustomerStats : Form
    {
        public frmCustomerStats()
        {
            InitializeComponent();
        }
        Cmds cmds = new Cmds();
        private void frmCustomerStats_Load(object sender, EventArgs e)
        {
            string Hi = lblHi.Text.Replace("<Username>", User.Username);

            string Stats = lblStats.Text.Replace("<DateTime>", User.AccountDate);
            Stats = Stats.Replace("<Number>", User.ID.ToString());
            Stats = Stats.Replace("<OrderNumber>", cmds.OrderNumber().ToString());
            Stats = Stats.Replace("<Adress>", User.Adress);
            Stats = Stats.Replace("<Phone>", User.Phone);

            lblHi.Text = Hi;
            lblStats.Text = Stats;
        }
    }
}
