using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArr;
            Console.Write("Enter size of array: ");

            sizeOfArr = int.Parse(Console.ReadLine());
            sizeOfArr = Math.Abs(sizeOfArr);

            if (sizeOfArr == 0) { return; }

            int[] array = new int[sizeOfArr];

            array[0] = int.Parse(Console.ReadLine());

            int min = array[0];

            for (int i = 1; i < sizeOfArr; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.Write("min number of this array is ");
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
