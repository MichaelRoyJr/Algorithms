using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double miles,
                gallons;

            if (double.TryParse(txtMiles.Text, out miles) != false)
            {
                if (double.TryParse(txtGallons.Text, out gallons) != false)
                {
                    lblDisplay.Text = string.Format("{0:f1} mpg", miles/ gallons).ToString();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDestination.Text = "";
            txtMiles.Text = "";
            txtGallons.Text = "";
            lblDisplay.Text = "";

        }
    }
}
