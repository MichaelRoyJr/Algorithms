using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Congratulations, " + txtName.Text + ", you retrieved the data!";
            int newX = Form1. / 2 - lblMessage.Width / 2;
            lblMessage.Location = new Point(newX, 269);
            
            txtName.Clear();
        }

        
    }
}
