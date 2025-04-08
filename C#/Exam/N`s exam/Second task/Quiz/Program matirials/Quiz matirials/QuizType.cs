using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public class QuizType
    {
        public string Name;
        private List<Quiz> quizzis;
        public int LastScore;

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
        }
    }
}
