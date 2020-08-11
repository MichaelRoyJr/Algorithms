using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = txtBxName.Text + " you will need to borrow\nthe following items: \n\n";

            if (ckBxSkis.Checked)
            {
                message += "Skis \n";
            }
            if (ckBxPoles.Checked)
            {
                message += "Poles \n";
            }
            if (ckBxGloves.Checked)
            {
                message += "Gloves \n";
            }
            if (ckBxGoggles.Checked)
            {
                message += "Goggles \n";
            }
            if (ckBxJacket.Checked)
            {
                message += "Jacket \n";
            }

            MessageBox.Show(message, "Equipment Request");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ckBxGloves.Checked = false;
            ckBxGoggles.Checked = false;
            ckBxJacket.Checked = false;
            ckBxPoles.Checked = false;
            ckBxSkis.Checked = false;
            txtBxName.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
