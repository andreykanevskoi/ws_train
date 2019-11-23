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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPassword.Text;

            SqlConnection sqlconnection = new SqlConnection("Data Source=G423-7;Initial Catalog=ws_train;Integrated Security=True");
            sqlconnection.Open();

            string req = "SELECT User_Login FROM Users WHERE User_Login=" + '\'' + login + '\'';
            SqlCommand sqlcommand = new SqlCommand(req, sqlconnection);

            bool isExistLogin = true;

            using (SqlDataReader sqlDR = sqlcommand.ExecuteReader())
            {
                sqlDR.Read();
                isExistLogin = sqlDR.HasRows;
            }

            if (!isExistLogin)
            {
                MessageBox.Show("Пользователя с таким логином не существует!");
                return;
            }

            req = "SELECT User_Login, User_Password FROM Users WHERE User_Login=" + '\'' + login + '\'' + " AND " + "User_Password=" + '\'' + pass + '\'';
            sqlcommand = new SqlCommand(req, sqlconnection);

            bool isExistPassword = true;

            using (SqlDataReader sqlDR = sqlcommand.ExecuteReader())
            {
                sqlDR.Read();
                isExistPassword = sqlDR.HasRows;
            }

            if (!isExistPassword)
            {
                MessageBox.Show("Неверный пароль!");
                return;
            }

            MessageBox.Show("Вы вошли!");
            return;
        }
    }
}
