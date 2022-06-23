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
    public partial class frmPlaceTheOrder : Form
    {
        public frmPlaceTheOrder()
        {
            InitializeComponent();
        }
        void Clear()
        {
            cmbPizzaSize.Text = "Pizza Size";
            cmbPizzaCrust.Text = "Pizza Crust";
            foreach (Control control in this.grpDrinks.Controls)
            {
                if (((CheckBox)control).Checked == true)
                    ((CheckBox)control).Checked = false;
            }
            foreach (Control control in this.grpToppings.Controls)
            {
                if (((CheckBox)control).Checked == true)
                    ((CheckBox)control).Checked = false;
            }
            nmrPizzaQuantity.Value = 1;
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        Cmds cmds = new Cmds();

        private void btnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            string Toppings = string.Empty;
            foreach (Control control in this.grpToppings.Controls)
            {
                if (((CheckBox)control).Checked == true)
                     Toppings += $"{(((CheckBox)control).Text)} ";
            }

            string Drinks = string.Empty;
            foreach (Control control in this.grpDrinks.Controls)
            {
                if (((CheckBox)control).Checked == true)
                    Drinks += $"{(((CheckBox)control).Text)} ";
            }

            if (cmbPizzaCrust.Text != "Pizza Crust" && cmbPizzaSize.Text != "Pizza Size" && nmrPizzaQuantity.Value != 0)
             {
                string OrderMessage = $"Siparişiniz: {cmbPizzaSize.Text} büyüklüğünde, {cmbPizzaCrust.Text} hamurunda, " +
                    $"{Toppings} soslu, {Drinks} içecekli, " +
                    $"{nmrPizzaQuantity.Value.ToString()} adet pizza. Onaylıyor musunuz?";
                if (Toppings == "")
                    OrderMessage = OrderMessage.Replace(" soslu, ", "");
                if (Drinks == "")
                    OrderMessage = OrderMessage.Replace(" içecekli, ", "");

                DialogResult OrderDialog = MessageBox.Show(OrderMessage, "Pizza Ordering System", MessageBoxButtons.YesNo);

                if (OrderDialog == DialogResult.Yes)
                {
                    cmds.con.Open();

                    string registermessage = "insert into Orders (Username,PizzaSize,PizzaCrust,PizzaToppings,PizzaDrinks,PizzaQuantity,OrderDate) values(@Username,@PizzaSize,@PizzaCrust,@PizzaToppings,@PizzaDrinks,@PizzaQuantity,@OrderDate)";

                    SqlCommand cmd = new SqlCommand(registermessage, cmds.con);

                    cmd.Parameters.AddWithValue("@Username", User.Username);
                    cmd.Parameters.AddWithValue("@PizzaSize", cmbPizzaSize.Text);
                    cmd.Parameters.AddWithValue("@PizzaCrust", cmbPizzaCrust.Text);
                    cmd.Parameters.AddWithValue("@PizzaToppings", Toppings);
                    cmd.Parameters.AddWithValue("@PizzaDrinks",Drinks);
                    cmd.Parameters.AddWithValue("@PizzaQuantity", nmrPizzaQuantity.Value.ToString());
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString());

                    cmd.ExecuteNonQuery();

                    cmds.con.Close();

                    MessageBox.Show("Sipariş başarıyla verildi.");

                    Clear();
                }
            }
            else
                MessageBox.Show("Pizzanızı eksiksiz girdiğinze emin olun.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
