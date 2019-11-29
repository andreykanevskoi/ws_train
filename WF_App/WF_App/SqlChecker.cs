using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WF_App
{
    static class SqlChecker
    {
        public static bool isExistLogin(string login)
        {
            SqlManager manager = new SqlManager();

            string request = "SELECT User_Login FROM Users WHERE User_Login=" + '\'' + login + '\'';

            manager.sql_command = new SqlCommand(request, manager.sql_connection);

            manager.sql_DR = manager.sql_command.ExecuteReader();
            manager.sql_DR.Read();

            bool isExistLogin = manager.sql_DR.HasRows;

            return isExistLogin;
        }

        public static bool isExistAccount(string login, string pw)
        {
            SqlManager manager = new SqlManager();

            string request = "SELECT User_Login, User_Password FROM Users WHERE User_Login=" +
                '\'' + login + '\'' + " AND " + "User_Password=" + '\'' + pw + '\'';

            manager.sql_command = new SqlCommand(request, manager.sql_connection);

            manager.sql_DR = manager.sql_command.ExecuteReader();
            manager.sql_DR.Read();

            bool isExistPassword = manager.sql_DR.HasRows;

            return isExistPassword;
        }
    
    
    }
}
