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
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 700)
            {
                timer1.Stop();
                this.Hide();
                Form form = new logInScreen();
                form.ShowDialog();

            }

        }
    }
}
