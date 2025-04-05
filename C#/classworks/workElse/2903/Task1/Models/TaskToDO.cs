using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{ 
    public enum Priority
    {
        High,
        Medium,
        Low
    }
    public class TaskToDO
    {
        public string Name {  get; set; }
        public string Description { get; set; }

        public Priority TaskPriority {  get; set; }

        public DateTime DeadLine {  get; set; }
        

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Description: {Description}\n" +
                $"Priority: {TaskPriority}\n" +
                $"Dead line: {DeadLine}\n";
        }
    }
}
