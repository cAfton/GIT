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

        public QuizType(string name)
        {
            Name = name;
            LoadQuestions($"{name}.json");
        }
        public void LoadQuestions(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            quizzis = JsonSerializer.Deserialize<List<Quiz>>(jsonString);
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
