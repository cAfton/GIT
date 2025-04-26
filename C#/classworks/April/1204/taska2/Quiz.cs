using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska2
{
    public class Quiz
    {
        public string Question { get; set; } = "";
        public string[] Answers { get; set; } = { "", "", "" };
        public int RightAnswer { get; set; } = 0;

        public override string ToString()
        {
            return $"{Question}\n\n1) {Answers[0]}\n2) {Answers[1]}\n3) {Answers[2]}";
        }
    }
}
