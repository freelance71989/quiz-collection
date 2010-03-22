using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class User
    {
        private int idUser;
        private String name;
        private DateTime birthday;
        private String image;
        private List<Score> scores;
        private String aboutMe;
        private DateTime since;

        public User() { }

        public User(String name, DateTime birthday, String image, String aboutMe)
        {
            this.name = name;
            this.birthday = birthday;
            this.since = new DateTime();
            this.image = image;
            this.scores = new List<Score>();
            this.aboutMe = aboutMe;
        }

        public User(int idUser, String name, DateTime birthday, DateTime since, String image, List<Score> scores, String aboutMe, Boolean erase)
        {
            this.idUser = idUser;
            this.name = name;
            this.birthday = birthday;
            this.aboutMe = aboutMe;
            this.since = since;
            this.image = image;
            this.scores = scores;
        }

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDay
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public String AboutMe
        {
            get { return aboutMe; }
            set { aboutMe = value; }
        }

        public String Image
        {
            get { return image; }
            set { image = value; }
        }

        internal List<Score> Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        public DateTime Since
        {
            get { return since; }
            set { since = value; }
        }
    }
}
