using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class Category : IEquatable<Category>
    {
        private int idCategory;
        private String categoryText;
        private String description;

        public Category() { }

        public Category(String categoryText, String description)
        {
            this.idCategory = -1;//???
            this.categoryText = categoryText;
            this.description = description;
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public String CategoryText
        {
            get { return categoryText; }
            set { categoryText = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public void AddCategoryInBD()
        {
            Entities ge = new Entities();
            idCategory = ge.AddCategory(this);
        }

        public override string ToString()
        {
            return this.categoryText;
        }

        #region Miembros de IEquatable<Category>

        public bool Equals(Category other)
        {
            bool res = false;
            if (other != null)
            {
                res = idCategory == other.idCategory;
            }
            return res;
        }

        #endregion
    }
}
