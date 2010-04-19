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
    public partial class FormElements : Form
    {
        public int difficulty;
        public Category category;
        public String creatorBy;

        public FormElements()
        {
            InitializeComponent();
            difficulty = -1;
            category = null;
            creatorBy = "";
        }

        private void ChangeDifficulty(object sender, EventArgs e)
        {
            labelDifficulty.Text = Convert.ToString(trackBarDifficulty.Value + 1);
        }

        private void AcceptChanges(object sender, EventArgs e)
        {
            if (checkBoxDefaulValues.Checked == false)
            {

                difficulty = trackBarDifficulty.Value + 1;
                category = (Category)comboBoxCategory.SelectedItem;
                creatorBy = textBoxCreatorBy.Text;
            }
            else
            {
                difficulty = -1;
                category = null;
                creatorBy = "";
            }
            this.Close();
        }

        private void DiscardChanges(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectCategory(object sender, EventArgs e)
        {
            category = (Category)comboBoxCategory.SelectedItem;
        }
    }
}
