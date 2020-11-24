using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolDAL
{
    public class Connection
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BK7H63U;Initial Catalog=HighSchool;Integrated Security=True");
        public SqlConnection OpenConnection()
        {
            connection.Open();
            return connection;
        }
        public SqlConnection CloseConnection()
        {
            connection.Close();
            return connection;
        }
    }
}