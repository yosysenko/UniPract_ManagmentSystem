using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPract_ManagmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm stdListF = new studentsListForm();
            stdListF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm stcF = new StaticsForm();
            stcF.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm upDelStF = new UpdateDeleteStudentForm();
            upDelStF.Show(this);
        }

        private void manageStudentsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mngStdF = new ManageStudentsForm();
            mngStdF.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm prStF = new PrintStudentsForm();
            prStF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCrsF = new AddCourseForm();
            addCrsF.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm rmvCrsF = new RemoveCourseForm();
            rmvCrsF.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCrsF = new EditCourseForm();
            editCrsF.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm mngCrsF = new ManageCoursesForm();
            mngCrsF.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCoursesForm prCrsF = new PrintCoursesForm();
            prCrsF.Show(this);
        }
    }
}
