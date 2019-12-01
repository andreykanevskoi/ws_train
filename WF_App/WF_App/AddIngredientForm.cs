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

            args = SqlQuery.Query_Ingredient_GetGlossaryByList("dbo.UnitGlos", "dbo.UnitGlos.Unit");

            foreach (string arg in args)
            {
                cboxUnit.Items.Add(arg);
            }

            return;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            // проверка поля "Артикул"
            if (string.IsNullOrWhiteSpace(txtIngredientID.Text))
            {
                MessageBox.Show("Поле \"Артикул\" не может быть пустым!",
                                "Предупреждение");
                txtIngredientID.BackColor = Color.LightCoral;
                return;
            }
            if (SqlQuery.Query_Ingredient_IsExist(txtIngredientID.Text))
            {
                MessageBox.Show("Ингредиент с артикулом " + txtIngredientID.Text + " уже есть в базе!",
                                "Предупреждение");
                return;
            }
            txtIngredientID.BackColor = Color.LightGreen;

            // проверка поля "Наименование"
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Поле \"Наименование\" не может быть пустым!",
                                "Предупреждение");
                txtName.BackColor = Color.LightCoral;
                return;
            }
            txtName.BackColor = Color.LightGreen;

            // проверка поля "Цена"
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Поле \"Цена\" не может быть пустым!",
                                "Предупреждение");
                txtPrice.BackColor = Color.LightCoral;
                return;
            }
            try
            {
                double price = Convert.ToDouble(txtPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат поля \"Цена\"");
                txtPrice.BackColor = Color.LightCoral;
                return;
            }
            if (Convert.ToDouble(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Поле \"Цена\" не может быть меньше либо равным нулю!",
                                "Предупреждение");
                txtPrice.BackColor = Color.LightCoral;
                return;
            }
            
            txtPrice.BackColor = Color.LightGreen;

            // проверка поля "количество"
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Поле \"Количество\" не может быть пустым!",
                                "Предупреждение");
                txtQuantity.BackColor = Color.LightCoral;
                return;
            }
            if (Convert.ToInt32(txtQuantity.Text) <= 0)
            {
                MessageBox.Show("Поле \"Количество\" не может быть меньше либо равным нулю!",
                                "Предупреждение");
                txtQuantity.BackColor = Color.LightCoral;
                return;
            }
            txtQuantity.BackColor = Color.LightGreen;

            // всё ок, загружаем в базу
            SqlQuery.Query_Ingredient_InsertIngredient(Convert.ToInt32(txtIngredientID.Text),
                                                       txtName.Text,
                                                       cboxType.SelectedIndex,
                                                       Convert.ToDouble(txtPrice.Text),
                                                       cboxPack.SelectedIndex,
                                                       Convert.ToInt32(txtQuantity.Text),
                                                       cboxUnit.SelectedIndex);

            MessageBox.Show("Ингредиент добавлен!");
            this.Close();
        }
    }
}
