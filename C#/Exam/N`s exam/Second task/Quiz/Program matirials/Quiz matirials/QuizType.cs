using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public class QuizType
    {
        public string Name;
        private List<Quiz> quizzis;
        public int LastScore;

        public static List<Quiz> LoadQuestions(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Quiz>();
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Quiz>>(jsonString);
        }
        public int StartQuiz()
        {
            LastScore = 0;
            foreach (var item in quizzis)
            {
                if (item.AskAQuestionAndCheckTheAnswer())
                {
                    LastScore++;
                }
            }
            return LastScore;
        }
    }
}
