using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GLASS_WITH_DATABASE
{
    public partial class logInScreen : Form
    {
        public OdbcConnection connection = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;");
        public static string userid = "";
        public static string password = "";
        public logInScreen()
        {
            InitializeComponent();
        }

        private void btnLogInLogInScreen_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM teacher_information WHERE userName = '" + tbxUsername.Text + "' AND userPassword = '" + tbxPassword.Text + "'", connection);
            OdbcDataReader reader = cmd.ExecuteReader();
     
            if (reader.Read())
            {
                cmd = new OdbcCommand("SELECT * FROM teacher_information WHERE User_ID = '" + reader["User_ID"].ToString() + "' AND userPassword = '" + reader["userPassword"].ToString() + "'", connection);
                userid = reader["User_ID"].ToString();
                password = reader["userPassword"].ToString();
                Form form = new teacherHome();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Username And Password Not Match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbxUsername.Text = string.Empty;
            tbxPassword.Text = string.Empty;

            reader.Close();
            cmd.Dispose();
            connection.Close();
        }
    }
}
