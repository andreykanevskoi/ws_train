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
    public partial class AddIngredientForm : Form
    {
        public AddIngredientForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddIngredientForm_Load(object sender, EventArgs e)
        {
            List<string> args;
            args = SqlQuery.Query_Ingredient_GetGlossaryByList("dbo.PackGlos", "dbo.PackGlos.Pack");

            foreach(string arg in args)
            {
                cboxPack.Items.Add(arg);
            }

            args = SqlQuery.Query_Ingredient_GetGlossaryByList("dbo.TypeGlos", "dbo.TypeGlos.Type");

            foreach (string arg in args)
            {
                cboxType.Items.Add(arg);
            }

            cboxUnit.Items.Add("кг");
            cboxUnit.Items.Add("л");

            return;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {

        }
    }
}
