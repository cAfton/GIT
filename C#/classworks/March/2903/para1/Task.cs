using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    public enum Priorities
    {
        Low,
        Medium,
        High
    };
    public class Task
    {
        public int TaskNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool isDone { get; set; }
        public Priorities Priority { get; set; }
        public Task(int taskNumber, string name, string description, DateTime deadline, bool isdone, Priorities priority) 
        {
            TaskNumber = taskNumber;
            Name = name;
            Description = description;
            Deadline = deadline;
            isDone = isdone;
            Priority = priority;
        }

        public void CompleteTask()
        {
            isDone = true;
        }

        public override string ToString()
        {
            return $"{TaskNumber}){Name}///{Description}: {Deadline} [{isDone}]\n{Priority.ToString()}";
        }
    }
}
