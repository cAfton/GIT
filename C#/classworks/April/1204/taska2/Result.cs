using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska2
{
    public class Result
    {
        public DateTime Time { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public TypesOfQuiz TypesOfQuiz { get; set; }
        public HardLevel HardLevel { get; set; }
        public int NumberOfQestions { get; set; }
    }
}
