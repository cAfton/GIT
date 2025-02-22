using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            Console.WriteLine("\ntask 1\n");
            Func<int, string> isEvenNum = (num) => {
                if (num % 2 == 0)
                {
                    return "Pair";
                }
                return "Not pair";
            };

            Console.WriteLine(isEvenNum(1));
            Console.WriteLine(isEvenNum(2));
            #endregion

            #region task 7
            Console.WriteLine("\ntask 7\n");
            Func<List<int>, List<int>> findNotEvenNum = (arr) =>
            {
                List<int> list = new List<int>();
                foreach (var item in arr)
                {
                    if (item % 2 == 1)
                    {
                        list.Add(item);
                    }
                }

                return list;
            };

            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next() % 10);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            numbers = findNotEvenNum(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            #endregion

            #region task 3
            Console.WriteLine("\ntask 3\n");

            Func<int, int, double> Power = (number, powe) =>
            {
                return Math.Pow(number, powe);
            };

            Console.WriteLine(Power(2 ,3));
            #endregion

            Console.ReadLine();
        
        }
    }
}
