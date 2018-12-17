using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace School_Project.Presentation_Layer
{
    public partial class Class_Manage : MetroFramework.Forms.MetroForm
    {
        //Server Name; Database Name; Server Security //

        SqlConnection sqlcon = new SqlConnection(@"Server =.\; Database=School_DB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public Class_Manage()
        {
            InitializeComponent();

            da = new SqlDataAdapter("SELECT CLASS_ID AS 'ID',CLASS_NAME AS 'Class Name',CLASS_SUPERVISOR AS 'Class Supervisor' from CLASS", sqlcon);
            da.Fill(dt);

            metroGrid1.DataSource = dt;

            txtboxID.DataBindings.Add("text", dt, "ID");
            txtboxClassName.DataBindings.Add("text", dt, "Class Name");
            txtboxClassSupervisor.DataBindings.Add("text", dt, "Class Supervisor");

            bmb = this.BindingContext[dt];
            lebPosition.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void Class_Manage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxClass_Click(object sender, EventArgs e)
        {

        }

        private void txtboxID_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            txtboxID.ReadOnly = false;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0])+1;
            txtboxID.Text = id.ToString();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Deleted Successfully", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Updated Successfully", "Update Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lebPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }
    }
}
