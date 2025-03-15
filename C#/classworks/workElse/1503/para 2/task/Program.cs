namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "apple", "banana" };
            Console.WriteLine("1 - >\n2 - <");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    list = list.OrderBy(x => x.Length).ToList();
                    break;
                case 2:
                    list = list.OrderByDescending(x => x.Length).ToList();
                    break;
                default:
                    break;
            }


            list.OrderBy(elem => elem.Length).ToList();
            list.ForEach(elem => Console.WriteLine(elem));

        }
    }
}
