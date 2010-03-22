using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class Logica
    {
        Entities entities = new Entities();

        public Question CreateQuestion(Question question)
        {
            if (!entities.ExistCategory(question.Category.IdCategory))
                entities.AddCategory(question.Category);

            int idQuestion = question.IdQuestion;
            if (idQuestion == -1)
            {
                idQuestion = entities.AddQuestion(question);
            }
            else
            {
                entities.UpdateQuestion(question);
            }
            
            foreach (var ans in question.Answers)
                entities.AddAnswer(ans, idQuestion);

            return entities.GetQuestion(idQuestion);
        }

        public User CreateUser(User user)
        {
            int idUser = entities.AddUser(user);

            return entities.GetUser(idUser);

        }

        public Score UpdateScore(User user, Category category, Boolean correct)
        {
            Score score;
            if (!entities.ExistScore(user.IdUser, category.IdCategory))
            {
                score = new Score()
                {
                    IdUser = user.IdUser,
                    IdCategory = category.IdCategory,
                    Correct = correct ? 1 : 0,
                    Total = 1
                };
                entities.AddScore(score);
            }
            else
            {
                score = entities.GetScore(user.IdUser, category.IdCategory);
                if (correct)
                    score.Correct++;
                score.Total++;
                entities.UpdateScore(score);
            }

            return score;
        }

        public List<Category> GetAllCategories()
        {
            int maxId = entities.GetMaxIdCategory();
            List<Category> res = new List<Category>();
            for (int i = 0; i <= maxId; i++)
            {
                if (entities.ExistCategory(i))
                {
                    res.Add(entities.GetCategory(i));
                }
            }

            return res;
        }
    }
}
