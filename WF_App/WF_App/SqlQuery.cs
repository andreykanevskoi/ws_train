using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WF_App
{
    static class SqlQuery
    {
        public static bool Query_isExistLogin(string login)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = string.Format(@"SELECT User_Login FROM Users WHERE User_Login='{0}'", login);

            manager.sql_command = new SqlCommand(request, manager.sql_connection);

            manager.sql_DR = manager.sql_command.ExecuteReader();
            manager.sql_DR.Read();

            bool isExistLogin = manager.sql_DR.HasRows;

            manager.sql_connection.Close();
            return isExistLogin;
        }

        public static bool Query_isExistAccount(string login, string pw)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = string.Format(@"SELECT User_Login, User_Password "+
                                           @"FROM Users WHERE User_Login='{0}' AND User_Password='{1}'", login, pw);

            manager.sql_command = new SqlCommand(request, manager.sql_connection);

            manager.sql_DR = manager.sql_command.ExecuteReader();
            manager.sql_DR.Read();

            bool isExistPassword = manager.sql_DR.HasRows;

            manager.sql_connection.Close();

            return isExistPassword;
        }
    
        public static void Query_initUser(string login)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = string.Format(@"SELECT User_Login, Role_ID FROM Users WHERE User_Login='{0}'", login);

            manager.sql_command = new SqlCommand(request, manager.sql_connection);

            manager.sql_DR = manager.sql_command.ExecuteReader();
            manager.sql_DR.Read();

            User.user_login = manager.sql_DR[0].ToString();
            User.user_role = Convert.ToInt32(manager.sql_DR[1].ToString());

            manager.sql_connection.Close();
            return;
        }

        public static void Query_NewUser(string login, string password, int role)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = string.Format(@"INSERT INTO Users (User_Login, User_Password, Role_ID) " +
                                           @"VALUES ('{0}','{1}', {2})", login, password, Convert.ToString(role));

            manager.sql_command = new SqlCommand(request, manager.sql_connection);

            manager.sql_command.ExecuteNonQuery();
            manager.sql_connection.Close();
            return;
        }
    
        public static void Query_FillDataGridViewWithUsers(DataGridView dgw)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = "SELECT u.[User_ID], u.[User_SecondName], u.[User_First_Middle_Name], u.[User_Login], r.[Role] " +
                             "FROM Users as u JOIN Roles as r ON u.Role_ID = r.Role_ID";

            manager.sql_command = new SqlCommand(request, manager.sql_connection);
            manager.sql_DR = manager.sql_command.ExecuteReader();

            while(manager.sql_DR.Read())
            {
                string[] row =
                {
                    manager.sql_DR[0].ToString(),
                    manager.sql_DR[1].ToString(),
                    manager.sql_DR[2].ToString(),
                    manager.sql_DR[3].ToString(),
                    manager.sql_DR[4].ToString()
                };
                dgw.Rows.Add(row);
            }
            
            manager.sql_connection.Close();
            return;
        }

        public static void Query_FilterUsers(DataGridView dgw, string column, string pattern)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            dgw.Rows.Clear();

            string request = "SELECT u.[User_ID], u.[User_SecondName], u.[User_First_Middle_Name], u.[User_Login], r.[Role] " +
                             "FROM Users as u JOIN Roles as r ON u.Role_ID = r.Role_ID " +
              string.Format(@"WHERE [{0}] LIKE '%{1}%'", column, pattern);

            manager.sql_command = new SqlCommand(request, manager.sql_connection);
            manager.sql_DR = manager.sql_command.ExecuteReader();

            while (manager.sql_DR.Read())
            {
                string[] row =
                {
                    manager.sql_DR[0].ToString(),
                    manager.sql_DR[1].ToString(),
                    manager.sql_DR[2].ToString(),
                    manager.sql_DR[3].ToString(),
                    manager.sql_DR[4].ToString()
                };
                dgw.Rows.Add(row);
            }

            manager.sql_connection.Close();
            return;
        }

        public static void Query_FillDataGridViewWithIngredients(DataGridView dgw)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = @"SELECT i.[IngredientID],i.[Name],t.[Type],i.[Price],p.[Pack],i.[Quantity],i.[Unit] " +
                             @"FROM[dbo].[Ingredients] as i " +
                             @"JOIN [dbo].[PackGlos] as p ON i.[PackID] = p.[Pack_ID] " +
                             @"JOIN[dbo].[TypeGlos] as t ON i.[TypeID] = t.[Type_ID]";

            manager.sql_command = new SqlCommand(request, manager.sql_connection);
            manager.sql_DR = manager.sql_command.ExecuteReader();

            while (manager.sql_DR.Read())
            {
                string[] row =
                {
                    manager.sql_DR[0].ToString(),
                    manager.sql_DR[1].ToString(),
                    manager.sql_DR[2].ToString(),
                    (Convert.ToDouble(manager.sql_DR[3])).ToString("0.00"),
                    manager.sql_DR[4].ToString(),
                    manager.sql_DR[5].ToString(),
                    manager.sql_DR[6].ToString()
                };
                dgw.Rows.Add(row);
            }

            manager.sql_connection.Close();
            return;
        }

        public static void Query_FilterIngredients(DataGridView dgw, string column, string pattern)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            dgw.Rows.Clear();

            string request = @"SELECT i.[IngredientID],i.[Name],t.[Type],i.[Price],p.[Pack],i.[Quantity],i.[Unit] " +
                             @"FROM[dbo].[Ingredients] as i " +
                             @"JOIN [dbo].[PackGlos] as p ON i.[PackID] = p.[Pack_ID] " +
                             @"JOIN[dbo].[TypeGlos] as t ON i.[TypeID] = t.[Type_ID]" +
               string.Format(@"WHERE [{0}] LIKE '%{1}%'", column, pattern);

            manager.sql_command = new SqlCommand(request, manager.sql_connection);
            manager.sql_DR = manager.sql_command.ExecuteReader();

            while (manager.sql_DR.Read())
            {
                string[] row =
                {
                    manager.sql_DR[0].ToString(),
                    manager.sql_DR[1].ToString(),
                    manager.sql_DR[2].ToString(),
                    (Convert.ToDouble(manager.sql_DR[3])).ToString("0.00"),
                    manager.sql_DR[4].ToString(),
                    manager.sql_DR[5].ToString(),
                    manager.sql_DR[6].ToString()
                };
                dgw.Rows.Add(row);
            }

            manager.sql_connection.Close();
            return;
        }
        
    }
}
