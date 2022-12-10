using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GLASS_WITH_DATABASE
{
    public partial class addRecordTeach : Form
    {
        public string userIDCreation;
        public string userNameAdd;
        public string userPassAdd;
        string userLevel;
        string userIDCreationString;
        string countdata;
        OdbcConnection connection = new OdbcConnection();
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader dr, dr1;
        OdbcDataAdapter da;
        
        public addRecordTeach()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addRecordTeach_Load(object sender, EventArgs e)
        {
            connection.Close();
            connection.ConnectionString = "DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;";
            connection.Open();
            cmd = new OdbcCommand("SELECT COUNT( * ) AS countdata FROM teacher_information;", connection);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                countdata = dr["countdata"].ToString();
                userIDCreation = countdata;
                userIDCreationString = "00"+userIDCreation.ToString();
                dr.Close();
                cmd.Dispose();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(opf.FileName);
                
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            userNameAdd = "teacher" + userIDCreationString;
            userPassAdd = "password";
            userLevel = "Teacher";
            string studentIDadd = "";
            
            string Date = bdayPicker.Value.ToString("yyyy-MM-dd");
            cmd = new OdbcCommand("INSERT INTO teacher_information(teacher_ID,firstName,lastName,address,contactNumber,birthday,religion,sex,userPicture) values('" + userIDCreation + "', '" + tbxFName.Text + "', '" + tbxLName.Text + "', '" + tbxAddress.Text + "', '" + tbxContactNumber.Text + "', '" + Date + "', '" + tbxReligion.Text + "', '" + cbxSex.Text + "', ?)", connection);
            //cmd = new OdbcCommand("INSERT INTO teacher_information(userPicture) values(?)", connection);
            OdbcParameter param = new OdbcParameter("@img", OdbcType.Binary, img.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, img);
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            cmd = new OdbcCommand("INSERT INTO username_password(all_user_ID,userName,userPassword,teacher_ID,student_ID,user_level ) values('" + userIDCreationString + "', '" + userNameAdd + "', '" + userPassAdd+ "', '" + userIDCreation + "', '" + studentIDadd + "', '" + userLevel + "')", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record save");
            MessageBox.Show("Username: " + userNameAdd + " Password: " + userPassAdd);
            connection.Close();
            cmd.Dispose();
            this.Hide();
        }
    }
}

