using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            //adjust backgorund color

            Color tempBackColor = BackColor;
            Color tempForeColor = lblPrompt.ForeColor;
            BackColor = btnColor1.BackColor;
            lblPrompt.ForeColor = btnColor1.ForeColor;
            
            // adjust button

            btnColor1.BackColor = tempBackColor;
            btnColor1.ForeColor = tempForeColor;
            btnColor1.Text = tempBackColor.Name.ToUpper();

            //display message about color change

            string message = "The window is now " + BackColor.Name + ".";
            MessageBox.Show(message, "Color Change");
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            //adjust backgorund color

            Color tempBackColor = BackColor;
            Color tempForeColor = lblPrompt.ForeColor;
            BackColor = btnColor2.BackColor;
            lblPrompt.ForeColor = btnColor2.ForeColor;

            //adjust button

            btnColor2.BackColor = tempBackColor;
            btnColor2.ForeColor = tempForeColor;
            btnColor2.Text = tempBackColor.Name.ToUpper();

            //display message about color change

            string message = "The window is now " + BackColor.Name + ".";
            MessageBox.Show(message, "Color Change");
        }
    }
}
