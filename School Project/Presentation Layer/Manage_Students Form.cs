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
    public partial class Manage_Students_Form : MetroFramework.Forms.MetroForm
    {
        Business_Layer.CLS_Add_Student stud = new Business_Layer.CLS_Add_Student();
        public Manage_Students_Form()
        {
            InitializeComponent();
            this.metroGrid1.DataSource = stud.Get_All_Students();
        }

        private void Manage_Students_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
