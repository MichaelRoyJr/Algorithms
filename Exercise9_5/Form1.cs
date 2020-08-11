using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number1 = -1,
                   number2 = -1;

            if (Verify(ref number1, ref number2))
            {
                lblDisplay.ForeColor = Color.Yellow;
                lblDisplay.Text = (number1 + number2).ToString();
            }     
            else
            {
                lblDisplay.ForeColor = Color.Red;
                lblDisplay.Text = "Value must be numeric and > 0.";               
            }
                
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double number1 = -1,
                   number2 = -1;

            if (Verify(ref number1, ref number2))
            {
                lblDisplay.ForeColor = Color.Yellow;
                lblDisplay.Text = (number1 * number2).ToString();

            }
            else
            {
                lblDisplay.ForeColor = Color.Red;
                lblDisplay.Text = "Value must be numeric and > 0.";
            }
        }

       private bool Verify(ref double number1, ref double number2)
        {
            if (double.TryParse(txtNumber1.Text, out number1) == false)
                return false;
            else if (double.TryParse(txtNumber2.Text, out number2) == false)
                return false;
            else if (number1 <= 0 || number2 <= 0)
                return false;
            else
                return true;
        }
     }
}
