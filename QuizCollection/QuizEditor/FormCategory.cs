﻿using System;
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
    public partial class FormCategory : Form
    {
        private HashSet<Object> deleteCategories;
        private HashSet<Object> changeCategories;
        private HashSet<Object> newCategories;
        private Logica logic;

        public FormCategory()
        {
            InitializeComponent();
            logic = new Logica();
            deleteCategories = new HashSet<Object>();
            changeCategories = new HashSet<Object>();
            newCategories = new HashSet<Object>();
        }

        private void EliminarCategoria(object sender, EventArgs e)
        {
            if (logic.GetNumberOfQuestionInCategory((Category)categoryList.SelectedItem) == 0)
            {
                int index = categoryList.SelectedIndex;
                var toRemove = categoryList.SelectedItem;
                deleteCategories.Add(toRemove);
                categoryList.Items.Remove(toRemove);
                if (index != 0)
                    categoryList.SelectedIndex = index - 1;
                else
                {
                    if (categoryList.Items.Count != 0)
                        categoryList.SelectedIndex = 0;
                }  
            }
        }

        private void ChangeNameCategory(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                ((Category)categoryList.SelectedItem).CategoryText = textBoxCategory.Text;
            }
        }

        private void ChangeDescriptionCategory(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                ((Category)categoryList.SelectedItem).Description = textBoxDescription.Text;
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
            Category category = new Category() { IdCategory = -1, CategoryText = name };
            category.IdCategory = logic.CreateCategory(category);
            newCategories.Add(category);
            categoryList.Items.Add(category);
        }

        private void SelectCategoryIndex(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                changeCategories.Add(categoryList.SelectedItem);
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
            foreach (Category category in newCategories)
            {
                logic.DeteleCategory(category.IdCategory);
            }
            categoryList.Items.Clear();
            categoryList.Items.AddRange(logic.GetAllCategories().ToArray());
            deleteCategories.Clear();
            changeCategories.Clear();
            newCategories.Clear();
            this.Close();
        }

        private void AceptChanges(object sender, EventArgs e)
        {
            foreach (Category category in changeCategories)
            {
                logic.CreateCategory(category);
            }
            foreach (Category category in newCategories)
            {
                logic.CreateCategory(category);
            }
            foreach (Category category in deleteCategories)
            {
                logic.DeteleCategory(category.IdCategory);
            }
            categoryList.Items.Clear();
            categoryList.Items.AddRange(logic.GetAllCategories().ToArray());
            deleteCategories.Clear();
            changeCategories.Clear();
            newCategories.Clear();
            this.Close();
        }
    }
}
