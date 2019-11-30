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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            SqlQuery.Query_FillDataGridViewWithUsers(dgwUsers);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //string field = "User_ID";
            //switch(cboxField.Text)
            //{
            //    case "ID":
            //        field = "User_ID";
            //        return;
            //    case "Фамилия":
            //        field = "User_SecondName";
            //        return;
            //    case "Имя Отчество":
            //        field = "User_First_Middle_Name";
            //        return;
            //    case ""

            //}
            //SqlQuery.Query_FilterUsers(dgwUsers, )
        }
    }
}
