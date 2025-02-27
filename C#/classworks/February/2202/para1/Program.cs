using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            for (int i = 0; i < size; i++) {
                arr.Add(int.Parse(Console.ReadLine()));
            }

            Func<List<int>, (int, int)> max = (ara) => {
                int t = ara[0];
                int indexT = 0, index = 0;
                foreach (var item in ara)
                {
                    if (item > t) 
                    {
                        t = item;
                        index = indexT;
                    }
                    indexT++;
                }

                return (t, index);
            };

            var res = max(arr);

            Console.WriteLine(res.Item1);
            Console.WriteLine(res.Item2);

            Console.ReadLine();
        }
    }
}
