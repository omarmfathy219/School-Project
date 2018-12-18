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
    public partial class Add_User_Form : MetroFramework.Forms.MetroForm
    {
        public Add_User_Form()
        {
            InitializeComponent();
        }

        private void Add_User_Form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtboxPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == string.Empty || txtboxPassword.Text == string.Empty || txtboxConfirmPass.Text == string.Empty)
            {
                MessageBox.Show("Please Check Your Data", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtboxPassword.Text != txtboxConfirmPass.Text)
            {
                MessageBox.Show("Password Not Match", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.CLS_LOGIN user = new Business_Layer.CLS_LOGIN();

                user.addNewUser(txtboxUsername.Text, txtboxPassword.Text);
                MessageBox.Show("User Added Successfully", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxConfirmPass.Clear();
            txtboxUsername.Focus();
        }

        private void txtboxConfirmPass_CursorChanged(object sender, EventArgs e)
        {

        }

        private void txtboxConfirmPass_Validated(object sender, EventArgs e)
        {
            if (txtboxPassword.Text != txtboxConfirmPass.Text)
            {
                MessageBox.Show("Password Not Match", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboboxUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
