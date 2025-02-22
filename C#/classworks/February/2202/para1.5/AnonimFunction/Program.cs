using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnonimFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                #region FuncEven/NotEven
                Func<int, string> Even = (elem) =>
                {
                    if (elem % 2 == 1)
                    {
                        return "Not PaReNe";

                    }
                    else { return "PaReNe"; }

                };
                Console.WriteLine(Even(5));
                Console.ReadLine();
                #endregion

                #region Filter
                Random rand = new Random();
                List<int> list = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    list.Add(rand.Next() % 10 - 5);
                }

                Func<List<int>, List<int>> Filter = (arr) =>
                {
                    List<int> arrFiltered = new List<int>();
                    foreach (var item in arr)
                    {
                        if (item % 2 == 1)
                        {
                            arrFiltered.Add(item);
                        }
                    }
                    return arrFiltered;
                };

                foreach (var item in Filter(list))
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
                #endregion

                #region Power

                Func<int, int, double> pow = (item1, item2) =>
                {
                    return Math.Pow(item1, item2);
                };

                Console.WriteLine(pow(32, -2));
                Console.ReadLine();
                #endregion
            }
        }
    }
}
