using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Dictionary.Models
{
    public class Quiz
    {
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public int RightAnswer { get; set; }

        public override string ToString()
        {
            return $"{Question}\n\n1) {Answers[0]}\n2) {Answers[1]}\n3) {Answers[2]}";
        }
    }
}
