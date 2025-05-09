using Newtonsoft.Json;
using Quiz.Program_matirials.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public static class QuizMenu
    {
        private static List<QuizType> Quizzis = new List<QuizType>();
        public static void Start()
        {
            Quizzis.Add(new QuizType("History"));
            Quizzis.Add(new QuizType("Geography"));
            Quizzis.Add(new QuizType("Biology"));

        }
        public static void MeinMenu()
        {
            while (true)
            {
                Console.Write("Select the knowledge section of the quiz. ( 1)\n\"History\", \n2)\"Geography\", \n3)\"Biology\", \n4)Exit:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var tmp1 = Quizzis.Find(elem => elem.Name == "History");
                        tmp1.StartQuiz();
                        tmp1.AddNewToTop(UsersData.user);
                        break;
                    case 2:
                        var tmp2 = Quizzis.Find(elem => elem.Name == "Geography");
                        tmp2.StartQuiz();
                        tmp2.AddNewToTop(UsersData.user);

                        break;
                    case 3:
                        var tmp3 = Quizzis.Find(elem => elem.Name == "Biology");
                        tmp3.StartQuiz();
                        tmp3.AddNewToTop(UsersData.user);
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }

        }

        public static void PrintSup20(string name)
        {
            var tmp = Quizzis.Find(elem => elem.Name == name);
            int i = 0;
            if(tmp.Top20.Count != null)
            {
                foreach (var item in tmp.Top20)
                {
                    i++;
                    Console.WriteLine($"{i}){item.Login}");
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
