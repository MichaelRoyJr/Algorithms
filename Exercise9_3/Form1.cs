using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int x,
                y;
            if ((int.TryParse(txtNewX.Text, out x) != false) && (int.TryParse(txtNewY.Text, out y) != false))
            {
                if (x > 0 && y > 0)
                    Location = new Point(x, y);
                else
                    MessageBox.Show("Invalid input: negative value.");
            }
            else
                MessageBox.Show("Invalid input: not an integer.");


           



        }
    }
}
