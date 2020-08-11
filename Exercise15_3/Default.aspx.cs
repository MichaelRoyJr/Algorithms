using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        if (txtName.Text == "")
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text += "Please enter your name!  ";
            if (txtItem.Text == "")
            {
                lblMessage.Text += "No task to add!";
            }
        }
        else if (txtItem.Text == "")
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text += "No task to add!";
        }
        else
        {
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = txtName.Text + " you have added " + txtItem.Text + " to your to do list.";
            lstTasks.Items.Add(txtItem.Text);
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        lblMessage.ForeColor = Color.Red;
        if (lstTasks.SelectedIndex == -1)
        {
            lblMessage.Text = "Select an item to remove!";
        }
        else
        {
            if (txtName.Text != "")
            {
                lblMessage.Text += txtName.Text + " ";
            }
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text += "you are removing " + lstTasks.SelectedValue + " from your to do list.";
            lstTasks.Items.Remove(lstTasks.SelectedValue);
        }
    }
}