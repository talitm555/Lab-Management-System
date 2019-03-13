using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Lab_Management_System
{
    class SQLServer
    {
        public static string conURL = "Data Source = TALITMAHMOOD-PC; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
        public static SqlConnection Connection = new SqlConnection(conURL);
    }
}
