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
    public partial class IngredientList : Form
    {
        public IngredientList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngredientList_Load(object sender, EventArgs e)
        {
            SqlQuery.Query_FillDataGridViewWithIngredients(dgwIngredients);
        }
    }
}
