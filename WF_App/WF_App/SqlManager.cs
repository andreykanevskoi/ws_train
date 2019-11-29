using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WF_App
{
    class SqlManager
    {
        public SqlConnection sql_connection;
        public SqlCommand sql_command;
        public SqlDataReader sql_DR;
        public SqlManager()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "LAPTOP-FA26V349",
                InitialCatalog = "ws_train",
                IntegratedSecurity = true
            };

            sql_connection = new SqlConnection(builder.ConnectionString);
        }
    }
}
