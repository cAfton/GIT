using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;

namespace para1
{



    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaskManager> list = new List<TaskManager>();
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            string json = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            File.WriteAllText("Tasks.json", json);

            

            while (true)
            {
                Console.WriteLine("Menu: 1)new list\n2)Add task\n3)edit task\n4)delete\n5)print\n6)find\n7)save");
                int choice = int.Parse(Console.ReadLine());
                string tmpName;
                switch (choice)
                {
                    case 1:
                        tmpName = Console.ReadLine();
                        list.Add(new TaskManager(tmpName));
                        break;
                    case 2:
                        tmpName = Console.ReadLine();
                        int tmpTaskNumber = int.Parse(Console.ReadLine());
                        string tmpname = Console.ReadLine();
                        string tmpDescription = Console.ReadLine();
                        DateTime tmpDeadline = DateTime.Parse(Console.ReadLine());
                        string tmpIsDone = Console.ReadLine();
                        string tmpPriorityS = Console.ReadLine();
                        Priorities tmpPriorityP = Priorities.Low;
                        switch (tmpPriorityS)
                        {
                            case "Low":
                                tmpPriorityP = Priorities.Low;
                                break;
                            case "Medium":
                                tmpPriorityP = Priorities.Medium;
                                break;
                            case "High":
                                tmpPriorityP = Priorities.High;
                                break;
                            default:
                                break;
                        }
                        list.Find(elem => elem.Name == tmpName).NewTask(new para1.Task(tmpTaskNumber, tmpname, tmpDescription, tmpDeadline, (tmpIsDone == "yes")? true:false, tmpPriorityP));
                        break;
                    case 3:
                        tmpName = Console.ReadLine();
                        int tmpTaskNumber2 = int.Parse(Console.ReadLine());
                        string tmpname2 = Console.ReadLine();
                        string tmpDescription2 = Console.ReadLine();
                        DateTime tmpDeadline2 = DateTime.Parse(Console.ReadLine());
                        string tmpIsDone2 = Console.ReadLine();
                        string tmpPriorityS2 = Console.ReadLine();
                        Priorities tmpPriorityP2 = Priorities.Low;
                        switch (tmpPriorityS2)
                        {
                            case "Low":
                                tmpPriorityP = Priorities.Low;
                                break;
                            case "Medium":
                                tmpPriorityP = Priorities.Medium;
                                break;
                            case "High":
                                tmpPriorityP = Priorities.High;
                                break;
                            default:
                                break;
                        }
                        
                        list.Find(elem => elem.Name == tmpName).UpdateTask(int.Parse(Console.ReadLine()), new para1.Task(tmpTaskNumber2, tmpname2, tmpDescription2, tmpDeadline2, (tmpIsDone2 == "yes")? true:false, tmpPriorityP2));


                        break;
                    case 4:
                        tmpName = Console.ReadLine();
                        list.Find(elem => elem.Name == tmpName).DeleteTask(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        foreach (var item in list)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    break;
                    case 6:
                        tmpName = Console.ReadLine();
                        list.Find(elem => elem.Name == tmpName).SearchTask(int.Parse(Console.ReadLine()));
                        break;
                    case 7:

                        string jsonFromFile = File.ReadAllText("file.json");
                        json = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

                        File.WriteAllText("vehicles.json", json);

                        break;
                    default:
                        break;
                }

            }
        }
    }
}
