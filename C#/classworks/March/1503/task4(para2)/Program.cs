namespace task4_para2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"apple", "banana", "cherry", "dog", "elephant", "forest", "guitar", "house", "island", "jungle"};
            Console.WriteLine("1 - by Increasing\n2 - Decreasing");
            switch (Console.ReadLine())
            {
                case "1":
                    list = list.OrderBy(elem => elem.Length).ToList();
                    break;
                case "2":
                    list = list.OrderByDescending(elem => elem.Length).ToList();
                    break;
                default:
                    break;
            }
            list.ForEach(elem => Console.WriteLine(elem));
        }
    }
}
