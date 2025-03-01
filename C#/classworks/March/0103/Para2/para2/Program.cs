namespace para2
{

    public class Employee
    {
        public string name;
        public string position;
        public int salary;
        public string email;

        
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { name = "name1", position = "worker1", salary = 100, email = "someone1"},
                new Employee() { name = "name2", position = "worker2", salary = 200, email = "someone2"},
                new Employee() { name = "name3", position = "worker3", salary = 300, email = "someone3"},
                new Employee() { name = "name4", position = "worker4", salary = 400, email = "someone4"},
                new Employee() { name = "name5", position = "worker5", salary = 500, email = "someone5"},
            };
            while (true)
            {
                Console.WriteLine("1) Add new\n2)Delete\n3)Edit\n4)Serch\n5)Sort");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name");
                        string tmpName = Console.ReadLine();
                        Console.WriteLine("Enter position");
                        string tmpPosition = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        int tmpSalary = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter email");
                        string tmpEmail = Console.ReadLine();
                        list.Add(new Employee() { name = tmpName, position = tmpPosition, salary = tmpSalary, email = tmpEmail });
                        break;
                    case 2:
                        string deleteByName = Console.ReadLine();
                        bool ifDelete = false;
                        foreach (Employee emp in list)
                        {
                            if(emp.name == deleteByName)
                            {
                                ifDelete = list.Remove(emp);
                            }
                        }
                        Console.WriteLine((ifDelete == true) ? "Delete successfully" : "Can not delete");
                        break;
                    case 3:
                        break;

                    case 4:

                    default:
                        break;
                }
            }
        }
    }
}
