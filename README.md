# Подготовка к WorldSkills
## Пробую разные приемы и фичи
### 29.11.2019 22:00 UPD #1
* Добавлена форма авторизации
* Добавлена форма регистрации, полная проверка новых логина и пароля, отправка пользователя в БД
* Добавлен класс SqlQuery, содержащий функции C# для обращения к БД
* Добавлен класс Features, содержащий полезные для работы функции C#
* Добавлен класс SqlManager, упрощающий работу с SQL запросами
### 30.11.2019 XX.XX UPD #2
#### 2.1 ####
* Добавил проверку логина при авторизации
* Улучшил читаемость методов с помощью **string.Format** (Приложение 1)
## Ближайшие планы:
1. <del>добавить проверку полей при авторизации</del>
1. <del>переписать запросы в читаемую форму</del>
1. добавить форму с DataGridView 
1. реализовать сортировку и фильтрацию  


#### Приложение 1 ####
```csharp
public static void Query_NewUser(string login, string password, int role)
        {
            SqlManager manager = new SqlManager();
            manager.sql_connection.Open();

            string request = string.Format(@"INSERT INTO Users (User_Login, User_Password, Role_ID) " +
                                           @"VALUES ('{0}','{1}', {2})", 
                                           login, password, Convert.ToString(role));
            // ...
            // ...

            return;
        }
```
