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
            SqlQuery.Query_Ingredient_FillDataGridViewWithIngredients(dgwIngredients);
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
            SqlQuery.Query_Ingredient_FilterIngredients(dgwIngredients, field, txtFilter.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?",
                                                        "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // сохраняем выбранную ячейку
                var delRow = dgwIngredients.SelectedRows[0];

                // запрос на удаление
                SqlQuery.Query_Ingredient_DeleteIngredient(delRow.Cells[0].Value.ToString());

                // удаление из DataGridView
                dgwIngredients.Rows.Remove(delRow);
            }
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.OpenForm(new AddIngredientForm(), false);
            SqlQuery.Query_Ingredient_FillDataGridViewWithIngredients(dgwIngredients);
        }

        private void dgwIngredients_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblQuantity.Text = dgwIngredients.Rows.Count.ToString();
        }

        private void dgwIngredients_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblQuantity.Text = dgwIngredients.Rows.Count.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.OpenForm(new EditIngredientForm(dgwIngredients.SelectedRows[0]), false);
            SqlQuery.Query_Ingredient_FillDataGridViewWithIngredients(dgwIngredients);
        }
    }
}
