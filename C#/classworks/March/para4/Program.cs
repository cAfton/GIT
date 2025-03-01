using System.Reflection;

namespace ConsoleApp2
{

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name {Name}, pos {Position}, sal {Salary}, email {Email}";
        }
    }




    internal class Program
    {
        public static void Edit(string Name, List<Employee> employees)
        {
            var temp = employees.Find(x => x.Name == Name);
            if (temp == null)
            {
                Console.WriteLine($"No enmploye with name {Name}");
                return;
            }
            string propertyNames = "";
            temp.GetType().GetProperties().ToList().ForEach(e => propertyNames += e.Name + ", ");
            Console.WriteLine("Choose what to Edit: " + propertyNames);
            string choise = Console.ReadLine();
            var type = temp.GetType().GetProperty(choise).PropertyType;
            Console.WriteLine("Enter new Value: ");
            string newData = Console.ReadLine();
            temp.GetType().GetProperty(choise).SetValue(temp, Convert.ChangeType(newData, type));
            Console.WriteLine(temp);
            Console.WriteLine();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        public static void Find(List<Employee> employees)
        {
            string props = "";
            employees[0].GetType().GetProperties().ToList().ForEach(e => props += e.Name + ", ");

            Console.WriteLine("Choose by what to Find: " + props);
            string choise = Console.ReadLine();

            Console.WriteLine("Enter what to Find: ");
            string ToFind = Console.ReadLine();

            List<Employee> result = employees.FindAll
                (e =>
                e.GetType().GetProperty(choise).GetValue(e).ToString() == ToFind);

            foreach (Employee emp in result)
            {
                Console.WriteLine(emp);
            }
        }

        public static void Sort(List<Employee> employees)
        {
            string props = "";
            employees[0].GetType().GetProperties().ToList().ForEach(e => props += e.Name + ", ");
            Console.WriteLine("Choose by what to Sort: " + props);
            string choise = Console.ReadLine();
            Console.WriteLine(">/<");
            string howToSort = Console.ReadLine();
            if (howToSort == ">")
            {
                employees = employees.OrderBy(x => x.GetType().GetProperty(choise).GetValue(x)).ToList();
            }
            else
            {
                employees = employees.OrderByDescending(x => x.GetType().GetProperty(choise).GetValue(x)).ToList();
            }
            Console.WriteLine();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { Name = "Name1", Position = "worker1", Salary = 100, Email = "someone1"},
                new Employee() { Name = "Name2", Position = "worker2", Salary = 200, Email = "someone2"},
                new Employee() { Name = "Name3", Position = "worker3", Salary = 300, Email = "someone3"},
                new Employee() { Name = "Name4", Position = "worker4", Salary = 400, Email = "someone4"},
                new Employee() { Name = "Name5", Position = "worker5", Salary = 500, Email = "someone5"},
            };
            while (true)
            {
                Console.WriteLine("1) Add new\n2)Delete\n3)Edit\n4)Serch\n5)Sort");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name");
                        string tmpName = Console.ReadLine();
                        Console.WriteLine("Enter Position");
                        string tmpPosition = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        int tmpSalary = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Email");
                        string tmpEmail = Console.ReadLine();
                        list.Add(new Employee() { Name = tmpName, Position = tmpPosition, Salary = tmpSalary, Email = tmpEmail });
                        break;
                    case 2:
                        string deleteByName = Console.ReadLine();
                        bool ifDelete = false;
                        foreach (Employee emp in list)
                        {
                            if (emp.Name == deleteByName)
                            {
                                ifDelete = list.Remove(emp);
                            }
                        }
                        Console.WriteLine((ifDelete == true) ? "Delete successfully" : "Can not delete");
                        break;
                    case 3:
                        Console.WriteLine("Enter name to edit: ");
                        string name = Console.ReadLine();
                        Edit(name, list);
                        break;

                    case 4:
                        Find(list);
                        break;
                    case 5:
                        Sort(list);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

