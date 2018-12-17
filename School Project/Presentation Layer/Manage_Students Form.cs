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
        private static Manage_Students_Form frm;

        static void frm_FromCLosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Manage_Students_Form getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Manage_Students_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FromCLosed);
                }
                return frm;
            }
        }
        Business_Layer.CLS_Add_Student stud = new Business_Layer.CLS_Add_Student();
        public Manage_Students_Form()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
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

        private void Update_Click(object sender, EventArgs e)
        {
            Add_Student frm = new Add_Student();
            frm.txtID.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
            frm.txtFirst_Name.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            frm.txtLast_Name.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            frm.txtBirthDate.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
            frm.cmboxClass.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
            frm.cmboxAcademic_Year.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            frm.TxtPhone_Number.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            frm.cmboxSupervisor.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
            frm.TxtAddress.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
            frm.cmboxFees.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();

            frm.Text="Update Student Number: "+ this.metroGrid1.CurrentRow.Cells[0].Value.ToString();

            frm.Ok.Text = "Update";
            frm.state = "Update";
            frm.txtID.ReadOnly = true;
            frm.txtFirst_Name.TabIndex=0;
            frm.txtID.TabIndex = 100;
            frm.ShowDialog();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Reports.StudentReportCR myReport = new Reports.StudentReportCR();
            myReport.SetParameterValue("@ID", this.metroGrid1.CurrentRow.Cells[0].Value.ToString());
            Reports.Manage_Student_Report myForm = new Reports.Manage_Student_Report();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();
        }

        
    }
}
