namespace task_rxcjyfgkv
{
    internal class Program
    {
        
        static void print<T>(List<T> list)
        {
            list.ForEach(x => Console.WriteLine(x));
        }
        static void Main(string[] args)
        {
            if (false)
            {
                #region task1
                List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
                Console.WriteLine("Enter choice");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        print(list); break;
                    case 2:
                        list.ForEach(x => { if (x % 2 == 0) Console.WriteLine(x); }); break;
                    case 3:
                        list.ForEach(x => { if (x % 2 == 1) Console.WriteLine(x); }); break;
                    case 4:
                        Console.WriteLine("n:"); int n = int.Parse(Console.ReadLine()); list.ForEach(x => { if (x > n) Console.WriteLine(x); }); break;
                    case 5:
                        Console.WriteLine("n1:\nb2:");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = int.Parse(Console.ReadLine());
                        List<int> ints5 = list.Where(x => x > n1 && x < n2).ToList();
                        print(ints5);
                        break;
                    case 6:
                        List<int> ints6 = list.Where(x => x % 7 == 0).OrderBy(x => x).ToList();
                        print(ints6);
                        break;
                    case 7:
                        List<int> ints7 = list.Where(x => x % 8 == 0).OrderByDescending(x => x).ToList();
                        print(ints7);
                        break;
                    default:
                        break;
                }
                #endregion
            }

            List<string> cities = new List<string>();
            Console.WriteLine("Enter choice");
            int choice2 = int.Parse(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    print(cities);
                    break;
                default:
                    break;
            }


        }
    }
}
