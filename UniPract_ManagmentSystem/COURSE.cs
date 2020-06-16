using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniPract_ManagmentSystem
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();

        //create a function to insert course
        public bool insertCourse(string courseName, int hoursNumber, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`label`, `hours_number`, `description`) VALUES (@name, @hrs, @dscr)", mydb.getConnection);

            //@name, @hrs, @dscr
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber;
            command.Parameters.Add("@dscr", MySqlDbType.Text).Value = description;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }


        }
        //create a function to check if the course name already exists in the database
        //when we edit a course we need to exclude the current course from the name verfication
        //using the course id
        //by default we will set the course id to 0
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE `label` = @cName AND id <> @cid", mydb.getConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = courseName;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                //return false if this course name already exists
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        //function to remove course by id
        public bool deleteCourse(int courseId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `id`=@CID", mydb.getConnection);

            command.Parameters.Add("@CID", MySqlDbType.Int32).Value = courseId;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        //create a function to get all courses
        public DataTable getAllCourses()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`", mydb.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        //create a function to get a course by id
        public DataTable getCourseById(int courseID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE id = @cid", mydb.getConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        //create a function to edit the selected course
        public bool updateCourse(int courseId, string courseName, int hoursNumber, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `label`=[value-2],`hours_number`=[value-3],`description`=[value-4] WHERE `id`=@cid", mydb.getConnection);

            //@name, @hrs, @dscr
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber;
            command.Parameters.Add("@dscr", MySqlDbType.Text).Value = description;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }



        //create a function to execute the count queries
        public string execCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, mydb.getConnection);

            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();

            return count;
        }

        //get the total courses
        public string totalCourses()
        {
            return execCount("SELECT COUNT(*) FROM `course`");
        }
    }
}
