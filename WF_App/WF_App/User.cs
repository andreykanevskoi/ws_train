using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_App
{
    static class User
    {
        public static string user_login;
        public static int user_role;

        public const int ROLE_DIRECTOR = 1; // Директор
        public const int ROLE_MASTER = 2;   // Мастер
        public const int ROLE_CUSTOMER = 3; // Заказчик
        public const int ROLE_SALE_MANAGER = 4; // Менеджер по продажам
        public const int ROLE_PURCHASING_MANAGER = 5; // Менеджер по закупкам
       
    }
}
