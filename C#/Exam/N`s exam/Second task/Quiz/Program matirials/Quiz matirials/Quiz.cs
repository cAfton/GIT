using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public class Quiz
    {
        //private string QuestionType;
        //private string Text;
        //private string FirstOption;
        //private string SecondOption;
        //private string CorrectOption;

        public string QuestionType { get; set; }
        public string Text { get; set; }
        public string FirstOption { get; set; }
        public string SecondOption { get; set; }
        public string CorrectOption { get; set; }

        public bool AskAQuestionAndCheckTheAnswer()
        {
            Console.WriteLine(Text);

            List<string> options = new List<string> { FirstOption, SecondOption, CorrectOption };

            Random rng = new Random();
            int n = options.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1); 
                string tmp = options[k];
                options[k] = options[n];
                options[n] = tmp;
            }

            int tmpCorrect = 0;
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
                if (options[i] == CorrectOption)
                    tmpCorrect = i;
            }

            int choice = int.Parse( Console.ReadLine() );
            if(choice == tmpCorrect + 1)
            {
                return true;
            }
            return false;
        }
    }
}
