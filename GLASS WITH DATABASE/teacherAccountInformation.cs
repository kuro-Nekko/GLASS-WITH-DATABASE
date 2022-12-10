using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLASS_WITH_DATABASE
{
    public partial class editAccountCF : Form
    {

        public OdbcConnection connection = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;");
        public string teacher = logInScreen.teacherID;
        public string userName = logInScreen.userName;
        public string userPassword = logInScreen.userPassword;



        public editAccountCF()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void editAccountCF_Load(object sender, EventArgs e) 
        {
            
            connection.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM teacher_information WHERE teacher_ID = '" + teacher + "'", connection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblteach.Text = reader["teacher_ID"].ToString();
                tbxUsername.Text = userName;
                tbxPassword.Text = userPassword;
                tbxFirstname.Text = reader["firstName"].ToString();
                tbxLastname.Text = reader["lastName"].ToString();
                tbxAddress.Text = reader["address"].ToString();
                tbxContactNumber.Text = reader["contactNumber"].ToString();

            }
            connection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                OdbcCommand cmd = new OdbcCommand("UPDATE teacher_information SET firstName = '" + tbxFirstname.Text + "', lastName = '" + tbxLastname.Text + "', address = '" + tbxAddress.Text + "', contactNumber = '" + tbxContactNumber.Text + "' WHERE teacher_ID = '" + teacher + "'", connection);
                cmd.ExecuteNonQuery();
                cmd = new OdbcCommand("UPDATE username_password SET userName = '" + tbxUsername.Text + "', userPassword = '" + tbxPassword.Text + "' WHERE teacher_ID = '" + teacher + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username Already Existed!");
            }
            finally
            {
                connection.Close();
            }
           
        }
    }
}
