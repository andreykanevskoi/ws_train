# Преобразование double в строку для адекватной вставки в БД
```csharp
 if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Поле \"Цена\" не может быть пустым!",
                                "Предупреждение");
                txtPrice.BackColor = Color.LightCoral;
                return;
            }
            try
            {
                double price = Convert.ToDouble(txtPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат поля \"Цена\"");
                txtPrice.BackColor = Color.LightCoral;
                return;
            }
```

# Удачная вставка в comboBox
```csharp
    cboxUnit.SelectedIndex = cboxUnit.Items.IndexOf(oldRow.Cells[6].Value.ToString());
```

# MessageBox с кнопками и обработкой
```csharp
    DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?",
                                                        "Предупреждение", MessageBoxButtons.YesNo);
    if (dialogResult == DialogResult.Yes)
            {
                // ...
            }
    return;
```

# Супер полезный метод OpenForm()
```csharp
public static DialogResult OpenForm(this Form form, Form secondForm, bool hiddenOwner = true)
        {
            // Если флаг, что нужно скрывать родительскую форму активен -> скрываем
            if (hiddenOwner)
                form.Hide();

            // Получить результат открытия нового окна
            var result = secondForm.ShowDialog(form);

            if (hiddenOwner)
                form.Show();

            // Очищаем ресурсы открытой формы
            secondForm.Dispose();

            return result;
        }
```

# Удобный класс SqlManager
```csharp
    class SqlManager
        {
            public SqlConnection sql_connection;
            public SqlCommand sql_command;
            public SqlDataReader sql_DR;
            // подключение локально
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
            // подключение удаленно
            public SqlManager(bool kek)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = @"mssql-ws.mopevm.sfedu.ru",
                    InitialCatalog = "student7",
                    UserID = "student7",
                    Password = "student7student7"
                };

                // первый вариант соединения
                sql_connection = new SqlConnection(@"Data Source=mssql-ws.mopevm.sfedu.ru;Initial Catalog=student7;User ID=student7;Password=student7student7");
                // второй вариант соединения
                sql_connection = new SqlConnection(builder.ConnectionString);
            }
        }
```

# Функции - запросы класса SqlQuery
```csharp
// супер-полезные using
using System.Data.Sql;
using System.Data.SqlClient;

// запрос типа isExist
    public static bool Query_User_isExistLogin(string login)
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

// запрос INSERT
    public static void Query_User_NewUser(string login, string password, int role)
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
    
// заполнение DataGridView
    public static void Query_User_FillDataGridViewWithUsers(DataGridView dgw)
    {
        SqlManager manager = new SqlManager();
        manager.sql_connection.Open();

        string request = "SELECT u.[User_ID], u.[User_SecondName], u.[User_First_Middle_Name], u.[User_Login], r.[Role] " +
                            "FROM Users as u JOIN Roles as r ON u.Role_ID = r.Role_ID";

        manager.sql_command = new SqlCommand(request, manager.sql_connection);
        manager.sql_DR = manager.sql_command.ExecuteReader();

        dgw.Rows.Clear();
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

// запрос на фильтрацию
    public static void Query_User_FilterUsers(DataGridView dgw, string column, string pattern)
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

// запрос DELETE
    public static void Query_Ingredient_DeleteIngredient(string ID)
    {
        SqlManager manager = new SqlManager();
        manager.sql_connection.Open();

        string request = string.Format(@"DELETE FROM [dbo].[Ingredients] " +
                                        @"WHERE [dbo].[Ingredients].[IngredientID] = {0}", ID);

        manager.sql_command = new SqlCommand(request, manager.sql_connection);
        manager.sql_command.ExecuteNonQuery();

        manager.sql_connection.Close();
    }

// запрос с возвращением списка
    public static List<string> Query_Ingredient_GetGlossaryByList(string table, string column)
    {
        SqlManager manager = new SqlManager();
        manager.sql_connection.Open();

        List<string> result = new List<string>();

        string request = string.Format(@"SELECT {0} FROM {1}", column, table);

        manager.sql_command = new SqlCommand(request, manager.sql_connection);

        manager.sql_DR = manager.sql_command.ExecuteReader();
        while(manager.sql_DR.Read())
        {
            result.Add(manager.sql_DR[0].ToString());
        }

        manager.sql_connection.Close();
        return result;
    }
}
```

# Работа с FileDialog
```csharp
    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveFileDialog save = new SaveFileDialog();
        save.Filter = "Изображения |*.jpg";
        save.DefaultExt = "Изображения |*.jpg";
        //save.FileName = path_UserImage;
        var res = save.ShowDialog();

        if (res == DialogResult.Cancel)
            return;

        if (System.IO.File.Exists(save.FileName))
            System.IO.File.Delete(save.FileName);

        System.IO.File.Copy(path_UserImage, save.FileName);
        MessageBox.Show("Файл сохранен.");
        return;
    }
```