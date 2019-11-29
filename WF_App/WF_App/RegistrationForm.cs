using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_App
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtNewLogin.Text;
            string password = txtNewPass1.Text;

            // === проверка логина ===
            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Логин не может быть пустым!",
                                "Предупреждение");
                txtNewLogin.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                if (!Features.IsCorrectLogin(login))
                {
                    MessageBox.Show("Некорректный логин!\n" +
                                    "Логин должен" +
                                    "\n\t - начинаться с буквы"+
                                    "\n\t - иметь длину 8-20 символов"+
                                    "\n\t - содержать только цифры и буквы латинского алфавита",
                                    "Предупреждение");
                    txtNewLogin.BackColor = Color.LightCoral;
                    return;
                }
            }


            if (SqlQuery.Query_isExistLogin(login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует!",
                                "Предупреждение");
                return;
            }
           
            txtNewLogin.BackColor = Color.LightGreen;

            // === проверка пароля ===
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пароль не может быть пустым!",
                                "Предупреждение");
                txtNewPass1.BackColor = Color.LightCoral;
                return;
            }
            
            if (!Features.IsCorrectPassword(password))
            {
                MessageBox.Show("Некорректный Пароль!\n" +
                "Пароль должен" +
                "\n\t - иметь длину 8-20 символов" +
                "\n\t - содержать только символы, цифры и буквы латинского алфавита",
                "Предупреждение");
                txtNewPass1.BackColor = Color.LightCoral;
                return;
            }

            if (txtNewPass1.Text != txtNewPass2.Text)
            {
                MessageBox.Show("Пароли не совпадают!",
                                "Предупреждение");
                txtNewPass1.BackColor = Color.LightCoral;
                txtNewPass2.BackColor = Color.LightCoral;
                return;
            }

            txtNewPass1.BackColor = Color.LightGreen;
            txtNewPass2.BackColor = Color.LightGreen;

            if (string.IsNullOrEmpty(cboxRole.Text))
            {
                MessageBox.Show("Выберите должность!",
                                "Предупреждение");
                cboxRole.BackColor = Color.LightCoral;
                return;
            }

            cboxRole.BackColor = Color.LightGreen;

            SqlQuery.Query_NewUser(login,
                                   password,
                                   Features.GetRoleFromStr(cboxRole.Text));

            MessageBox.Show("ОК!");
            return;
        }
    }
}
