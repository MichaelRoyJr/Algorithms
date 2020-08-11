using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercise14_1
{
    public partial class Form1 : Form
    {
        private SqlConnection dbConn;
        private SqlCommand dbCommand;
        private SqlDataReader dbReader;
        private DataSet familyData;
        private SqlDataAdapter familyDataAdap;
        private SqlCommandBuilder cBuild;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8E9VTD8\\SQLEXPRESS;Initial Catalog=MyFamilyDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                dbConn = new SqlConnection(connectionString);
                //dbConn.Open();

                dbCommand = new SqlCommand();
                dbCommand.CommandText = "SELECT * FROM FamilyInfo;";
                dbCommand.Connection = dbConn;

                DataSet familyData = new DataSet();
                SqlDataAdapter familyDataAdap = new SqlDataAdapter();
                SqlCommandBuilder cBuild = new SqlCommandBuilder(familyDataAdap);
                familyDataAdap.SelectCommand = dbCommand;
                familyDataAdap.Fill(familyData, "FamilyInfo");

                dataGridView1.DataSource = familyData;
                dataGridView1.DataMember = "FamilyInfo";

            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
