using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace School_Project.Business_Layer
{
    class CLS_Add_Student
    {
        public DataTable Get_All_Academic_Year()
        {
            Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Academic_Year", null);
            DAL.Clsoe();
            return Dt;
        }
        public DataTable Get_All_Class()
        {
            Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Class", null);
            DAL.Clsoe();
            return Dt;
        }
        public DataTable Get_All_Supervisor()
        {
            Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Supervisor", null);
            DAL.Clsoe();
            return Dt;
        }
        public DataTable Get_Fees_Stauts()
        {
            Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_Fees_Stauts", null);
            DAL.Clsoe();
            return Dt;
        }

            public void Student_ADD(int ID,string FIRST_NAME, string LAST_NAME, string BIRTH_DATE, string CLASS, string ACADEMIC_YEAR, string PHONE_NUMBER, string CITY, string STUDENT_SUPERVISOR,string STUDY_FEES)
        {

            Data_Access_Layer.DataAccessLayer Data_Access_Layer = new Data_Access_Layer.DataAccessLayer();
            Data_Access_Layer.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            param[1].Value = FIRST_NAME;

            param[2] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            param[2].Value = LAST_NAME;

            param[3] = new SqlParameter("@BIRTH_DATE", SqlDbType.Date);
            param[3].Value = BIRTH_DATE;

            param[4] = new SqlParameter("@CLASS", SqlDbType.VarChar, 25);
            param[4].Value = CLASS;

            param[5] = new SqlParameter("@ACADEMIC_YEAR", SqlDbType.VarChar, 25);
            param[5].Value = ACADEMIC_YEAR;

            param[6] = new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar, 11);
            param[6].Value = PHONE_NUMBER;

            param[7] = new SqlParameter("@CITY", SqlDbType.VarChar, 25);
            param[7].Value = CITY;

            param[8] = new SqlParameter("@STUDENT_SUPERVISOR", SqlDbType.VarChar, 25);
            param[8].Value = STUDENT_SUPERVISOR;

            param[9] = new SqlParameter("@STUDY_FEES", SqlDbType.VarChar, 25);
            param[9].Value =STUDY_FEES;

            Data_Access_Layer.ExecuteCommand("ADD_STUDENT", param);
            Data_Access_Layer.Clsoe();
        }
        public DataTable VerfiyStudentID(int ID)
        {
            Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerfiyStudentID", param);
            DAL.Clsoe();
            return Dt;
        }
    }
}
