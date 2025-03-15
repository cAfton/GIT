namespace wgwwv
{

    public class Student
    {
        public string Name { get; set; }

        public string Surname {  get; set; }

        public int Age { get; set; }

        public string School { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Age}, {School}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> { 
                new Student {Name = "ddd", Age = 5, School="sss", Surname = "aaa"}
            };
            Console.WriteLine("Write choice");
            int choice = int.Parse( Console.ReadLine() );

            switch (choice)
            {
                case 1:
                    students.ForEach(x => Console.WriteLine(x.ToString()));
                    break;
                case 2:
                    List<Student> studentsBoris = students.Where(x => x.Name == "Boris").ToList();
                    studentsBoris.ForEach(x => Console.WriteLine(x.ToString()));
                    break;
                case 3:
                    List<Student> studentsBro = students.Where(x => x.Surname.StartsWith("Bro")).ToList();
                    studentsBro.ForEach(x => Console.WriteLine(x.ToString()));
                    break;
                case 4:
                    int age = int.Parse( Console.ReadLine() );
                    List<Student> students19 = students.Where(x => x.Age > 19).ToList();
                    students19.ForEach(x => Console.WriteLine(x.ToString()));
                    break;
                default:
                    break;
            }
        }
    }
}
