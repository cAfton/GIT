namespace Acts
{
    public delegate void Taske(string taskName);
    public class Student
    {
        public string Name { get; set; }

        public void doTask(string taskName)
        {
            Random rnd = new Random(); 
            Console.WriteLine($"Im {Name}. Ive done {taskName} for mark {rnd.Next() % 13}");
        } 
    }

    public class Teacher
    {
        public string Name { get; set;}

        public event Taske StartWork;
        public void GiveTask(string taskName)
        {
            Console.WriteLine($"Im {Name}. Gave {taskName} task");
            StartWork(taskName)
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> p34 = new List<Student>() {
                new Student {Name = "Oleksii" },
                new Student {Name = "Nazar1" },
                new Student {Name = "Nazar2" },
                new Student {Name = "Nazar3" },
                new Student {Name = "Viktoriia" },
                new Student {Name = "Markian" },
                new Student {Name = "Danilo" },
                new Student {Name = "Matvii" },
                new Student {Name = "Maksim" },
                new Student {Name = "Karolina" },
                new Student {Name = "Sofia" }
            };

            Teacher Yura = new Teacher() { Name = "Yura" };

            foreach (var item in p34)
            {
                Yura.StartWork += item.doTask;
            }
            Yura.GiveTask("task");
        }
    }
}
