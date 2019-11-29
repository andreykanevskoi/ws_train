using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_App
{
    static class Features
    {
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

        public static bool IsCorrectLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return false;

            if (!char.IsLetter(login[0]))
                return false;

            if (login.Length < 8 || login.Length > 20)
                return false;

            for (int i = 1; i < login.Length; i++)
            {
                char c = login[i];
                if (!(c >= 'a' && c <='z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9'))
                    return false;
            }

            return true;
        }

        public static bool IsCorrectPassword(string pw)
        {
            if (string.IsNullOrWhiteSpace(pw))
                return false;

            if (pw.Length < 8 || pw.Length > 20)
                return false;

            for (int i = 0; i < pw.Length; i++)
            {
                char c = pw[i];
                if (!(char.IsPunctuation(c) || char.IsSeparator(c) 
                    || c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' 
                    || c >= '0' && c <= '9'))
                    return false;
            }

            return true;
        }
    
        public static int GetRoleFromStr(string role) 
        {
            if (role == "Директор") return 1;
            if (role == "Мастер") return 2;
            if (role == "Менеджер по продажам") return 4;
            if (role == "Менеджер по закупкам") return 5;
            
            return 3;
        }
    }
}
