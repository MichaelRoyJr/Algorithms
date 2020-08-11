using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxValues.Items.Clear();
                lstBxProduct.Items.Clear();

                if (txtBxVal1.Text == "" || txtBxVal2.Text == "")
                {
                    NoValueEnteredException exc = new NoValueEnteredException("Value not entered exception");
                    throw exc;
                }
                int value1 = int.Parse(txtBxVal1.Text);
                int value2 = int.Parse(txtBxVal2.Text);
                lstBxValues.Items.Add(value1.ToString());
                lstBxValues.Items.Add(value2.ToString());

                lstBxProduct.Items.Add((value1 * value2).ToString());


            }

            catch (NoValueEnteredException exc)
            {
                MessageBox.Show(exc.Message, "No Value Entered");
            }

            

            catch (System.FormatException exc)
            {
                MessageBox.Show(exc.Message, "Format Error");               
            }
        }
    }
}
