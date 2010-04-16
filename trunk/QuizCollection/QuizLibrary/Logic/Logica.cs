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

            return entities.GetQuestion(idQuestion);
        }

        public void DeleteQuestion(Question question)
        {
            entities.DeleteQuestion(question.IdQuestion);
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
            return entities.GetAllCategories();
        }

        public List<Question> GetAllQuestion()
        {
            return entities.GetAllQuestion();
        }

        public int CreateCategory(Category category)
        {
            int id = category.IdCategory;
            if(!entities.ExistCategory(category.IdCategory))
            {
                if (category.IdCategory == -1)
                {
                    id = entities.AddCategory(category);
                }
                else
                {
                    entities.UpdateCategory(category);
                }
            }
            return id;
        }

        public void DeteleCategory(int index)
        {
            entities.DeleteCategory(index);
        }

        public int GetNumberOfQuestionInCategory(Category cate)
        {
            return entities.GetNumberOfQuestionInCategory(cate.IdCategory);
        }
    }
}
