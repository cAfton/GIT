using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1
{
    public class TaskMeneger
    {

        public List<TaskToDO> TaskList { get; set; } = new List<TaskToDO> { };

        public void newTask(TaskToDO newTask) {
            TaskList.Add(newTask);
        }

        public void UpdateTask() {
            Console.WriteLine("Enter name of task: ");
            string findTask = Console.ReadLine();
            TaskToDO task = TaskList.FirstOrDefault(elem => elem.Name == findTask);
            if (task != null)
            {
                Console.WriteLine("Update:\n1 - Name\n2 - Description\n3 - Priority\n4 - Dead line");
                switch (Console.ReadLine())
                {
                    case "1":
                        task.Name = Console.ReadLine();
                        break;
                    case "2":
                        task.Description = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("New priority:\n1 - High\n2 - Medium\n3 - Low");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                task.TaskPriority = Priority.High;
                                break;
                            case "2":
                                task.TaskPriority = Priority.Medium;
                                break;
                            case "3":
                                task.TaskPriority = Priority.Low;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("enter new dead line: ");
                        task.DeadLine = DateTime.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Task didnt find");
            }
            
        }
        public void DeleteTask()
        {
            Console.WriteLine("Enter name of task: ");
            string findTask = Console.ReadLine();
            TaskList.Remove(TaskList.FirstOrDefault(elem => elem.Name == findTask));
        }

        public TaskToDO SearchTask() {
            Console.WriteLine("Enter name of task: ");
            string findTask = Console.ReadLine();
            return TaskList.FirstOrDefault(elem => elem.Name == findTask);
        }

        public void PrintEverything() {
            TaskList.ForEach(elem => Console.WriteLine(elem));
        }

        public void SortByPriority()
        {
            TaskList.OrderBy(elem => elem.TaskPriority);
        }
        public void SortByDeadLine()
        {
            TaskList.OrderBy(elem => elem.DeadLine);
        }
    }
}
