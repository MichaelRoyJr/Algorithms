using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Name: " + txtBxName.Text + "\n";
            message += "Email: " + txtBxEmail.Text + "\n";
            message += "Phone: " + txtBxPhone.Text;
            MessageBox.Show(message, "Personal Information");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBxName.Text = "";
            txtBxEmail.Text = "";
            txtBxPhone.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personal Infromation App \nCreated by: Michael Roy Jr \nversion 1.0", "About");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
