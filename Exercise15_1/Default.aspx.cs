using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblMessage.Text = txtBxName.Text + " your exam is on XX. ";
        if (txtBxEmail.Text.Length != 0)
        {
            lblMessage.Text += "An email will be sent to: " + txtBxEmail.Text;
        }
            
    }
}