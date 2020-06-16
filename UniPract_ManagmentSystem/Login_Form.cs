using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UniPract_ManagmentSystem
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }


        private void Login_Form_Load(object sender, EventArgs e)
        {
            //set picture into the pictureBox
            pictureBox1.Image = Image.FromFile("../../images/user.png");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //MY_DB db = new MY_DB();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //DataTable table = new DataTable();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn AND `password`= @pass", db.getConnection);

            //command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = textBoxUsername.Text;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            //adapter.SelectCommand = command;

            //adapter.Fill(table);

            //if(table.Rows.Count > 0)
            //{
            //    // if this user exist
            //    // we will set the dialogResult to OK
            //    //that mean the login informations are correct -> open the mainform
            //    this.DialogResult = DialogResult.OK;


            //}
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text=="admin")
            {
                // if this user exist
                // we will set the dialogResult to OK
                //that mean the login informations are correct -> open the mainform
                this.DialogResult = DialogResult.OK;


            }
            else
            {
                MessageBox.Show("Invalid Username Or Password","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
