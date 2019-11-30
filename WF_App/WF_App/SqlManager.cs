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
                IntegratedSecurity = true,
                InitialCatalog = "ws_train"
            };

            sql_connection = new SqlConnection(builder.ConnectionString);
        }
        public SqlManager(bool kek)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"mssql-ws.mopevm.sfedu.ru",
                InitialCatalog = "student7",
                UserID = "student7",
                Password = "student7student7"
            };

            //sql_connection = new SqlConnection(@"Data Source=mssql-ws.mopevm.sfedu.ru;Initial Catalog=student7;User ID=student7;Password=student7student7");
            sql_connection = new SqlConnection(builder.ConnectionString);
        }
    }
}
