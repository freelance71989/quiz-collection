using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class Score
    {
        private int idUser;
        private int idCategory;
        private int correct;
        private int total;

        public Score() { }

        public Score(int idCategory, int correct, int total)
        {
            this.idUser = -1;
            this.idCategory = idCategory;
            this.correct = correct;
            this.total = total;
        }

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Correct
        {
            get { return correct; }
            set { correct = value; }
        }
    }
}
