using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniPract_ManagmentSystem
{
    /*
     in this class we will create the connection btw our app and the mysql db
     we need to add a mysql connector to the project
     we need to create the database
         */

    class MY_DB
    {
        //the connection
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_student_db");

        //create a function to get the connection
        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //create a function to open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        //create a function to close the connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
