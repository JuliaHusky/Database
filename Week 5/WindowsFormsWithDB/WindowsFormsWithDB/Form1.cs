using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btLoadData_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class
            DBConnection dbConn = DBConnection.getInstanceOfDBconnection();
            DataSet datasetPerson = dbConn.getDataSet("SELECT * FROM Person");

            dgvPerson.DataSource = datasetPerson.Tables[0];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int age = Convert.ToInt32(tbAge.Text);

            DBConnection dbConn = DBConnection.getInstanceOfDBconnection();

            dbConn.saveToDB("INSERT INTO Person (Name, Age) VALUES (@Name, @Age)", name, age);

            LoadDataGridView();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadDataGridView()
        {
            // display the data from the tablet Person into the DataGridView
            // get the dataset from the DB and assign it to the dataGridView's DataSource
            //dgvPerson.DataSource = ds.Tables[0];
        }

    

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
