namespace ConsoleApp1
{
    internal class Program
    {
        public static IEnumerable<T> FilterByTwoCrit<T> (IEnumerable<T> input, Func<T, bool> Pred1, Func<T, bool> Pred2)
        {
            List<T> list = new List<T> ();
            for (int i = 0; i < input.Count(); i++)
            {
                if (Pred1(input.ElementAt(i)) && Pred2(input.ElementAt(i)))
                {
                    list.Add (input.ElementAt(i));
                }
            }
            return list;
        }
        public static T MinNum<T>(T n1, T n2, T n3) where T: IComparable<T>
        {
            T min = n1;
            if(min.CompareTo(n2) == 1)
            {
                min = n2;
                if(min.CompareTo(n3) == 1)
                {
                    min = n3;
                }
            }
            else if(min.CompareTo(n3) == 1)
            {
                min = n3;
            }
            return min;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(MinNum(1, 3 ,0));
            //Console.WriteLine(MinNum(1, 3 ,5));
            //Console.WriteLine(MinNum(2, -1 ,6));

            List<int> list = new List<int>() { 11, 3, 2, 23, 4, 3, 5, 4, 4, 34, 8, 23, 4, 567, 54, 1 };
            List<string> listStr = new List<string>() { "Hi", "love", "want", "Tonight", "Minecraft", "Dota", "fooo", "I", "you", "<3"};

            List<int> NList = FilterByTwoCrit<int>(list, (elem) => { return (elem < 10 && elem > 0); }, (elem) => { return elem % 2 == 0; }).ToList();

            List<string> NListStr = FilterByTwoCrit<string>(listStr, (elem) => { return (elem.Length < 10 && elem.Length > 0); }, (elem) => { return elem.Length % 2 == 0; }).ToList();

            foreach (var item in NListStr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
