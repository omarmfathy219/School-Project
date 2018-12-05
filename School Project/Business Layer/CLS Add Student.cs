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
    }
}
