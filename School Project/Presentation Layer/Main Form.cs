using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project.Presentation_Layer
{
    public partial class Main_Form : MetroFramework.Forms.MetroForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Add_Student frm = new Add_Student();
            frm.ShowDialog();
        }
    }
}
