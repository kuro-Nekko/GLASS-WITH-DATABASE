using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GLASS_WITH_DATABASE
{
    public partial class logInScreen : Form
    {
        public logInScreen()
        {
            InitializeComponent();
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            tbxUsername.Clear();
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
                tbxUsername.Text = "Enter Username or Student Code";
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxPassword.Clear();
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
                tbxPassword.Text = "Enter Password";
        }

        private void btnLogInLogInScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
