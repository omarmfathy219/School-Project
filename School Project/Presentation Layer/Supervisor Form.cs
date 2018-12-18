using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace School_Project.Presentation_Layer
{
    public partial class Supervisor_Form : MetroFramework.Forms.MetroForm
    {
        //Server Name; Database Name; Server Security //

        SqlConnection sqlcon = new SqlConnection(@"Server =.\; Database=School_DB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;

        public Supervisor_Form()
        {
            Business_Layer.CLS_Add_Student sup = new Business_Layer.CLS_Add_Student();

            InitializeComponent();

            da = new SqlDataAdapter("SELECT ID AS 'ID',FIRST_NAME AS 'First Name',LAST_NAME AS 'Last Name',PHONE_NUMBER AS 'Phone Number',MAIL AS 'Mail',CITY AS 'City',SALARY AS 'Salary',HIRE_DATE AS 'Hire Date',ClASS AS 'Class Name' from SUPERVISOR", sqlcon);

            da.Fill(dt);

            metroGrid1.DataSource = dt;

            txtboxID.DataBindings.Add("text", dt, "ID");
            txtboxFirstName.DataBindings.Add("text", dt, "First Name");
            txtboxLastName.DataBindings.Add("text", dt, "Last Name");
            txtboxPhoneNumber.DataBindings.Add("text", dt, "Phone Number");
            txtboxEmail.DataBindings.Add("text", dt, "Mail");
            txtboxCity.DataBindings.Add("text", dt, "City");
            txtboxSalary.DataBindings.Add("text", dt, "Salary");
            txtboxHireDate.DataBindings.Add("text", dt, "Hire Date");
            txtboxClass.DataBindings.Add("text", dt, "Class Name");

            bmb = this.BindingContext[dt];
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;


            txtboxClass.DataSource = sup.Get_All_Class();
            txtboxClass.DisplayMember = "Get_All_Class";
            txtboxClass.ValueMember = "CLASS_NAME";
        }

        private void Supervisor_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Data Added Successfully", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void txtboxID_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lebPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            txtboxID.ReadOnly = false;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtboxID.Text = id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Updated Successfully", "Update Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Record", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(da);
                lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
                MessageBox.Show("Deleted Successfully", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                da.Update(dt);
            }
            else
            {
                MessageBox.Show("Deleted Canceled", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
