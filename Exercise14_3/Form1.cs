using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise14_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void familyInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familyInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myFamilyDbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myFamilyDbDataSet.FamilyInfo' table. You can move, or remove it, as needed.
            this.familyInfoTableAdapter.Fill(this.myFamilyDbDataSet.FamilyInfo);

        }
    }
}
