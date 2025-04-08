using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public static class QuizMenu
    {
        private static List<QuizType> Quizzis = new List<QuizType>();
        public static void MeinMenu()
        {
            Quizzis.Add(new QuizType("History"));
            Quizzis.Add(new QuizType("Geography"));
            Quizzis.Add(new QuizType("Biology"));


            while (true)
            {
                Console.Write("Select the knowledge section of the quiz. ( 1)\n\"History\", \n2)\"Geography\", \n3)\"Biology\", \n4)Exit:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var tmp1 = Quizzis.Find(elem => elem.Name == "History");
                        tmp1.StartQuiz();
                        break;
                    case 2:
                        var tmp2 = Quizzis.Find(elem => elem.Name == "Geography");
                        tmp2.StartQuiz();
                        break;
                    case 3:
                        var tmp3 = Quizzis.Find(elem => elem.Name == "Biology");
                        tmp3.StartQuiz();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }

        public static void ViewTheResultsOfYourPastQuizzes()
        {
            foreach (var item in Quizzis)
            {
                Console.WriteLine(item.LastScore);
            }
        }

    }
}
