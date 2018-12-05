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

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            Add_Student frm = new Add_Student();
            frm.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            {
                Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();

                if (MessageBox.Show("Do you Want To Delete This Record", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    stud.DeleteStudent(Convert.ToInt32(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Record Deleted Successfully", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.metroGrid1.DataSource = stud.Get_All_Students();
                }
                else
                {
                    MessageBox.Show("Record Deleted Cancelled", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
