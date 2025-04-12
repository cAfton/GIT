using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska2
{
    public class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public List<History> HistoryOfQuizes { get; set; } = new List<History>();

        public User() { }

        public void AddHistory(TypesOfQuiz type, HardLevel level, int score)
        {
            HistoryOfQuizes.Add(new History() { Date = DateTime.Now, TypeOfQuiz = type, Level = level, Score = score });
        }


        public int getMaxScore()
        {
            return HistoryOfQuizes.Max(elem => elem.Score);
        }

        public override string ToString()
        {
            return $"Login: {Login}\nMax Score: {getMaxScore()}";
        }

    }
}
