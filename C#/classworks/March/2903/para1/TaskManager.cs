using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    internal class TaskManager
    {
        public string Name { get; set; }
        public List<para1.Task> Tasks { get; set; }
        public TaskManager(string name) 
        {
            Name = name;
            Tasks = new List<para1.Task>();
        }
        public void NewTask (para1.Task task)
        {
            Tasks.Add (task);
        }
        public void UpdateTask (int ID, para1.Task task)
        {
            var tmpTask = Tasks.Find(elem => elem.TaskNumber == ID);
            if (tmpTask != null)
            {
                tmpTask = task;
            }

        }
        public void DeleteTask(int ID)
        {
            if (Tasks.Remove(Tasks.Find(elem => elem.TaskNumber == ID))) Console.WriteLine("Deleted");
        }
        public void SearchTask(int ID)
        {
            if (Tasks.Any(elem => elem.TaskNumber == ID)) Console.WriteLine(Tasks.Find(elem => elem.TaskNumber == ID).ToString());
        }
        public override string ToString()
        {
            string tmp = Name;
            foreach (var item in Tasks)
            {
                tmp += item.ToString();
            }
            return tmp;
        }
    }
}
