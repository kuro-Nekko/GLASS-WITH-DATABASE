using static System.Globalization.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GLASS_WITH_DATABASE
{
    public partial class calendarEvent : Form
    {
        public static string date_save;   
        public OdbcConnection connection = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader dr;
        
   
        public calendarEvent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void calendarEvent_Load(object sender, EventArgs e)
        {
            
            connection.Close();
            connection.Open();
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(calendar.month);
            lblUpdate.Text = monthname + " " + UserControlDays.static_day + ", " + calendar.year;
            date_save = calendar.static_year + "/" + UserControlDays.static_day + "/" + calendar.static_month;
            cmd = new OdbcCommand("SELECT `reminder_type`,`reminder_date`,`reminder_description` FROM subject_reminders WHERE `reminder_date` = '" + date_save + "'", connection);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            remindersDataGridView.DataSource = dt;
            connection.Close();



        }


        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            Form form = new addReminder();
            form.ShowDialog();
        }
    }
}
