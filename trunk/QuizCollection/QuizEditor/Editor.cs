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
        List<int> deleteIndex = new List<int>();
        public Editor()
        {
            InitializeComponent();

            Logica logic = new Logica();
            List<Category> categories = logic.GetAllCategories();
            List<Question> questions = logic.GetAllQuestion();

            questionList.Items.AddRange(questions.ToArray());
            comboBoxCategory.Items.AddRange(categories.ToArray());

            formCategory = new CategoryEditor();
            formCategory.categoryList.Items.AddRange(categories.ToArray());
            
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
                comboBoxCategory.SelectedItem = quest.Category; //??
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
            if (questionList.SelectedItem != null)
            {
                ((Question)questionList.SelectedItem).Difficulty = trackBarDifficulty.Value + 1;
            }
        }

        private void ButtonAddQuestion(object sender, EventArgs e)
        {
            List<Answer> answers = new List<Answer>();
            answers.Add(new Answer("Answer 1", true));
            answers.Add(new Answer("Answer 2", false));
            answers.Add(new Answer("Answer 3", false));
            answers.Add(new Answer("Answer 4", false));

            String name = "Nueva Pregunta";
            int count = 0;
            foreach (Question item in questionList.Items)
            {
                if (item.QuestionText.Contains(name))
                    count++;
            }
            if (count != 0)
                name += " " + count;

            Category category = new Category("Nueva Categoria","Por favor, selecciona una categoria");
            if (comboBoxCategory.Items.Count != 0)
            {
                category = (Category)comboBoxCategory.Items[0];
            }
            questionList.Items.Add(new Question(name,answers,category,1));
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

        private void OpenFileImage(object sender, EventArgs e)
        {
            DialogResult r = openImageFile.ShowDialog();
            if (r == DialogResult.OK)
            {
                String file = openImageFile.FileName;
                textBoxImageRute.Text = file;
            }
        }

        private void OpenFileSound(object sender, EventArgs e)
        {
            DialogResult r = openSoundFile.ShowDialog();
            if (r == DialogResult.OK)
            {
                String file = openSoundFile.FileName;
                textBoxSoundRute.Text = file;
            }
        }

        private void ChangeQuestionText(object sender, EventArgs e)
        {
            if (questionList.SelectedItem != null)
            {
                ((Question)questionList.SelectedItem).QuestionText = textBoxQuestion.Text;
            }
        }

        private void ChangeCategoryQuestion(object sender, EventArgs e)
        {
            if (questionList.SelectedItem != null)
            {
                ((Question)questionList.SelectedItem).Category = (Category)comboBoxCategory.SelectedItem;
            }
        }

        private void SaveAllChanges(object sender, EventArgs e)
        {
            Logica logic = new Logica();
            foreach (Question question in questionList.Items)
            {
                logic.CreateQuestion(question);
            }
            foreach (int index in deleteIndex)
            {
                logic.DeteleCategory(index);
            }
            questionList.Items.Clear();
            questionList.Items.AddRange(logic.GetAllQuestion().ToArray());
            deleteIndex.Clear();
        }

        private void SaveChange(object sender, EventArgs e)
        {
            Logica logic = new Logica();
            logic.CreateQuestion((Question)questionList.SelectedItem);
        }

    }
}
