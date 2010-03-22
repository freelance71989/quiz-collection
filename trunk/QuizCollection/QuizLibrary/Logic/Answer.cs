using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class Answer
    {
        private int idAnswer;
        private String answerText;
        private Boolean correct;

        public Answer() { }

        public Answer(String answer, Boolean correct)
        {
            this.idAnswer = -1;
            this.answerText = answer;
            this.correct = correct;
        }

        public int IdAnswer
        {
            get { return idAnswer; }
            set { idAnswer = value; }
        }

        public String AnswerText
        {
            get { return answerText; }
            set { answerText = value; }
        }

        public Boolean Correct
        {
            get { return correct; }
            set { correct = value; }
        }

        public override string ToString()
        {
            String res = this.answerText;
            if (this.correct)
            {
                res += ", Correcta";
            }
            else
            {
                res += ", Incorrecta";
            }
            return res;
        }
    }
}
