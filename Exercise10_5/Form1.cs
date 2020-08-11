using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise10_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //   version from Exercise 10.6
            if (lstBxBagType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No bag selected", "Error");
            }
            else if (cmbBxQuantity.Text == "")
            {
                MessageBox.Show("No quantity", "Error");
            }
            else
            {
                decimal total = 0.00m;
                string message = "You have selected\n\n";
                decimal shippingMultiplier;

                if (radOvernight.Checked)
                    shippingMultiplier = 0.1m;
                else if (radThreeDay.Checked)
                    shippingMultiplier = 0.07m;
                else
                    shippingMultiplier = 0.05m;


                foreach (string s in lstBxBagType.SelectedItems)
                {
                    decimal price = decimal.Parse(s.Substring(s.Length - 5, 5));
                    int quantity = int.Parse(cmbBxQuantity.Text);
                    total += quantity * price;
                    string bag = s.Substring(0, s.Length - 8);

                    message += cmbBxQuantity.Text.PadRight(5, ' ') + bag.PadLeft(17, ' ')
                        + price.ToString().Insert(0, "$").PadLeft(12, ' ') + "\n";
                }

                message += "-------------------------------\n";
                message += "Subtotal: " + string.Format("{0,24:c}", total) + "\n";
                message += "Shipping: " + string.Format("{0,24:c}", total * shippingMultiplier) + "\n";
                message += "\nTotal: " + String.Format("{0, 27:c}", total + total * shippingMultiplier);
                MessageBox.Show(message, "Bag Order Confirmation");
            }




     /**      version from Exercise 10.5
      * 
      * if (lstBxBagType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No bag selected", "Error");
            }
            else if (cmbBxQuantity.Text == "")
            {
                MessageBox.Show("No quantity", "Error");
            }
            else
            {
                string message = "You have selected\n\n";

                foreach (string s in lstBxBagType.SelectedItems)
                {
                    message += "\t" + cmbBxQuantity.Text + "\t" + s + "\n";
                }
                MessageBox.Show(message, "Bag Order Confirmation");
            }
    **/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBxBagType.ClearSelected();
            cmbBxQuantity.SelectedIndex = -1;
            cmbBxQuantity.Text = "";
        }

    }
}
