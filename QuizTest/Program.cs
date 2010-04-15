using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuizLibrary;

namespace QuizTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Logica log = new Logica();

            Question que = log.GetAllQuestion().First();

            log.DeleteQuestion(que);
        }
    }
}
