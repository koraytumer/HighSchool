using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolDAL
{
    public class Command
    {
        Connection connection = new Connection();
        public SqlCommand sqlCommand(string _sql)
        {
            SqlCommand command = new SqlCommand(_sql, connection.OpenConnection());
            return command;
        }

    }
}