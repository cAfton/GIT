using System.ComponentModel;


/*

Порахуйте кількість елементів масиву;
*/

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> array1 = new List<int>();
            List<int> array2 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                array1.Add(rand.Next(1, 31));
                array2.Add(rand.Next(1, 11));
            }
            array1.ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();
            array2.ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();

            array1.Except(array2).ToList().ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();

            array1.Intersect(array2).ToList().ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();

            array1.Union(array2).ToList().ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();
            array2.Union(array1).ToList().ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();

            array1.Distinct().ToList().ForEach(elem => Console.Write($"{elem} "));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int accumulator = 1;
            accumulator = array1.Aggregate(1, (x, accumulator) => accumulator * x);
            Console.WriteLine(accumulator);

            Console.WriteLine(array1.Average());
            Console.WriteLine(array1.Min());
            Console.WriteLine(array1.Max());
            Console.WriteLine(array1.Sum(x => x % 2 == 0 ? x : 0));
            Console.WriteLine(array1.Sum());
            Console.WriteLine(array1.Count(x => x % 7 == 0 && x > 5));
            Console.WriteLine(array1.Count(x => x % 9 == 0));
            Console.WriteLine(array1.Count());
        }
    }
}
