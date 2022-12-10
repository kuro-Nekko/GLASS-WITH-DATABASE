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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        public static Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void regToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new addRecordStud());
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new addRecordTeach());
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new logInScreen();
            this.Close();
            form.ShowDialog();
        }
    }
}
