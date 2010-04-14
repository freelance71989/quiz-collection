using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuizLibrary.Data;

namespace QuizLibrary
{
    class Entities
    {
        private Data.DataBase data;

        public Entities()
        {
            data = new QuizLibrary.Data.DataBase();
        }

        //question

        public int AddQuestion(Question question)
        {
            QuestionEntity qe = new QuestionEntity();
            qe.Question = question.QuestionText;
            qe.Category = data.CategoryEntities.First(x => x.Category == question.Category.CategoryText);
            qe.Difficulty = Convert.ToByte(question.Difficulty);
            qe.Image = question.Image;
            qe.Sound = question.Sound;
            data.AddToQuestionEntities(qe);
            data.SaveChanges();
            foreach (var ans in question.Answers)
                this.AddAnswer(ans, qe.IdQuestion);
            data.SaveChanges();

            return qe.IdQuestion;
        }

        public void UpdateQuestion(Question question)
        {
            QuestionEntity qe = data.QuestionEntities.First(x => x.IdQuestion == question.IdQuestion);
            qe.Question = question.QuestionText;
            qe.Category = data.CategoryEntities.First(x => x.Category == question.Category.CategoryText);
            qe.Difficulty = Convert.ToByte(question.Difficulty);
            qe.Answers.Clear();
            foreach (var ans in question.Answers)
                this.AddAnswer(ans, qe.IdQuestion);
            qe.Image = question.Image;
            qe.Sound = question.Sound;

            data.SaveChanges();
        }

        public Question GetQuestion(int idQuestion) 
        {
            var questEntity = data.QuestionEntities.First(x => x.IdQuestion == idQuestion);
            questEntity.CategoryReference.Load();

            Category category = GetCategory(questEntity.Category.IdCategory);
            
            List<Answer> answers = GetAnswers(idQuestion);
            Question res = new Question();

            res.IdQuestion = idQuestion;
            res.QuestionText = questEntity.Question;
            res.Category = category;
            res.Difficulty = questEntity.Difficulty;
            res.Answers = answers;
            res.Image = questEntity.Image;
            res.Sound = questEntity.Sound;

            return res;
        }
        public List<Question> GetAllQuestion()
        {
            List<int> index = data.QuestionEntities.Select(x => x.IdQuestion).ToList<int>();
            List<Question> questions = new List<Question>();
            foreach (int e in index)
            {
                questions.Add(GetQuestion(e));
            }
            return questions;
        }

        public int LastIdQuestion()
        {
            return data.QuestionEntities.Max(x => x.IdQuestion);
        }

        public Boolean ExistQuestion(int idQuestion)
        {
            return data.QuestionEntities.Count(x => x.IdQuestion == idQuestion) != 0;
        }

        public void DeleteQuestion(int idQuestion)
        {
            QuestionEntity qe = data.QuestionEntities.Include("Answers").First(x => x.IdQuestion == idQuestion);
            //POTO SANGRE CON CRECES!!!!
            foreach (var a in qe.Answers.ToArray())
            {
                DeleteAnswer(a.IdAnswer);
            }
            data.DeleteObject(qe);
            data.SaveChanges();
        }

        //answer

        public int AddAnswer(Answer answer, int idQuestion)
        {
            AnswerEntity ae = new AnswerEntity();
            ae.Answer = answer.AnswerText;
            ae.Correct = answer.Correct;
            ae.Question = data.QuestionEntities.First(x => x.IdQuestion == idQuestion);
            
            data.SaveChanges();

            return ae.IdAnswer;
        }

        public List<Answer> GetAnswers(int IdQuestion)
        {
            List<Answer> res= new List<Answer>();
            var answers = data.AnswerEntities.Where(x => x.Question.IdQuestion == IdQuestion);
            foreach (var answer in answers)
            {
                Answer answerTemp = new Answer();
                answerTemp.IdAnswer = answer.IdAnswer;
                answerTemp.AnswerText = answer.Answer;
                answerTemp.Correct = answer.Correct;
                res.Add(answerTemp);
            }
            return res;

        }
        public void DeleteAnswer(int idAnswer)
        {
            AnswerEntity ae = data.AnswerEntities.First(x => x.IdAnswer == idAnswer);
            data.DeleteObject(ae);
            data.SaveChanges();
        }

