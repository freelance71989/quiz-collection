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
    public partial class formEditor : Form
    {
        private FormCategory formCategory;
        private FormElements formElements;
        private HashSet<Object> editQuestions;
        private HashSet<Object> deleteQuestions;
        private HashSet<Object> newQuestions;
        private Logica logic;

        public formEditor()
        {
            InitializeComponent();
            logic = new Logica();
            editQuestions = new HashSet<Object>();
            deleteQuestions = new HashSet<Object>();
            newQuestions = new HashSet<Object>();
            formCategory = new FormCategory();
            formElements = new FormElements();
            LoadQuestions();
            LoadCategories();
        }

        private void LoadCategories()
        {
            List<Category> categories = logic.GetAllCategories();
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(categories.ToArray());
            formCategory.categoryList.Items.Clear();
            formCategory.categoryList.Items.AddRange(categories.ToArray());
            formElements.comboBoxCategory.Items.Clear();
            formElements.comboBoxCategory.Items.AddRange(categories.ToArray());
        }

        private void LoadQuestions()
        {
            if (newQuestions.Count != 0)
            {
                foreach (Question quest in newQuestions)
                {
                    logic.DeleteQuestion(quest);
                }
            }
            newQuestions.Clear();
            editQuestions.Clear();
            deleteQuestions.Clear();
            List<Question> questions = logic.GetAllQuestion();
            listBoxAnswersList.Items.Clear();
            listBoxQuestionList.Items.Clear();
            listBoxQuestionList.Items.AddRange(questions.ToArray());
        }

        private void SaveAll(object sender, EventArgs e)
        {
            foreach (Question question in editQuestions.Where(x=> !deleteQuestions.Contains(x)))
            {
                logic.CreateQuestion(question);
            }
            foreach (Question question in deleteQuestions)
            {
                logic.DeleteQuestion(question);
            }

            newQuestions.Clear();

            LoadQuestions();
            LoadCategories();
        }

        private void editorDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SetChanges())
            {
                formCategory.ShowDialog();
            }
        }

        private void ChangeSelectedIndexQuestion(object sender, EventArgs e)
        {
            if (listBoxQuestionList.SelectedItem != null)
            {
                //activar elementos
                textBoxImageRute.Enabled = true;
                textBoxSoundRute.Enabled = true;
                textBoxQuestion.Enabled = true;
                comboBoxCategory.Enabled = true;
                labelDifficulty.Enabled = true;
                buttonDeletQuestion.Enabled = true;
                buttonImage.Enabled = true;
                buttonSound.Enabled = true;
                buttonCreateAnswer.Enabled = true;
                trackBarDifficulty.Enabled = true;
                textBoxCreatorBy.Enabled = true;
                //escritura de datos
                Question quest = (Question)listBoxQuestionList.Items[listBoxQuestionList.SelectedIndex];
                textBoxQuestion.Text = quest.QuestionText;
                //seleccion del combobox
                int index = comboBoxCategory.FindString(quest.Category.ToString());
                comboBoxCategory.SelectedIndex = index;

                trackBarDifficulty.Value = quest.Difficulty - 1;
                labelDifficulty.Text = quest.Difficulty.ToString();
                listBoxAnswersList.Items.Clear();
                listBoxAnswersList.Items.AddRange(quest.Answers.ToArray());
                editQuestions.Add(quest);
                textBoxCreatorBy.Text = quest.CreatorBy;
            }
            else
            {
                //desactivar elementos
                textBoxImageRute.Enabled = false;
                textBoxSoundRute.Enabled = false;
                textBoxQuestion.Enabled = false;
                comboBoxCategory.Enabled = false;
                labelDifficulty.Enabled = false;
                buttonDeletQuestion.Enabled = false;
                buttonImage.Enabled = false;
                buttonSound.Enabled = false;
                buttonCreateAnswer.Enabled = false;
                buttonDeleteAnswer.Enabled = false;
                buttonEditAnswer.Enabled = false;
                trackBarDifficulty.Enabled = false;
                textBoxCreatorBy.Enabled = false;
                //escritura de datos
                textBoxQuestion.Text = "";
                trackBarDifficulty.Value = 0;
                labelDifficulty.Text = Convert.ToString(1);
                listBoxAnswersList.Items.Clear();
                textBoxCreatorBy.Text = "";
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
            if (listBoxQuestionList.SelectedItem != null)
            {
                ((Question)listBoxQuestionList.SelectedItem).Difficulty = trackBarDifficulty.Value + 1;
            }
        }

        private void AddQuestion(object sender, EventArgs e)
        {
            List<Answer> answers = new List<Answer>();
            answers.Add(new Answer("Answer 1", true));
            answers.Add(new Answer("Answer 2", false));
            answers.Add(new Answer("Answer 3", false));
            answers.Add(new Answer("Answer 4", false));

            String name = "Nueva Pregunta";
            int count = 0;
            foreach (Question item in listBoxQuestionList.Items)
            {
                if (item.QuestionText.Contains(name))
                    count++;
            }
            if (count != 0)
                name += " " + count;

            //categoria
            Category category = new Category("Nueva Categoria", "Por favor, selecciona una categoria");
            if (formElements.category != null)
            {
                category = formElements.category;
            }
            else if(comboBoxCategory.Items.Count > 0)
            {
                category = (Category)comboBoxCategory.Items[0];
            }

            if (category.CategoryText == "Nueva Categoria")
            {
                comboBoxCategory.Items.Add(category);
            }

            int difficulty = formElements.difficulty;
            if (difficulty == -1)
            {
                difficulty = 1;
            }
            Question quest = logic.CreateQuestion(new Question(name, answers, category, difficulty));
            quest.CreatorBy = formElements.creatorBy;

            listBoxQuestionList.Items.Add(quest);
            newQuestions.Add(listBoxQuestionList.Items[listBoxQuestionList.Items.Count - 1]);

        }

        private void DeleteQuestion(object sender, EventArgs e)
        {
            int index = listBoxQuestionList.SelectedIndex;
            var toRemove = listBoxQuestionList.SelectedItem;
            listBoxQuestionList.Items.Remove(toRemove);
            deleteQuestions.Add(toRemove);
            if (index != 0)
                listBoxQuestionList.SelectedIndex = index - 1;
            else
	        {
                if (listBoxQuestionList.Items.Count != 0)
                    listBoxQuestionList.SelectedIndex = 0;
	        }            
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
            if (listBoxAnswersList.SelectedItem != null)
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
            DialogResult r = openFileDialogImageFile.ShowDialog();
            if (r == DialogResult.OK)
            {
                String file = openFileDialogImageFile.FileName;
                textBoxImageRute.Text = file;
            }
        }

        private void OpenFileSound(object sender, EventArgs e)
        {
            DialogResult r = openFileDialogSoundFile.ShowDialog();
            if (r == DialogResult.OK)
            {
                String file = openFileDialogSoundFile.FileName;
                textBoxSoundRute.Text = file;
            }
        }

        private void ChangeQuestionText(object sender, EventArgs e)
        {
            if (listBoxQuestionList.SelectedItem != null)
            {
                ((Question)listBoxQuestionList.SelectedItem).QuestionText = textBoxQuestion.Text;
            }
        }

        private void ChangeCategoryQuestion(object sender, EventArgs e)
        {
            if (listBoxQuestionList.SelectedItem != null)
            {
                ((Question)listBoxQuestionList.SelectedItem).Category = (Category)comboBoxCategory.SelectedItem;
            }
        }

        private void LoadAll(object sender, EventArgs e)
        {
            LoadQuestions();
            LoadCategories();
        }

        private bool SetChanges() 
        {
            return editQuestions.Count > 0 || newQuestions.Count > 0 || deleteQuestions.Count > 0;
        }

        private void OpenAboutDialog(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void ShowFormElements(object sender, EventArgs e)
        {
            if (!SetChanges())
            {
                formElements.ShowDialog();
            }
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            //pedir guardar
        }
    }
}
