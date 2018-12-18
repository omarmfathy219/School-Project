using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace School_Project.Presentation_Layer
{
    public partial class About_Form : MetroFramework.Forms.MetroForm
    {
        public About_Form()
        {
            InitializeComponent();
        }

        private void About_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {

        }

        private void metroLink4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/OmarMFathy25");
        }

        private void linkTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com/OmarMFathy25");
        }

        private void linkLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/OmarMFathy25");

        }

        private void linkGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/OmarMFathy25");

        }
    }
}
