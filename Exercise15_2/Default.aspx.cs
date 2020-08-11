using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        int total = 0;
        lblConfirm.Text = "";
        lblConfirm.ForeColor = Color.Red;

        if (rdoSmall.Checked)
        {
            if (txtBxSmall.Text == "")
            {
                lblConfirm.Text += "Enter Quantity - Small \n";
            }
            else
            {
                total += int.Parse(txtBxSmall.Text) * 26;
            }
        }
        if (rdoMedium.Checked)
        {
            if (txtBxMedium.Text == "")
            {
                lblConfirm.Text += "Enter Quantity - Medium \n";
            }
            else
            {
                total += int.Parse(txtBxMedium.Text) * 26;
            }
        }
        if (rdoLarge.Checked)
        {
            if (txtBxLarge.Text == "")
            {
                lblConfirm.Text += "Enter Quantity - Large \n";
            }
            else
            {
                total += int.Parse(txtBxLarge.Text) * 26;
            }
        }
        if (rdoXLarge.Checked)
        {
            if (txtBxXLarge.Text == "")
            {
                lblConfirm.Text += "Enter Quantity - XLarge \n";
            }
            else
            {
                total += int.Parse(txtBxXLarge.Text) * 30;
            }
        }
        if (lblConfirm.Text == "")
        {
            lblConfirm.Text += "Thank you for your order " + txtBxFName.Text + " " + txtBxLName.Text + "!\n";
            lblConfirm.Text += "Subtotal:  " + total.ToString("C") + "\n";
            lblConfirm.Text += "Tax (7%):  " + (total * 0.07).ToString("C") + "\n";
            lblConfirm.Text += "Total Due: " + (total * 1.07).ToString("C") + "\n";
            lblConfirm.ForeColor = Color.Chocolate;
        }
    }
}
