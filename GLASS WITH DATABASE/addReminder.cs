using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GLASS_WITH_DATABASE
{
    public partial class addReminder : Form
    {
        public static string date_save;
        public OdbcConnection connection = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;");
        public addReminder()
        {
            InitializeComponent();
        }

        private void addReminder_Load(object sender, EventArgs e)
        {
            date_save = calendar.static_year + "/" + UserControlDays.static_day + "/"+ calendar.static_month;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            String sql = "INSERT INTO subject_reminders(reminder_date,reminder_type,reminder_description)values(?,?,?)";
            OdbcCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("reminder_date", date_save);
            cmd.Parameters.AddWithValue("reminder_type", cbxReminderType.Text);
            cmd.Parameters.AddWithValue("reminder_description", tbxDescription.Text);
            cmd.ExecuteNonQuery();
            //this.Hide();
            MessageBox.Show("Reminder Added!");
            this.Hide();
            cmd.Dispose();
            connection.Close(); 
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Form form = new uploadFile();
            form.Show();
            this.Hide();
        }
    }
}
