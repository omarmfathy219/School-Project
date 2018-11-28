using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace School_Project.Data_Access_Layer
{
    class DataAccessLayer
    {
        // ربط البرنامج (إنشاء الإتصال) بالداتا بيز
        SqlConnection sqlconnection;

        //Constructor to Initialize The Connection Object
        public DataAccessLayer()
        {                                   //Server Name; Database Name; Server Security //
            sqlconnection = new SqlConnection(@"Server=.\; Database=School_DB; Integrated Security=true");
        }

        //Open Connection Method
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        //Close Connection Method
        public void Clsoe()
        {
            if (sqlconnection.State != ConnectionState.Closed)
            {
                sqlconnection.Close();
            }
        }
    }
}
