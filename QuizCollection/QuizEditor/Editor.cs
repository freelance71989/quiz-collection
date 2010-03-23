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
        private CategoryEditor formCategory;
        public Editor()
        {
            InitializeComponent();

            Logica logic = new Logica();
            List<Category> categ = logic.GetAllCategories();
            List<Question> question = logic.GetAllQuestion();

            questionList.Items.AddRange(question.ToArray());

            formCategory = new CategoryEditor();
            formCategory.categoryList.Items.AddRange(categ.ToArray());

            //Category geocategory = new Category("Geografia", "Desafia a tus conocimientos sobre paises");
            //List<Answer> answers1 = new List<Answer>();
            //answers1.Add(new Answer("madrid", true));
            //answers1.Add(new Answer("escocia", false));
            //answers1.Add(new Answer("londres", false));
            //answers1.Add(new Answer("marte", false));
            //questionList.Items.Add(new Question("Capital de españa?", answers1, geocategory, 4));
            
        }

        private void editorDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategory.ShowDialog();
        }

        private void questionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionList.SelectedItem != null)
            {
                //activar elementos
                textBoxImageRute.Enabled = true;
                textBoxSoundRute.Enabled = true;
                textBoxQuestion.Enabled = true;
                comboBoxCategory.Enabled = true;
                labelDifficulty.Enabled = true;
                deleteQuestion.Enabled = true;
                buttonImage.Enabled = true;
                buttonSound.Enabled = true;
                buttonCreateAnswer.Enabled = true;
                trackBarDifficulty.Enabled = true;
                //lalalalal
                Question quest = (Question)questionList.Items[questionList.SelectedIndex];
                textBoxQuestion.Text = quest.QuestionText;
                trackBarDifficulty.Value = quest.Difficulty - 1;
                labelDifficulty.Text = quest.Difficulty.ToString();
                answersList.Items.Clear();
                answersList.Items.AddRange(quest.Answers.ToArray());


            }
            else
            {
                //desactivar elementos
                textBoxImageRute.Enabled = false;
                textBoxSoundRute.Enabled = false;
                textBoxQuestion.Enabled = false;
                comboBoxCategory.Enabled = false;
                labelDifficulty.Enabled = false;
                deleteQuestion.Enabled = false;
                buttonImage.Enabled = false;
                buttonSound.Enabled = false;
                buttonCreateAnswer.Enabled = false;
                buttonDeleteAnswer.Enabled = false;
                buttonEditAnswer.Enabled = false;
                trackBarDifficulty.Enabled = false;
                //procesos
                textBoxQuestion.Text = "";
                trackBarDifficulty.Value = 0;
                labelDifficulty.Text = Convert.ToString(1);
                answersList.Items.Clear();
            }
        }

        private void AñadirRespuesta(object sender, EventArgs e)
        {
            AnswerEditor ans = new AnswerEditor();
            ans.ShowDialog();
        }

        private void ChangeTextDifficulty(object sender, EventArgs e)
        {
            labelDifficulty.Text = Convert.ToString(trackBarDifficulty.Value + 1);
        }

        private void ButtonAddQuestion(object sender, EventArgs e)
        {
            questionList.Items.Add(new Question("Nueva Pregunta",new List<Answer>(),new Category(),1));
        }

        private void ButtonDeleteQuestion(object sender, EventArgs e)
        {
            var toRemove = questionList.SelectedItem;
            questionList.Items.Remove(toRemove);
        }

        private void ButtonAnswerEditor(object sender, EventArgs e)
        {
            AnswerEditor ans = new AnswerEditor();
            ans.ShowDialog();
        }

        private void EditarRespuesta(object sender, EventArgs e)
        {
            AnswerEditor ans = new AnswerEditor();
            ans.ShowDialog();
        }

        private void SelectAnswer(object sender, EventArgs e)
        {
            if (answersList.SelectedItem != null)
            {
                //activar elementos
                buttonEditAnswer.Enabled = true;
                buttonDeleteAnswer.Enabled = true;
            }
            else
            {
                buttonEditAnswer.Enabled = false;
                buttonDeleteAnswer.Enabled = false;
            }
        }
    }
}
