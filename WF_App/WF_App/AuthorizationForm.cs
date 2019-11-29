using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WF_App
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPassword.Text;

            if (!SqlQuery.Query_isExistLogin(login))
            {
                MessageBox.Show("Пользователя с таким логином не существует!",
                                "Предупреждение");
                return;
            }

            if (!SqlQuery.Query_isExistAccount(login, pass))
            {
                MessageBox.Show("Неверный пароль!",
                                "Предупреждение");
                return;
            }

            SqlQuery.Query_initUser(login);
            MessageBox.Show("Здравствуйте, " + User.user_login + "!");

            return;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.OpenForm(new RegistrationForm());
        }
    }

    
}
