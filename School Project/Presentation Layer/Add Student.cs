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
   
    public partial class Add_Student : MetroFramework.Forms.MetroForm
    {
        Business_Layer.CLS_Add_Student stud = new Business_Layer.CLS_Add_Student();
        public Add_Student()
        {
            InitializeComponent();
            cmboxAcademic_Year.DataSource = stud.Get_All_Academic_Year();
            cmboxAcademic_Year.DisplayMember= "ACADEMIC_YEAR";
            cmboxAcademic_Year.ValueMember = "ID";

            cmboxClass.DataSource = stud.Get_All_Class();
            cmboxClass.DisplayMember = "Get_All_Class";
            cmboxClass.ValueMember = "CLASS_NAME";

            cmboxSupervisor.DataSource = stud.Get_All_Supervisor();
            cmboxSupervisor.DisplayMember = "Get_All_Supervisor";
            cmboxSupervisor.ValueMember = "FIRST_NAME";

            cmboxFees.DataSource = stud.Get_Fees_Stauts();
            cmboxFees.DisplayMember = "Get_Fees_Stauts";
            cmboxFees.ValueMember = "FEES_STAUTS";

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            stud.Student_ADD(Convert.ToInt32(txtID.Text),txtFirst_Name.Text, txtLast_Name.Text, txtBirthDate.Text, cmboxClass.Text, cmboxAcademic_Year.Text, TxtPhone_Number.Text, TxtAddress.Text, cmboxSupervisor.Text, cmboxFees.Text);

            MessageBox.Show("Data Added Successfully");
        }
    }
}
