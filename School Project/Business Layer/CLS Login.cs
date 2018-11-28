using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace School_Project.Business_Layer
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, String PASSWORD)
        {
            Data_Access_Layer.DataAccessLayer DAL = new Data_Access_Layer.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 25);
            param[1].Value = PASSWORD;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.Clsoe();
            return Dt;
        }
    }
}