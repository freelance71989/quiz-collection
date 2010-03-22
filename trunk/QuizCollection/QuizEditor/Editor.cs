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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();


            Logica lg = new Logica();

            List<Category> listcate =lg.GetAllCategories();
            
            //Category geocategory = new Category("Geografia", "Desafia a tus conocimientos sobre paises");
            //List<Answer>answers1 = new List<Answer>();
            //answers1.Add(new Answer("madrid",true));
            //answers1.Add(new Answer("escocia",false));
            //answers1.Add(new Answer("londres",false));
            //answers1.Add(new Answer("marte",false));
            //questionList.Items.Add(new Question("Capital de españa?",answers1,geocategory,4));
            
        }

        private void editorDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditor f = new CategoryEditor();
            f.ShowDialog();
        }

        private void questionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question quest = (Question)questionList.Items[questionList.SelectedIndex];
            questionText.Text = quest.QuestionText;
            difficulty.Value = quest.Difficulty - 1;
            textDifficult.Text = quest.Difficulty.ToString();
            answersList.Items.Clear();
            answersList.Items.AddRange(quest.Answers.ToArray());
        }

        private void AñadirRespuesta(object sender, EventArgs e)
        {
            AnswerEditor ans = new AnswerEditor();
            ans.ShowDialog();
        }

        private void ActivarEditarAnswer(object sender, EventArgs e)
        {
            editAnswer.Enabled = answersList.SelectedItem != null;
        }

        private void ChangeTextDifficulty(object sender, EventArgs e)
        {
            textDifficult.Text = Convert.ToString(difficulty.Value + 1);
        }
    }
}
