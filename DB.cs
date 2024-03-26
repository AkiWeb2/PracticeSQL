using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC
{
    internal class DB
    {
        SqlConnection con = new SqlConnection(@"Data Source =335-04\SQLEXPRESS; Initial Catalog = PRUK; integrated Security = True ");

        public void open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closed()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
