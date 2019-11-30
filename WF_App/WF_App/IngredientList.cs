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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string field = "IngredienID";
            switch (cboxColumn.Text)
            {
                case "Артикул":
                    field = "IngredienID";
                    break;
                case "Наименование":
                    field = "Name";
                    break;
                case "Тип":
                    field = "Type";
                    break;
                case "Цена":
                    field = "Price";
                    break;
                case "Фасовка":
                    field = "Pack";
                    break;
                case "Количество":
                    field = "Quantity";
                    break;
                case "Единицы измерения":
                    field = "Unit";
                    break;
                default:
                    MessageBox.Show("Не выбрано поле сортировки!",
                                    "Предупреждение");
                    return;
            }
            SqlQuery.Query_FilterIngredients(dgwIngredients, field, txtFilter.Text);
        }
    }
}
