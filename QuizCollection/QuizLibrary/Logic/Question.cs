using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class Question : IEquatable<Question>
    {
        private int idQuestion;
        private String questionText;
        private Category category;
        private int difficulty;
        private List<Answer> answers;
        private String image;
        private String sound;

        public Question() { }

        public Question(String questionText, List<Answer> answers, Category category, int difficulty)
        {
            this.idQuestion = -1;
            this.questionText = questionText;
            this.answers = answers;
            this.category = category;
            this.difficulty = difficulty;
            this.image = null;
            this.sound = null;
        }

        public Question(String questionText, List<Answer> answers, Category category, int difficulty,String image, String sound)
        {
            this.idQuestion = -1;
            this.questionText = questionText;
            this.answers = answers;
            this.category = category;
            this.difficulty = difficulty;
            this.image = image;
            this.sound = sound;
        }

        public int IdQuestion 
        { 
            get { return idQuestion; } 
            set { idQuestion = value; } 
        }

        public String QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public List<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public String Image
        {
            get { return image; }
            set { image = value; }
        }

        public String Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public void AddQuestionInBD() 
        {
            Entities ge = new Entities();
            if (idQuestion == -1)
            {
                idQuestion = ge.AddQuestion(this);
            }
            else
            {
                ge.UpdateQuestion(this);
            }
        }

        public void AddAnswer(Answer answer)
        {
            Answers.Add(answer);
        }

        public void AddAnswer(String answer, Boolean correct)
        {
            Answers.Add(new Answer(answer, correct));
        }

        public List<Answer> getGameAnswers(int numberOfAnswers)
        {
            List<Answer> Result = new List<Answer>();
            int LastAnswers = numberOfAnswers;

            for (int i = 0; i < this.answers.Count; i++)
            {
                if (Answers[i].Correct) 
                {
                    Result.Add(this.answers[i]);
                    LastAnswers--;
                    break;
                }
            }

            for (int i = 0; i < this.answers.Count; i++)
            {
                if (!Answers[i].Correct)
                {
                    Result.Add(this.answers[i]);
                    LastAnswers--;
                    if (LastAnswers == 0) break;
                }
            }
            if (LastAnswers < 0) 
            {
                Result.Add(new Answer("--", false));
            }

            return Result;
        }

        public List<Answer> GetGameAnswers()
        {
            return this.getGameAnswers(4);
        }

        public int getNumberOfCorrectAnswers()
        {
            int res = 0;
            foreach(Answer e in Answers)
            {
                if(e.Correct)
                {
                    res++;
                }
            }
            return res;
        }

        public void DeleteAnswer(int index)
        {
            Answers.RemoveAt(index);
        }

        public override string ToString()
        {
            return this.idQuestion+", "+this.questionText;
        }

        #region Miembros de IEquatable<Question>

        public bool Equals(Question other)
        {
            Boolean res = false;
            if (other != null)
            {
                res = this.idQuestion == other.idQuestion;
            }

            return res;
        }

        #endregion
    }
}
