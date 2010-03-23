using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuizLibrary;

namespace QuizEditor
{
    public partial class CategoryEditor : Form
    {
        private List<int> deteleIndex = new List<int>();

        public CategoryEditor()
        {
            InitializeComponent();
        }

        private void EliminarCategoria(object sender, EventArgs e)
        {
            var toRemove = categoryList.SelectedItem;
            if (((Category)toRemove).IdCategory != -1)
            {
                deteleIndex.Add(((Category)toRemove).IdCategory);
            }
            categoryList.Items.Remove(toRemove);
        }

        private void CambioNombreCategoria(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                ((Category)categoryList.SelectedItem).CategoryText = textBoxCategory.Text;
                categoryList.Refresh();
            }
        }

        private void CambioCategoria(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                Category category = (Category)categoryList.Items[categoryList.SelectedIndex];
                category.Description = textBoxDescription.Text;
            }
        }

        private void AñadirCategoria(object sender, EventArgs e)
        {
            String name = "Nueva Categoria";
            int count = 0;
            foreach (Category item in categoryList.Items)
            {
                if (item.CategoryText.Contains(name))
                   count++;
            }
            if (count != 0)
                name += " " + count;
            categoryList.Items.Add(new Category() { IdCategory = -1, CategoryText = name });
        }

        private void SelectCategoryIndex(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                //activar elementos
                buttonEraseCategory.Enabled = true;
                textBoxCategory.Enabled = true;
                textBoxDescription.Enabled = true;
                //otros procesos
                Category category = (Category)categoryList.SelectedItem;
                textBoxCategory.Text = category.CategoryText;
                textBoxDescription.Text = category.Description;
            }
            else
            {
                //desactivar elementos
                buttonEraseCategory.Enabled = false;
                textBoxCategory.Enabled = false;
                textBoxDescription.Enabled = false;
                //otros procesos
                textBoxCategory.Text = "";
                textBoxDescription.Text = "";
            }
        }

        private void DiscardChanges(object sender, EventArgs e)
        {
            categoryList.Items.Clear();
            Logica logic = new Logica();
            categoryList.Items.AddRange(logic.GetAllCategories().ToArray());
            deteleIndex.Clear();
            this.Close();
        }

        private void AceptChanges(object sender, EventArgs e)
        {
            Logica logic = new Logica();
            foreach (Category category in categoryList.Items)
            {
                logic.CreateCategory(category);
            }
            foreach (int index in deteleIndex)
            {
                logic.DeteleCategory(index);
            }
            categoryList.Items.Clear();
            categoryList.Items.AddRange(logic.GetAllCategories().ToArray());
            deteleIndex.Clear();
            this.Close();
        }
    }
}
