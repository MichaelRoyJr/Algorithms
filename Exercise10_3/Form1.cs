using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radBaseball_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Batter Up!";
            picBxBaseball.Visible = true;
            picBxFootball.Visible = false;
            picBxBasketball.Visible = false;
            picBxSoccer.Visible = false;
            picBxHockey.Visible = false;
        }

        private void radFootball_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Touchdown!!";
            picBxBaseball.Visible =false;
            picBxFootball.Visible = true;
            picBxBasketball.Visible = false;
            picBxSoccer.Visible = false;
            picBxHockey.Visible = false;
        }

        private void radBasketball_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "Bring Your Sneakers!";
            picBxBaseball.Visible = false;
            picBxFootball.Visible = false;
            picBxBasketball.Visible = true;
            picBxSoccer.Visible = false;
            picBxHockey.Visible = false;
        }

        private void radSoccer_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "Rain or Shine!";
            picBxBaseball.Visible = false;
            picBxFootball.Visible = false;
            picBxBasketball.Visible = false;
            picBxSoccer.Visible = true;
            picBxHockey.Visible = false;
        }

        private void radHockey_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "Don't Freeze!!";
            picBxBaseball.Visible = false;
            picBxFootball.Visible = false;
            picBxBasketball.Visible = false;
            picBxSoccer.Visible = false;
            picBxHockey.Visible = true;
        }
    }
}
