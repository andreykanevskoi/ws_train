using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (!SqlChecker.isExistLogin(login))
            {
                MessageBox.Show("Пользователя с таким логином не существует!");
                return;
            }

            if (!SqlChecker.isExistAccount(login, pass))
            {
                MessageBox.Show("Неверный пароль!");
                return;
            }

            MessageBox.Show("Вы вошли!");
            return;
        }
    }

    
}
