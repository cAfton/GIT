using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public static class QuizMenu
    {
        private static List<Quiz> Quizzis;
        public static void MeinMenu()
        {
            while (true)
            {
                Console.Write("Select the knowledge section of the quiz. ( 1)\n\"History\", \n2)\"Geography\", \n3)\"Biology\", \n4)random):");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:


                    default:
                        break;
                }
            }
        }

        private static void StartQuiz(string GameMod)
        {



        }

    }
}
