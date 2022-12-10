using static System.Globalization.Calendar;
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
using System.Data.Odbc;
using System.IO;

namespace GLASS_WITH_DATABASE
{
    public partial class teacherHome : Form
    {
        OdbcDataAdapter da;
        public OdbcConnection connection = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;");
        public teacherHome()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void teacherHome_Load(object sender, EventArgs e)
        {

            string user = logInScreen.teacherID;
            connection.Open();
            OdbcCommand cmd = new OdbcCommand("SELECT * FROM teacher_information WHERE teacher_ID = '" + user + "'", connection);
            da = new OdbcDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            byte[] img = (byte[])dt.Rows[0][8];

            MemoryStream ms = new MemoryStream();

            //subPnlInfo.Image = Image.FromStream(ms);
            da.Dispose();
            connection.Close();
        }
        private void customizeDesign()
        {
            subPnlBtnClass.Visible = false;
            subPnlBtnAccount.Visible = false;

        }

        private void hideSubMenu()
        {
            if (subPnlBtnClass.Visible == true)
                subPnlBtnClass.Visible = false;
            if (subPnlBtnAccount.Visible == true)
                subPnlBtnAccount.Visible = false;
        }

        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMainChildForm.Controls.Add(childForm);
            pnlMainChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            showSubMenu(subPnlBtnClass);
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            showSubMenu(subPnlBtnAccount);
        }

        private void btnEditUsername_Click_1(object sender, EventArgs e)
        {
            openChildForm(new editAccountCF());
            hideSubMenu();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form form = new logInScreen();
            this.Hide();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1Y_Click(object sender, EventArgs e)
        {
            openChildForm(new teacherSubject());
            hideSubMenu();

        }

        private void btn1Y_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMainChildForm.Controls.Clear();
        }
    }
}
