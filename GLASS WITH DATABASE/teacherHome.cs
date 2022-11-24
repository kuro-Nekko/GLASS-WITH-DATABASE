using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLASS_WITH_DATABASE
{
    public partial class teacherHome : Form
    {
        public teacherHome()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void teacherHome_Load(object sender, EventArgs e)
        {
            
        }
        private void customizeDesign()
        {
            subPnlBtnClass.Visible = false;
            
        }

        private void hideSubMenu()
        {
            if (subPnlBtnClass.Visible == true)
                subPnlBtnClass.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new teacherClass());
            hideSubMenu();
        }

        private void btnClass_Click_1(object sender, EventArgs e)
        {
            showSubMenu(subPnlBtnClass);
        }
    }
}
