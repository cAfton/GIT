using System;

namespace Task12
{
    internal class Program
    {
        public delegate List<int> Numbers(List<int> list);

        public static List<int> PairNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static List<int> NotPairNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 != 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }
        

        public static List<int> SimpleNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                bool isimple = true;
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        isimple = false;
                        break;
                    }
                }
                if (isimple)
                {
                    result.Add(item);
                }
            }

            return result;
        }
        

        public static List<int> FibonacciNumbers(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (var item in list)
            {
                if (item < 0)
                {
                    continue;
                }
                double sqrt = Math.Sqrt((5 * item * item) + 4);
                if (sqrt == Math.Floor(sqrt))
                {
                    result.Add(item);
                }
                sqrt = Math.Sqrt((5 * item * item) - 4);
                if (sqrt == Math.Floor(sqrt))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            Numbers numbers = null;

            numbers = PairNumbers;
            numbers += NotPairNumbers;
            numbers += SimpleNumbers;
            numbers += FibonacciNumbers;

            List<int> list = new List<int> { 1, 2, 100, 3, 4, 5, -5, 6, 7, 3, 4, 5, 3, 2, 4, 34, 3, 5, 89, 90, 4, 6, 3, 5, 3, 4, 6 };

            foreach (Numbers item in numbers.GetInvocationList())
            {
                List<int> result = item(list);
                foreach (var item1 in result)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine();
            }


            Action<DateTime> TimeAction = (time) =>
            {
                Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
            };

            TimeAction(DateTime.Now);

            Action<DateTime> DateAction = (time) =>
            {
                Console.WriteLine($"{time.Day}/{time.Month}/{time.Year}");
            };

            DateAction(DateTime.Now);

            Action<DateTime> DayAction = (time) =>
            {
                Console.WriteLine($"{time.DayOfWeek}");
            };

            DayAction(DateTime.Now);


            Func<(double, double), double> Triangle = (parameters) =>
            {
                return parameters.Item1 * parameters.Item2 * 0.5;
            };

            Console.WriteLine(Triangle((2, 5)));

            Func<(double, double), double> Rectangle = (parameters) =>
            {
                return parameters.Item1 * parameters.Item2;
            };

            Console.WriteLine(Rectangle((2, 5)));

        }
    }
}
