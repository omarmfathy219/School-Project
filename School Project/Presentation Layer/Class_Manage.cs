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
        public Class_Manage()
        {
            InitializeComponent();

            da = new SqlDataAdapter("SELECT CLASS_ID AS 'ID',CLASS_NAME AS 'Class Name',CLASS_SUPERVISOR AS 'Class Supervisor' from CLASS", sqlcon);
            da.Fill(dt);
            metroGrid1.DataSource = dt;

            txtboxID.DataBindings.Add("text", dt, "ID");
            txtboxClassName.DataBindings.Add("text", dt, "Class Name");
            txtboxClassSupervisor.DataBindings.Add("text", dt, "Class Supervisor");
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
    }
}
