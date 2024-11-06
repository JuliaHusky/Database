using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWithDB
{
    class DBConnection
    {
        //attributes
        //private object of the class itself
        private static DBConnection _instance;

        //the connection string
        private string dBConnectionString;

        //constructor
        private DBConnection()
        {
            //itialise the DBConnectionString
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods
        /**
         * static method that gives access to the private object
         */
        public static DBConnection getInstanceOfDBconnection()
        {
            if(_instance == null) 
                _instance = new DBConnection(); 
            return _instance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            //create the dataset object 
            DataSet dataset = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();

                //send SQL query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                adapter.Fill(dataset);
            }
                return dataset;
        }

        /**
        * Method to save the parameters age and name in the database
        */
        public void saveToDB(string sqlQuery, string name, int age)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                // open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // set the sqlCommand's properties

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));
                sqlCommand.Parameters.Add(new SqlParameter("Age", age));

                //execute the command
                sqlCommand.ExecuteNonQuery();

                connToDB.Close();
            
                
            }


        }

 
    }
}
