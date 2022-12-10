using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GLASS_WITH_DATABASE
{
    public partial class teacherSubject : Form
    {
        public teacherSubject()
        {
            InitializeComponent();
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            Form form = new calendar();
            form.ShowDialog();
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            Form form = new calendar();
            form.ShowDialog();
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            Form form = new calendar();
            form.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form form = new calendar();
            form.ShowDialog();
        }
    }
}