        //category
           
        public int AddCategory(Category category)
        {
            CategoryEntity ce = new CategoryEntity();
            ce.Category = category.CategoryText;
            ce.Description = category.Description;
            data.AddToCategoryEntities(ce);
            data.SaveChanges();
            return ce.IdCategory;
        }

        public void UpdateCategory(Category category)
        {
            CategoryEntity ce = data.CategoryEntities.First(x => x.IdCategory == category.IdCategory);
            ce.Category = category.CategoryText;
            ce.Description = category.Description;
            data.SaveChanges();
        }

        public Category GetCategory(String category)
        {
            Category res = new Category();
            var ce = data.CategoryEntities.First(x => x.Category == category);
            res.IdCategory = ce.IdCategory;
            res.CategoryText = ce.Category;
            res.Description = ce.Description;

            return res;
        }

        public Category GetCategory(int idCategory)
        {
            Category res = new Category();
            var ce = data.CategoryEntities.First(x => x.IdCategory == idCategory);
            res.IdCategory = ce.IdCategory;
            res.CategoryText = ce.Category;
            res.Description = ce.Description;

            return res;
        }

        public Boolean ExistCategory(int idCategory) 
        {
            return data.CategoryEntities.Count(x => x.IdCategory == idCategory) != 0;
        }

        public Boolean ExistCategory(String category)
        {
            return data.CategoryEntities.Count(x => x.Category.ToLower() == category.ToLower()) != 0;
        }

        public List<Category> GetAllCategories()
        {
            return data.CategoryEntities.Select(x => new Category()
            {
                IdCategory = x.IdCategory,
                CategoryText = x.Category,
                Description = x.Description,
            }).ToList<Category>();
        }

        public void DeleteCategory(int index)
        {
            CategoryEntity ce = data.CategoryEntities.First(x => x.IdCategory == index);
            data.DeleteObject(ce);
            data.SaveChanges();
        }

        //user

        public int AddUser(User user) 
        {
            UserEntity ue = new UserEntity();
            ue.Name = user.Name;
            ue.Birthday = user.BirthDay;
            ue.Image = user.Image;
            ue.AboutMe = user.AboutMe;
            ue.Since = user.Since;
            data.SaveChanges();

            return ue.IdUser;
        }

        public User GetUser(int idUser)
        {
            UserEntity ue = data.UserEntities.First(x => x.IdUser == idUser);
            List<Score> scores = GetScores(ue.IdUser);

            return new User()
            {
                IdUser = ue.IdUser,
                Name = ue.Name,
                BirthDay = (DateTime)ue.Birthday,
                Image = ue.Image,
                AboutMe = ue.AboutMe,
                Since = ue.Since,
                Scores = scores
            };
        }

        //score

        public void AddScore(Score score)
        {
            ScoreEntity se = new ScoreEntity();
            se.IdUser = score.IdUser;
            se.IdCategory = score.IdCategory;
            se.Correct = score.Correct;
            se.Total = score.Total;

            data.AddToScoreEntities(se);
        }

        public void UpdateScore(Score score)
        {
            ScoreEntity se = data.ScoreEntities.First(x => x.IdUser == score.IdUser && x.IdCategory == score.IdCategory);
            se.Total = score.Total;
            se.Correct = score.Correct;
        }

        public List<Score> GetScores(int idUser)
        {
            List<Score> res = new List<Score>();
            foreach (var a in data.UserEntities.First(x => x.IdUser == idUser).Scores.ToList())
            {
                res.Add(new Score
                {
                    Correct = a.Correct,
                    IdCategory = a.IdCategory,
                    IdUser = a.IdUser,
                    Total = a.Total
                });
            }
            return res;
        }

        public Score GetScore(int idUser, int idCategory)
        {
            ScoreEntity se = data.ScoreEntities.First(x => x.IdUser == idUser && x.IdCategory == idCategory);

            return new Score()
            {
                IdCategory = idCategory,
                IdUser = idUser,
                Total = se.Total,
                Correct = se.Correct
            };
        }

        public Boolean ExistScore(int idUser, int idCategory)
        {
            return data.ScoreEntities.Count(x => x.IdUser == idUser && x.IdCategory == idCategory) != 0;
        }
 
    }
}
