using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Quiz.Program_matirials.Users;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public class QuizType
    {
        public string Name;
        private List<Quiz> quizzis;
        public int LastScore;
        public List<User> Top20 = new List<User>();

        public void AddNewToTop(User user)
        {
            Top20.Add(user);
            if(Name == "History")
            {
                Top20 = Top20.OrderBy(elem => elem.BestOfHistory).ToList();
            }
            else if (Name == "Biology")
            {
                Top20 = Top20.OrderBy(elem => elem.BestOfBiology).ToList();
            }
            else if (Name == "Geography")
            {
                Top20 = Top20.OrderBy(elem => elem.BestOfGeography).ToList();
            }
            if (Top20.Count > 20)
            {
                Top20.RemoveRange(20, Top20.Count - 20);
            }

        }
        public QuizType(string name)
        {
            Name = name;
            LoadQuestions($"{name}.json");


        }
        public void LoadQuestions(string filePath)
        {
            string readFromFile = File.ReadAllText(filePath);
            var tmp = JsonConvert.DeserializeObject<List<Quiz>>(readFromFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            quizzis = tmp;
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
