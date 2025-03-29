using Task1.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Task1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            string json;
            string jsonFromFile = File.ReadAllText("Tasks.json");
            Dictionary<string, TaskMeneger> Tasks = JsonConvert.DeserializeObject<Dictionary<string, TaskMeneger>>(jsonFromFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            while (true)
            {
                Console.WriteLine("1 - Add new list\n2 - Add new task\n3 - Update task\n4 - Delete task\n5 - Print all lists\n6 - Print one list \n7 - Find task in list\n8 - Find task in all lists\n9 - Save all\n0 - exit");
                switch(Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter name of new list: ");
                        Tasks.Add(Console.ReadLine(), new TaskMeneger());
                        break;
                    case "2":

                        foreach (var item in Tasks)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("\nEnter name of list: ");
                        string listToAdd = Console.ReadLine();

                        TaskToDO newTask = new TaskToDO();
                        Console.WriteLine("\nEnter name of task: ");
                        newTask.Name = Console.ReadLine();

                        Console.WriteLine("\nEnter description: ");
                        newTask.Description = Console.ReadLine();

                        Console.WriteLine("\nEnter priority:\n 1 - High\n2 - Medium\n3 - Low");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                newTask.TaskPriority = Priority.High;
                                break;
                            case "2":
                                newTask.TaskPriority = Priority.Medium;
                                break;
                            case "3":
                                newTask.TaskPriority = Priority.Low;
                                break;
                            default:
                                newTask.TaskPriority = Priority.Low;
                                break;
                        }

                        Console.WriteLine("\nEnter dead line: ");
                        newTask.DeadLine = DateTime.Parse(Console.ReadLine());


                        try
                        {
                            Tasks[listToAdd].newTask(newTask);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        foreach (var item in Tasks)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("\nEnter name of list: ");
                        try
                        {
                            Tasks[Console.ReadLine()].UpdateTask();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        foreach (var item in Tasks)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("\nEnter name of list: ");
                        try
                        {
                            Tasks[Console.ReadLine()].DeleteTask();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "5":
                        foreach (var item in Tasks)
                        {
                            Console.WriteLine($"List: {item.Key}");
                            foreach(var taske in item.Value.TaskList)
                            {
                                Console.WriteLine(taske);
                            }
                        }
                        break;
                    case "6":
                        foreach (var item in Tasks)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("\nEnter name of list: ");
                        try
                        {
                            foreach(var item in Tasks[Console.ReadLine()].TaskList)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "7":
                        foreach (var item in Tasks)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("\nEnter name of list: ");
                        try
                        {
                            var found = Tasks[Console.ReadLine()].SearchTask();
                            Console.WriteLine((found == null ? "Didnt find" : found));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "8":
                        foreach (var item in Tasks)
                        {
                            string list = item.Key;
                            var found = item.Value.SearchTask();
                            if (found != null)
                            {
                                Console.WriteLine($"List: {list}\nTask: {found}");
                                break;
                            }
                        }
                        break;
                    case "9":
                        json = JsonConvert.SerializeObject(Tasks, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                        File.WriteAllText("Tasks.json", json);
                        break;
                    case "0":
                        json = JsonConvert.SerializeObject(Tasks, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                        File.WriteAllText("Tasks.json", json);
                        return;
                }
            }

            
        }
    }
}
