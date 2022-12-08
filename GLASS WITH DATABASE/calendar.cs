using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLASS_WITH_DATABASE
{
    public partial class calendar : Form
    {
        public static int static_month, static_year;
        public static DateTime now = DateTime.Now;
        public static int month = now.Month;
        public static int year = now.Year;
        public calendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            static_month = month;
            static_year = year;
            if (month == 1)
            {
                daycontainer.Controls.Clear();
                year--;
                month = 12;
                displayDays();
            }
            else
            {
                daycontainer.Controls.Clear();
                month--;
                displayDays();
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            static_month = month;
            static_year = year;
            if (month == 12)
            {
                daycontainer.Controls.Clear();
                year++;
                month = 1;
                displayDays();
            }
            else
            {
                daycontainer.Controls.Clear();
                month++;
                displayDays();
            }
        }

        private void displayDays()
        {
            //DateTime now  = DateTime.Now;
            //month = now.Month;
            //year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblUpdate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;  

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
