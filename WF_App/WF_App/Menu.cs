using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_App
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            if (User.user_role == User.ROLE_DIRECTOR)
                this.OpenForm(new UserList());
            else
            {
                MessageBox.Show("У вас нет прав для выполнения данного действия!",
                                "Предупреждение");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngredientsList_Click(object sender, EventArgs e)
        {
            this.OpenForm(new IngredientList());
        }
    }
}
