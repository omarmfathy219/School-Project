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
    public partial class Users_Manage_Form : MetroFramework.Forms.MetroForm
    {
        //Server Name; Database Name; Server Security //

        SqlConnection sqlcon = new SqlConnection(@"Server =.\; Database=School_DB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
    
        public Users_Manage_Form()
        {
            Business_Layer.CLS_LOGIN login = new Business_Layer.CLS_LOGIN();
            InitializeComponent();

            da = new SqlDataAdapter("SELECT USERNAME AS 'Username',PASSWORD AS 'Password' from Users", sqlcon);
            da.Fill(dt);

            metroGrid1.DataSource = dt;
            bmb = this.BindingContext[dt];
        }
    
        private void Users_Manage_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_User_Form frm = new Add_User_Form();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this user", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)== DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(da);
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
