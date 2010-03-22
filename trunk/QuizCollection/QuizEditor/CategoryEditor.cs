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
    public partial class CategoryEditor : Form
    {

        public CategoryEditor()
        {
            InitializeComponent();
            categoryList.Items.Add((object)new Category("Historia","Cuenta las desdichas humanas"));
            categoryList.Items.Add((object)new Category("Geografia", "Desafia a tus conocimientos sobre paises"));
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category =(Category)categoryList.Items[categoryList.SelectedIndex];
            CategoryText.Text = category.CategoryText;
            description.Text = category.Description;
        }

        private void EliminarCategoria(object sender, EventArgs e)
        {
            categoryList.Items.Remove(categoryList.Items[categoryList.SelectedIndex]);
        }

        private void CambioNombreCategoria(object sender, EventArgs e)
        {
            Category category = (Category)categoryList.Items[categoryList.SelectedIndex];
            category.CategoryText = CategoryText.Text;
        }

        private void CambioCategoria(object sender, EventArgs e)
        {
            Category category = (Category)categoryList.Items[categoryList.SelectedIndex];
            category.Description = description.Text;
        }

        private void AñadirCategoria(object sender, EventArgs e)
        {
            categoryList.Items.Add(new Category() { IdCategory = -1, CategoryText = "nueva Categoria" });
        }
    }
}
