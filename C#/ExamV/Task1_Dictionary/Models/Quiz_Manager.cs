using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Dictionary.Models
{
    public class Quiz_Manager
    {
        public List<Quiz> Quizes_Easy { get; set; }
        public List<Quiz> Quizes_Medium { get; set; }
        public List<Quiz> Quizes_Hard { get; set; }
    }
}
