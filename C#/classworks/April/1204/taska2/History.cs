using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska2
{
    public enum TypesOfQuiz
    {
        History,
        Geografy,
        Biology,
        Mixed
    }

    public enum HardLevel
    {
        Easy,
        Medium,
        Hard
    }
    public class History
    {
        public TypesOfQuiz TypeOfQuiz { get; set; }

        public HardLevel Level { get; set; }

        public int Score { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Time: {Date}\nQuiz: {TypeOfQuiz}\nLevel: {Level}\nScore: {Score}/15";
        }
    }
}
