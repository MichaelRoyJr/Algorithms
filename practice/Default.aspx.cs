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
        if (!Page.IsPostBack)
        {
            Calendar1.SelectedDate = DateTime.Today;
            lblMessage.Text = "";
        }
        else
        {
            if (Calendar1.SelectedDate < DateTime.Today)
            {
                lblMessage.Text = "You have selected a date that has passed!  Select again.";
            }
            else
            {
                lblMessage.Text = "Your next exam is on " + Calendar1.SelectedDate.DayOfWeek + ", " + Calendar1.SelectedDate.Month + "/" + Calendar1.SelectedDate.Day + "/" + Calendar1.SelectedDate.Year + ".";
            }
        }
    }
}