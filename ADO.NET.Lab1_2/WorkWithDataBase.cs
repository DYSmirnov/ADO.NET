using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET.Lab1
{
    class WorkWithDataBase
    {
        public static int ExecuteScalarMethod(string cs, string qw)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = qw;
                int number = (int)command.ExecuteScalar();
                return number;
            }
        }
    }
}
